using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RetroBot.Messenger;
using System.Drawing;

namespace RetroBot
{
    class CommandManager
    {
        private KeyPressProfile keyProfiles;
        private KeyControl disabledKeys;
        private PlayerContol players;
        private Dictionary<string, Key> keyLookupDictionary;
        private string gameWindowTitle;

        private Color[] commandColors;

        private int numberOfCommands;
        private DateTime timer;
        private int timeElapsed;

        public CommandManager()
        {
            keyProfiles = new KeyPressProfile();
            disabledKeys = new KeyControl();
            players = new PlayerContol();

            commandColors = new Color[5] { Color.Black,
                ColorTranslator.FromHtml("#FE2015"), // Player 1
                ColorTranslator.FromHtml("#1943F9"), // Player 2
                ColorTranslator.FromHtml("#FFC001"), // Player 3
                ColorTranslator.FromHtml("#079330")  // Player 4
            };

            gameWindowTitle = "Super Smash Bros. (U) - Project64 2.0";

            InitKeyLookupDictionary();

            Messenger<string>.AddListener("SetGameWindow", SetGameWindow);
            Messenger<string>.AddListener("NewCommands", GenerateCunk);

            numberOfCommands = 1;
            timer = DateTime.Now.AddMinutes(1);
        }

        private void InitKeyLookupDictionary()
        {
            keyLookupDictionary = new Dictionary<string,Key>();

            // Analog Stick
            keyLookupDictionary.Add("up", Key.AnalogUp);
            keyLookupDictionary.Add("right", Key.AnalogRight);
            keyLookupDictionary.Add("down", Key.AnalogDown);
            keyLookupDictionary.Add("left", Key.AnalogLeft);
            // D Pad
            keyLookupDictionary.Add("dup", Key.DPadUp);
            keyLookupDictionary.Add("dright", Key.DPadRight);
            keyLookupDictionary.Add("ddown", Key.DPadDown);
            keyLookupDictionary.Add("dleft", Key.DPadLeft);
            // C Button
            keyLookupDictionary.Add("cup", Key.CUp);
            keyLookupDictionary.Add("cright", Key.CRight);
            keyLookupDictionary.Add("cdown", Key.CDown);
            keyLookupDictionary.Add("cleft", Key.CLeft);
            // Triggers
            keyLookupDictionary.Add("r", Key.RTrigger);
            keyLookupDictionary.Add("l", Key.LTrigger);
            keyLookupDictionary.Add("z", Key.ZTrigger);
            // Other
            keyLookupDictionary.Add("start", Key.Start);
            keyLookupDictionary.Add("a", Key.A);
            keyLookupDictionary.Add("b", Key.B);
        }

        private void SetGameWindow(string window)
        {
            gameWindowTitle = window;
        }

