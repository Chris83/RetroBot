using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RetroBot.Messenger;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace RetroBot.BackgroundWokers
{
    class Player2Processor
    {
        private VirtualKeyCode[] controller;

        public Player2Processor(CommandCunk chunk)
        {
            InitController();

            RunChunk(chunk);
        }

        private void RunChunk(CommandCunk chunk)
        {
            InputSimulator inputSim = new InputSimulator();

            BringToFront(chunk.Window);

            Command[] commands = chunk.Commands.ToArray();
            int currentAction = 0;
            int nextAction = 1;

            int numActions = commands.Length;

            Stopwatch timer = new Stopwatch();
            int maxTime = commands.Last().End;

            timer.Start();
            while (timer.ElapsedMilliseconds <= maxTime)
            {
                if (currentAction < numActions)
                {
                    if (timer.ElapsedMilliseconds >= commands[currentAction].Start && !commands[currentAction].Pressed)
                    {
                        commands[currentAction].Pressed = true;
                        commands[currentAction].Released = false;
                        // KeyDown -- Console.WriteLine("Pressing key " + actions[currentAction].Key + " for " + (actions[currentAction].End - actions[currentAction].Start).ToString() + "ms");
                        inputSim.Keyboard.KeyDown(controller[(int)commands[currentAction].Key]);
                    }

                    if (timer.ElapsedMilliseconds >= commands[currentAction].End && !commands[currentAction].Released)
                    {
                        commands[currentAction].Released = true;
                        // KeyUp  -- Console.WriteLine("Releasing key " + actions[currentAction].Key);
                        inputSim.Keyboard.KeyUp(controller[(int)commands[currentAction].Key]);
                        currentAction++;
                        nextAction++;
                    }

                    // If we have any combined presses need to check the next one to see if we have to press it early
                    if (nextAction < numActions)
                    {
                        if (timer.ElapsedMilliseconds >= commands[nextAction].Start && !commands[nextAction].Pressed)
                        {
                            commands[nextAction].Pressed = true;
                            commands[nextAction].Released = false;
                            // KeyDown -- Console.WriteLine("Pressing key " + actions[nextAction].Key + " for " + (actions[nextAction].End - actions[nextAction].Start).ToString() + "ms");
                            inputSim.Keyboard.KeyDown(controller[(int)commands[nextAction].Key]);
                        }
                    }
                }
            }
            timer.Stop();

            // This is the old way... The new way is mroe flexible and should take less time to execute,
            // by sending less keys than initially input when able.
            /*bool[] keyPressedUp = new bool[chunk.Commands.Count];
            Key lastKey = new Key();

            for (int i = 0; i < chunk.Commands.Count; i++)
            {
                keyPressedUp[i] = false;

                if (i > 0 && lastKey == chunk.Commands[i])
                {
                    keyPressedUp[i - 1] = true;
                    inputSim.Keyboard.KeyUp(controller[(int)chunk.Commands[i]]);
                    Thread.Sleep(25);
                }

                inputSim.Keyboard.KeyDown(controller[(int)chunk.Commands[i]]);
                Thread.Sleep(25);

                lastKey = chunk.Commands[i];
            }

            for (int i = 0; i < chunk.Commands.Count; i++)
            {
                if (!keyPressedUp[i])
                {
                    inputSim.Keyboard.KeyUp(controller[(int)chunk.Commands[i]]);
                    Thread.Sleep(25);
                }
            }*/
        }

        private void InitController()
        {
            controller = new VirtualKeyCode[18];

            // Analog Stick
            controller[(int)Key.AnalogUp] = VirtualKeyCode.BACK;
            controller[(int)Key.AnalogRight] = VirtualKeyCode.VK_A;
            controller[(int)Key.AnalogDown] = VirtualKeyCode.VK_S;
            controller[(int)Key.AnalogLeft] = VirtualKeyCode.VK_D;

            // D Pad
            controller[(int)Key.DPadUp] = VirtualKeyCode.VK_F;
            controller[(int)Key.DPadRight] = VirtualKeyCode.VK_G;
            controller[(int)Key.DPadDown] = VirtualKeyCode.VK_H;
            controller[(int)Key.DPadLeft] = VirtualKeyCode.VK_J;

            // C Buttons
            controller[(int)Key.CUp] = VirtualKeyCode.VK_K;
            controller[(int)Key.CRight] = VirtualKeyCode.VK_L;
            controller[(int)Key.CDown] = VirtualKeyCode.OEM_1;
            controller[(int)Key.CLeft] = VirtualKeyCode.OEM_7;

            // Triggers
            controller[(int)Key.RTrigger] = VirtualKeyCode.RETURN;
            controller[(int)Key.LTrigger] = VirtualKeyCode.NUMPAD4;
            controller[(int)Key.ZTrigger] = VirtualKeyCode.VK_0;

            // Other Buttons
            controller[(int)Key.Start] = VirtualKeyCode.NUMPAD6;
            controller[(int)Key.A] = VirtualKeyCode.ADD;
            controller[(int)Key.B] = VirtualKeyCode.LCONTROL;
        }

        #region Dll Imports
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        #endregion

        #region Window Control Functions
        private bool IsActiveWindow(IntPtr h)
        {
            const int nChars = 256;
            StringBuilder window1 = new StringBuilder(nChars);
            StringBuilder window2 = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, window1, nChars) > 0 && GetWindowText(h, window2, nChars) > 0)
            {
                return window1.ToString() == window2.ToString();
            }

            return false;
        }

        public void BringToFront(string title)
        {
            // Get a handle to the Calculator application.
            IntPtr handle = FindWindow(null, title);

            // Verify that Calculator is a running process.
            if (handle == IntPtr.Zero)
            {
                return;
            }

            // Make Calculator the foreground application
            if (!IsActiveWindow(handle))
            {
                SetForegroundWindow(handle);
                Thread.Sleep(50);
            }
        }
        #endregion
    }
}
