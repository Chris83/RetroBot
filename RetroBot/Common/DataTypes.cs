using System.Collections.Generic;
using System.Drawing;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace RetroBot
{
    enum Player
    {
        All,
        Player1,
        Player2,
        Player3,
        Player4
    }

    // Remove after adding in Key Profiles
    enum Key
    {
        AnalogUp, AnalogRight, AnalogDown, AnalogLeft,
        DPadUp, DPadRight, DPadDown, DPadLeft,
        CUp, CRight, CDown, CLeft,
        RTrigger, LTrigger, ZTrigger,
        Start, A, B
    }

    struct KeyPressInfo
    {
        public bool SameKeyAction { get; set; }
        public bool DifferentKeyAction { get; set; }
        public int Delay { get; set; }
        public bool Scaling { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }

    struct SingleDisabledKey
    {
        Player KD_player;
        Key KD_key;
        bool enabled;

        public Player KD_Player
        {
            get { return KD_player; }
            set { KD_player = value; }
        }
        public Key KD_Key
        {
            get { return KD_key; }
            set { KD_key = value; }
        }
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }
    }

    enum PlayerInput
    {
        Disabled,
        Follower,
        Subscriber,
        Donator,
        TopDonator,
        Guest1,
        Guest2,
        Guest3,
        Guest4
    }
        
    struct CommandCunk
    {
        string window;
        List<Command> commands;

        public string Window
        {
            get { return window; }
            set { window = value; }
        }

        public List<Command> Commands
        {
            get { return commands; }
            set { commands = value; }
        }
    }

    struct Command
    {
        Key key;
        int start;
        int end;
        bool pressed;
        bool released;

        #region Setters/Getters
        public Key Key
        {
            get { return key; }
            set { key = value; }
        }

        public int Start
        {
            get { return start; }
            set { start = value; }
        }

        public int End
        {
            get { return end; }
            set { end = value; }
        }

        public bool Pressed
        {
            get { return pressed; }
            set { pressed = value; }
        }

        public bool Released
        {
            get { return released; }
            set { released = value; }
        }
        #endregion
    }

    public class CommandInfo
    {
        string command;
        Color color;

        public CommandInfo(string cmd, Color c)
        {
            command = cmd;
            color = c;
        }

        #region Setters/Getters
        public string Command
        {
            get { return command; }
            set { command = value; }
        }

        public Color Color
        {
            get { return color; }
            set { color = value; }
        }
        #endregion
    }
}