        private void GenerateCunk(string cmdString)
        {
            TallyCommand();

            string commandInformation = "";
            // First break up the command string. The format is <name>:<commands>
            cmdString = cmdString.ToLower();
            string[] cmdStringParts = cmdString.Split(':');
            // Get the player the command is for.            
            Player player = players.GetPlayerFromName(cmdStringParts[0]);
            // Only continue if the player is not paused and player is not set to All.
            if (!players.IsPaused(player) && player != Player.All)
            {
                commandInformation += cmdStringParts[0]+": ";
                #region Parse Commands
                // Get the individual commands.
                string[] commandsString = cmdStringParts[1].Split('+');
                List<Key> commands = new List<Key>();
                for (int i = 0; i < commandsString.Length; i++)
                {
                    commandInformation += commandsString[i] + "+";
                    switch (commandsString[i])
                    {
                        case "upright":
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogUp))
                                commands.Add(Key.AnalogUp);
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogRight))
                                commands.Add(Key.AnalogRight);
                            break;
                        case "downright":
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogDown))
                                commands.Add(Key.AnalogDown);
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogRight))
                                commands.Add(Key.AnalogRight);
                            break;
                        case "downleft":
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogDown)) 
                                commands.Add(Key.AnalogDown);
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogLeft)) 
                                commands.Add(Key.AnalogLeft);
                            break;
                        case "upleft":
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogUp)) 
                                commands.Add(Key.AnalogUp);
                            if (!disabledKeys.IsKeyDisabled(player, Key.AnalogLeft)) 
                                commands.Add(Key.AnalogLeft);
                            break;
                        default:
                            Key tempKey = keyLookupDictionary[commandsString[i]];
                            if (!disabledKeys.IsKeyDisabled(player, tempKey))
                                commands.Add(tempKey);
                            break;
                    }
                }

                commandInformation = commandInformation.Substring(0, commandInformation.Length - 1);
                Messenger<CommandInfo>.Broadcast("DisplayCommandInformation", new CommandInfo(commandInformation, commandColors[(int)player]));
                //TODO: figure this shit out right here!!! ---------------^^^^^^^^

                CommandCunk cmdChunk = new CommandCunk();
                cmdChunk.Window = gameWindowTitle;
                
                //This needs to be rewritten.... Should be working with the new KeyPressProfile data
                // Still need to get Scaling Delay working
                cmdChunk.Commands = ProcessCommands(commands.ToArray());
                #endregion

                #region Send Commands
                // Now that we have the correct Player and the commands for that play to use
                // we send them to the appropriate command processor for the emulator.
                switch (player)
                {
                    case Player.Player1:
                        Messenger<CommandCunk>.Broadcast("Player1ProcessCommands", cmdChunk);
                        break;
                    case Player.Player2:
                        Messenger<CommandCunk>.Broadcast("Player2ProcessCommands", cmdChunk);                        
                        break;
                    case Player.Player3:
                        Messenger<CommandCunk>.Broadcast("Player3ProcessCommands", cmdChunk);
                        break;
                    case Player.Player4:
                        Messenger<CommandCunk>.Broadcast("Player4ProcessCommands", cmdChunk);
                        break;
                    default:
                        break;
                }
                #endregion
            }
        }

        private List<Command> ProcessCommands(Key[] keys)
        {
            List<Command> commands = new List<Command>();

            int totalKeys = keys.Length;

            KeyPressInfo current;
            KeyPressInfo next;
            Command configuredPress = new Command()
            {
                Key = keys[0],
                Start = 0,
                End =  keyProfiles.GetInfo(keys[0]).Delay,
                Pressed = false,
                Released = true
            };

            if (keyProfiles.GetInfo(keys[0]).Scaling)
                configuredPress.End = CalculateScaledDelay(keyProfiles.GetInfo(keys[0]));


            for (int i = 0; i < totalKeys; i++)
            {
                current = keyProfiles.GetInfo(keys[i]);

                // If this is the only key we get just add it as a regular action.
                if (totalKeys == 1)
                {
                    commands.Add(configuredPress);
                }
                else
                {
                    // If we have more than one key to process get the next one so we can decide what we need to do.

                    // We are not on the last key yet.
                    if (i + 1 < totalKeys)
                    {
                        next = keyProfiles.GetInfo(keys[i + 1]);

                        // Is the next Key the same as the current one?
                        if (keys[i] == keys[i + 1]) // Yes
                        {
                            if (current.SameKeyAction == KeyPressProfile.COMBINE_PRESS) // The current key and the next key match and the press is combined.
                                if (next.Scaling)
                                    configuredPress.End = CalculateScaledDelay(next); 
                                else
                                    configuredPress.End += next.Delay;

                            if (current.SameKeyAction == KeyPressProfile.DISTINCT_PRESS) // The current key and the next match and are treated as separat presses.
                            {
                                commands.Add(configuredPress); // Add the currently configured press to the action list, we are startign a new action.
                                configuredPress.Key = keys[i + 1];
                                configuredPress.Start = configuredPress.End + KeyPressProfile.PRESS_PADDING;
                                if (next.Scaling)
                                    configuredPress.End = CalculateScaledDelay(next);
                                else
                                    configuredPress.End = configuredPress.Start + next.Delay;
                            }
                        }
                        else // No
                        {
                            if (current.DifferentKeyAction == KeyPressProfile.COMBINE_PRESS)
                            {
                                commands.Add(configuredPress);
                                configuredPress.Key = keys[i + 1];
                                if (next.Scaling)
                                    configuredPress.Start = CalculateScaledDelay(next);
                                else
                                    configuredPress.Start = configuredPress.End - next.Delay + KeyPressProfile.PRESS_PADDING;
                                configuredPress.End += KeyPressProfile.PRESS_PADDING;
                            }

                            if (current.DifferentKeyAction == KeyPressProfile.DISTINCT_PRESS)
                            {
                                commands.Add(configuredPress); // Add the currently configured press to the action list, we are startign a new action.
                                configuredPress.Key = keys[i + 1];
                                configuredPress.Start = configuredPress.End + KeyPressProfile.PRESS_PADDING;
                                if (next.Scaling)
                                    configuredPress.End = CalculateScaledDelay(next);
                                else
                                    configuredPress.End += next.Delay + KeyPressProfile.PRESS_PADDING;
                            }
                        }
                    }
                    // We are on the last key.
                    else
                    {
                        // There was only 2 keys so we need to figure out what to do with it
                        if (i == 2 && i == totalKeys)
                        {
                            if (keys[i] == keys[i - 1]) // Yes
                            {
                                if (current.SameKeyAction == KeyPressProfile.COMBINE_PRESS) // The current key and the next key match and the press is combined.
                                    if (current.Scaling)
                                        configuredPress.End = CalculateScaledDelay(current);
                                    else
                                        configuredPress.End += current.Delay;

                                if (current.SameKeyAction == KeyPressProfile.DISTINCT_PRESS) // The current key and the next match and are treated as separat presses.
                                {
                                    commands.Add(configuredPress); // Add the currently configured press to the action list, we are startign a new action.
                                    configuredPress.Key = keys[i];
                                    configuredPress.Start = configuredPress.End + KeyPressProfile.PRESS_PADDING;
                                    if (current.Scaling)
                                        configuredPress.End = CalculateScaledDelay(current);
                                    else
                                        configuredPress.End = configuredPress.Start + current.Delay;
                                }
                            }
                            else // No
                            {
                                if (current.DifferentKeyAction == KeyPressProfile.COMBINE_PRESS)
                                {
                                    commands.Add(configuredPress);
                                    configuredPress.Key = keys[i];
                                    configuredPress.Start += KeyPressProfile.PRESS_PADDING;
                                    configuredPress.End += KeyPressProfile.PRESS_PADDING;
                                }

                                if (current.DifferentKeyAction == KeyPressProfile.DISTINCT_PRESS)
                                {
                                    commands.Add(configuredPress); // Add the currently configured press to the action list, we are startign a new action.
                                    configuredPress.Key = keys[i];
                                    configuredPress.Start = configuredPress.End + KeyPressProfile.PRESS_PADDING;
                                    if (current.Scaling)
                                        configuredPress.End = CalculateScaledDelay(current);
                                    else
                                        configuredPress.End += current.Delay + KeyPressProfile.PRESS_PADDING;
                                }
                            }
                        }
                        // There was more than 2 keys so in theory we should have the last one in the configured key press
                        // So far this wroks correctly. YAY!!! Just don't ask me how...
                        commands.Add(configuredPress);
                    }
                }
            }
            return commands;
        }

        private void TallyCommand()
        {
            if (timer <= DateTime.Now)
            {
                timer = DateTime.Now.AddMinutes(1);
                numberOfCommands = 0;
            }

            timeElapsed = (int)(DateTime.Now - timer).TotalSeconds + 60;
            numberOfCommands++;
        }

        private int CalculateScaledDelay(KeyPressInfo info)
        {
            // Number of miliseconds in a minute divided by the number of commands received numberOfCommands 
            // should never be 0 it is 1 by default to prevent division by zero.
            int delay = (int)(timeElapsed*1000 / numberOfCommands);

            if (delay > info.Max || delay == 0)
                return info.Max;
            if (delay < info.Min)
                return info.Min;

            return delay;
        }
    }
}
