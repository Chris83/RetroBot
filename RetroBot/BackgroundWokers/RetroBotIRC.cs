using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using RetroBot.Messenger;

// used for profiling/debuging
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RetroBot.BackgroundWokers
{
    class RetroBotIRC
    {
        private const bool SET_RANDOM_PLAYER = true;
        private const bool SET_USER_DEFINED_PLAYER = false;

        private const int MAX_MESSAGES_SENT = 15;
        private DateTime messageCounterReset;
        private int messageCounter;
        private Dictionary<string, DateTime> userTimers;

        private List<string> firstUsersCommands;
        private bool randomAssignmentOn;

        private int signOnCounter;

        private Random rand;

        private bool[] pausedPlayers;

        private RetroBotMsg renmojitosWelcomeMessage;
        private RetroBotMsg nightcapdsWelcomeMessage;
        private bool rensFirstMessage;
        private bool nightsFirstMessage;

        private Regex commandRegex;

        private int maxCombo;
        private int defaultPlayer;

        public RetroBotIRC()
        {
            firstUsersCommands = new List<string>();
            firstUsersCommands.Add("moobot");

            string strCommandRegex = @"^(upright|right|downright|downleft|left|upleft|up|down|dup|dright|ddown|dleft|cup|cright|cdown|cleft|r|l|z|start|a|b)([(\+)+](upright|right|downright|downleft|left|upleft|up|down|dup|dright|ddown|dleft|cup|cright|cdown|cleft|r|l|z|start|a|b))*$";
            commandRegex = new Regex(strCommandRegex, RegexOptions.IgnoreCase);
            userTimers = new Dictionary<string,DateTime>();
            pausedPlayers = new bool[4]{true, true, true, true};

            messageCounterReset = DateTime.UtcNow.AddSeconds(30);

            rand = new Random();
            
            maxCombo = 3;
            defaultPlayer = 1;
            randomAssignmentOn = false;
            signOnCounter = 0;

            Messenger<int, bool>.AddListener("PlayerPaused", SetPausedPlayers);
            Messenger<int>.AddListener("MaxComboChanged", SetMaxCombo);
            Messenger<bool>.AddListener("ToggleRandomAssignment", ToggleRandomAssignment);
            Messenger<int>.AddListener("DefaultPlayerSet", SetDefaultPlayer);

            renmojitosWelcomeMessage = new RetroBotMsg() { Send = false, Message = "Renmojito, The MASTER Tactician, has entered the room!" };
            nightcapdsWelcomeMessage = new RetroBotMsg() { Send = false, Message = "I just noticed Nightcapd... possible badass." };
            rensFirstMessage = true;
            nightsFirstMessage = true;


            RunIRC();
        }

        public void RunIRC()
        {
            int port;
            string buf, nick, server, chan, pass;
            System.Net.Sockets.TcpClient sock = new System.Net.Sockets.TcpClient();
            System.IO.TextReader input;
            System.IO.TextWriter output;

            nick = "playsretrobot";
            server = "irc.twitch.tv";
            port = 6667;
            chan = "#twitchplaysn64";
            pass = "oauth:3hegym2gkxkodv6b4fljq6b6p61y9tb";
                       
            //Connect to irc server and get input and output text streams from TcpClient.
            sock.Connect(server, port);
            if (!sock.Connected)
            {
                return;
            }
            input = new System.IO.StreamReader(sock.GetStream());
            output = new System.IO.StreamWriter(sock.GetStream());

            //Starting USER and NICK login commands 
            output.Write(
               "USER " + nick + "\n" +
               "PASS " + pass + "\r\n" +
               "NICK " + nick + "\r\n"
            );
            output.Flush();

            //Process each line received from irc server
            while ((buf = input.ReadLine()) != null)
            {

                //Display received irc message
                //
                if (buf != null)
                {
                    // Create new stopwatch
                    //Stopwatch stopwatch = new Stopwatch();

                    // Begin timing
                    //stopwatch.Start();
                    
                    RetroBotMsg rbMsg = new RetroBotMsg() { Send = false, Message = "Unused,Connecting" };

                    if (signOnCounter < 11)
                        signOnCounter++;
                    else
                    {
                        rbMsg = ParseIRC(buf);

                        #region Retrobot's Startting Message
                        if (signOnCounter == 11)
                        {
                            signOnCounter++;
                            if (CanSendMessage())
                            {
                                output.Write("PRIVMSG "+ chan +" :*Beep* *ZIP...* *Boop* Retro Bot's Ready For Work. ZUG ZUG!\r\n");
                                output.Flush();
                            }
                        }
                        #endregion

                        #region Ren's welcome Message
                        if (renmojitosWelcomeMessage.Send)
                        {
                            if (CanSendMessage())
                            {
                                output.Write("PRIVMSG " + chan + " :" + renmojitosWelcomeMessage.Message + "\r\n");
                                output.Flush();

                                renmojitosWelcomeMessage.Send = false;
                            }
                        }
                        #endregion

                        #region Night's welcome Message
                        if (nightcapdsWelcomeMessage.Send)
                        {
                            if (CanSendMessage())
                            {
                                output.Write("PRIVMSG " + chan + " :" + nightcapdsWelcomeMessage.Message + "\r\n");
                                output.Flush();

                                nightcapdsWelcomeMessage.Send = false;
                            }
                        }
                        #endregion

                        #region Retrobot Responses
                        if (rbMsg.Send)
                        {
                            if (CanSendMessage())
                            {
                                output.Write("PRIVMSG " + chan + " :" + rbMsg.Message + "\r\n");
                                output.Flush();
                            }
                        }
                        #endregion
                    }
                                      
                    // Profiling output REMOVE before production!!!!!!!!!!!!
                    // Stop timing
                    /*stopwatch.Stop();
                    using (StreamWriter w = File.AppendText("timerlogs.txt"))
                    {
                        w.WriteLine(stopwatch.ElapsedMilliseconds + "," + rbMsg.Message.Split(' ')[0]);
                    }*/

                    //Send pong reply to any ping messages
                    if (buf.StartsWith("PING ") || (buf.Contains("PING") && buf.Contains("mwax321"))) { output.Write(buf.Replace("PING", "PONG") + "\r\n"); output.Flush(); }

                    if (buf.Contains("mwax321") && buf.Contains("clear"))
                    {
                        //Console.Clear();
                    }

                    if (buf[0] != ':') continue;

                    /* IRC commands come in one of these formats:
                     * :NICK!USER@HOST COMMAND ARGS ... :DATA\r\n
                     * :SERVER COMAND ARGS ... :DATA\r\n
                     */

                    //After server sends 001 command, we can set mode to bot and join a channel
                    if (buf.Split(' ')[1] == "001")
                    {
                        output.Write(
                            //"PRIVMSG jtv :TWITCHCLIENT 2\r\n" +
                           "MODE " + nick + "\r\n" +
                           "JOIN " + chan + "\r\n"
                        );
                        output.Flush();

                        output.Write("TWITCHCLIENT 2\r\n");
                        output.Flush();
                    }
                }
                else
                {
                    //Console.WriteLine("Null detected... ");
                    RunIRC();
                }
            }
            //Console.WriteLine("Null detected... ");
            RunIRC();
        }

        // Start of my functions for RetroBot botting an N64 emulator
        private bool IsJTVMsg(string msg)
        {
            string test = msg.Substring(0, 5);
            if (test == ":jtv ")
            {
                return true;
            }

            return false;
        }

        private bool IsSetPlayerCommand(string msg)
        {

            if (msg.Length >= 7)
                if ("!player" == msg.ToLower().Substring(0, 7))
                    return true;          

            return false;
        }

        private RetroBotMsg RunSetPlayer(string user, string player, bool setRandom)
        {
            
            RetroBotMsg rbMsg = new RetroBotMsg();
            rbMsg.Send = true;

            #region Assign Random Player
            // Randomly assign user to a controller after their first command
            if (randomAssignmentOn && setRandom == SET_RANDOM_PLAYER)
            {
                int randPlayer = rand.Next(4);

                if (!pausedPlayers[randPlayer])
                {
                    randPlayer++;
                    //rbMsg.Message ="Player random," + user + " you're controlling player " + randPlayer.ToString() + ". Type !player 1, 2, 3, 4 to change to a different player.";
                    rbMsg.Message = user + " you're controlling player " + randPlayer.ToString() + ". Type !player 1, 2, 3, 4 to change to a different player.";
                    Messenger<string>.Broadcast("ChangePlayer", user + ":" + randPlayer.ToString());

                    // Next see if their first message was a command                    
                    Match myMatch = commandRegex.Match(player.Trim(new char[]{' ', '+'}).Replace(' ', '+'));
                    if (myMatch.Success)
                    {
                        string commandMsg = myMatch.ToString();
                        string[] commands = commandMsg.Split('+');
                        commandMsg = user + ":";
                        if (commands.Length >= maxCombo)
                            commandMsg += String.Join("+", commands, 0, maxCombo);
                        else
                            commandMsg += String.Join("+", commands);
                        Messenger<string>.Broadcast("NewCommands", commandMsg);
                    }

                    return rbMsg;
                }
                else// The player picked was paused/disabled so set them to the default player
                {
                    //rbMsg.Message = "Player default," + user + " you're controlling player " + defaultPlayer.ToString() + ". Type !player 1, 2, 3, 4 to change to a different player.";
                    rbMsg.Message = user + " you're controlling player " + defaultPlayer.ToString() + ". Type !player 1, 2, 3, 4 to change to a different player.";
                    Messenger<string>.Broadcast("ChangePlayer", user + ":" + defaultPlayer.ToString());

                    // Next see if their first message was a command                    
                    Match myMatch = commandRegex.Match(player.Trim(new char[] { ' ', '+' }).Replace(' ', '+'));
                    if (myMatch.Success)
                    {
                        string commandMsg = myMatch.ToString();
                        string[] commands = commandMsg.Split('+');
                        commandMsg = user + ":";
                        if (commands.Length >= maxCombo)
                            commandMsg += String.Join("+", commands, 0, maxCombo);
                        else
                            commandMsg += String.Join("+", commands);
                        Messenger<string>.Broadcast("NewCommands", commandMsg);
                    }

                    return rbMsg;
                }                
            }
            #endregion

            #region Check the last time a User changed players
            if (userTimers.ContainsKey(user))
            {
                if (userTimers[user] > DateTime.UtcNow)
                {
                    //rbMsg.Message = "Player change," + char.ToUpper(user[0]) + user.Substring(1) + " you've changed players too recently, please wait a minute and try again.";
                    rbMsg.Message = char.ToUpper(user[0]) + user.Substring(1) + " you've changed players too recently, please wait a minute and try again.";
                    return rbMsg;
                }
            }
            #endregion

            #region Change the player for the user if able
            char playerNumber = player.TrimEnd().Last();
            int pNum = (int)char.GetNumericValue(playerNumber);
            if (pNum >= 1 && pNum <= 4)
            {
                if (!pausedPlayers[pNum-1])
                {
                    if (userTimers.ContainsKey(user))
                        userTimers[user] = DateTime.UtcNow.AddMinutes(1);
                    else
                        userTimers.Add(user, DateTime.UtcNow.AddMinutes(1));

                    //broadcast message that a player wants to change players if the player hasnt recently changed
                    //rbMsg.Message = "Player change," + user + " is now controlling " + player.Substring(1) + ".";
                    rbMsg.Message = user + " is now controlling " + player.Substring(1) + ".";
                    Messenger<string>.Broadcast("ChangePlayer", user + ":" + player);
                    return rbMsg;
                }
                else
                {
                    //rbMsg.Message = "Player change,Sorry, " + user + player.Substring(1) + " is disabled, please choose another palyer.";
                    rbMsg.Message = "Sorry, " + user + ". Please wait until the game starts to change controllers.";
                    return rbMsg;
                }
            }
            #endregion

            // If we get to this point the change player command was incorrect or help was requested
            //rbMsg.Message = "Player help,Type !player 1, 2, 3 or 4 to switch which controller you're playing. Example: !player 2";
            rbMsg.Message = "Type !player 1, 2, 3 or 4 to switch which controller you're playing. Example: !player 2";
            return rbMsg;
        }

        private RetroBotMsg ParseIRC(string msg)
        {
            if (IsJTVMsg(msg))
            {
                // If the message is from jtv see if it is information telling us a subscriber.
                string[] msgParts = msg.Split(' ');
                if (msgParts.Length == 6)
                {
                    if (msgParts[3] == ":SPECIALUSER" && msgParts[5] == "subscriber")
                    {
                        Messenger<string>.Broadcast("SubscriberDetected", msgParts[4]);
                    }
                }
            }
            else
            {
                string[] msgParts = msg.Split(':');

                if (msgParts.Length >= 3)
                {
                    string user = msgParts[1].Split('!')[0];

                    // This needs to be changed so that it assigns the default player if Random Assignment is turned off. Otherwise work the way it does now.
                    if (!firstUsersCommands.Contains(user))
                    {
                        if (user == "renmojito" && rensFirstMessage == true)
                        {
                            rensFirstMessage = false;
                            renmojitosWelcomeMessage.Send = true;
                        }
                        if (user == "nightcapd" && nightsFirstMessage == true)
                        {
                            nightsFirstMessage = false;
                            nightcapdsWelcomeMessage.Send = true;
                        }

                        firstUsersCommands.Add(user);
                        if (randomAssignmentOn)
                        {
                            if (IsSetPlayerCommand(msgParts[2])) // We dont want to randomly assign them to a player if they are choosing one for their first cchat message. That is rude.
                                return RunSetPlayer(user, msgParts[2], SET_USER_DEFINED_PLAYER);
                            else
                                return RunSetPlayer(user, msgParts[2], SET_RANDOM_PLAYER);
                        }
                        else
                        {
                            if (IsSetPlayerCommand(msgParts[2])) // We dont want to force them to the default player if they are choosing one for their first cchat message. That is rude.
                                return RunSetPlayer(user, msgParts[2], SET_USER_DEFINED_PLAYER);
                            else
                            {
                                // Set them to the default player and let them know.
                                Messenger<string>.Broadcast("ChangePlayer", user + ":" + defaultPlayer.ToString());

                                // See if we have commands for a player
                                Match myMatch = commandRegex.Match(msgParts[2].Trim(new char[] { ' ', '+' }).Replace(' ', '+'));
                                if (myMatch.Success)
                                {
                                    string commandMsg = myMatch.ToString();
                                    //Messenger<string>.Broadcast("FollowerDetected", user); // This can be reactivated at a later time when we separate out followers/subs/donators/topdonator
                                    // We only want the first 3 commands...

                                    string[] commands = commandMsg.Split('+');
                                    commandMsg = user + ":";
                                    if (commands.Length >= maxCombo)
                                        commandMsg += String.Join("+", commands, 0, maxCombo);
                                    else
                                        commandMsg += String.Join("+", commands);
                                    Messenger<string>.Broadcast("NewCommands", commandMsg);
                                }

                                return new RetroBotMsg() { Send = true, Message = user + " you're controlling player " + defaultPlayer.ToString() + ". Type !player 1, 2, 3, 4 to change to a different player." };
                            }
                        }
                    }                    

                    if (IsSetPlayerCommand(msgParts[2]))
                    {
                        return RunSetPlayer(user, msgParts[2], SET_USER_DEFINED_PLAYER);
                    }
                    else
                    {
                        // See if we have commands for a player
                        Match myMatch = commandRegex.Match(msgParts[2].Trim(new char[] { ' ', '+' }).Replace(' ', '+'));
                        if (myMatch.Success)
                        {
                            string commandMsg = myMatch.ToString();
                            //Messenger<string>.Broadcast("FollowerDetected", user); // This can be reactivated at a later time when we separate out followers/subs/donators/topdonator
                            // We only want the first 3 commands...

                            string[] commands = commandMsg.Split('+');
                            commandMsg = user + ":";
                            if (commands.Length >= maxCombo)
                                commandMsg += String.Join("+", commands, 0, maxCombo);
                            else
                                commandMsg += String.Join("+", commands);
                            Messenger<string>.Broadcast("NewCommands", commandMsg);
                            return new RetroBotMsg() { Send = false, Message = "Command,"+commandMsg };
                        }

                    }
                    return new RetroBotMsg() { Send = false, Message = "Regular chat," + msgParts[2].ToString() };
                }
            }
            return new RetroBotMsg() { Send = false, Message = "Uncateorized chat,ignored"};
        }

        private bool CanSendMessage()
        {
            // Reset our message counters.
            if (DateTime.UtcNow > messageCounterReset)
            {
                messageCounter = 0;
                messageCounterReset = DateTime.UtcNow.AddSeconds(30);
            }

            messageCounter++;

            if (messageCounter < MAX_MESSAGES_SENT)
                return true;

            return false;

        }

        #region Listener Functions
        private void SetPausedPlayers(int player, bool paused)
        {
            switch(player){
                case 1:
                    pausedPlayers[0] = paused;
                    break;
                case 2:
                    pausedPlayers[1] = paused;
                    break;
                case 3:
                    pausedPlayers[2] = paused;
                    break;
                case 4:
                    pausedPlayers[3] = paused;
                    break;
                case 5:
                    pausedPlayers[0] = paused;
                    pausedPlayers[1] = paused;
                    pausedPlayers[2] = paused;
                    pausedPlayers[3] = paused;
                    break;
                default:
                    break;
            }
        }

        private void SetMaxCombo(int max)
        {
            if (1 <= max && max <= 5)
                maxCombo = max;
        }
        
        private void ToggleRandomAssignment(bool randomness)
        {
            randomAssignmentOn = randomness;
        }

        private void SetDefaultPlayer(int player)
        {
            defaultPlayer = player + 1;
        }
        #endregion
    }

    struct RetroBotMsg
    {
        bool send;
        string message;

        public bool Send
        {
            get { return send; }
            set { send = value; }
        }

        public string Message
        {
            get { return char.ToUpper(message[0]) + message.Substring(1); }
            set { message = value; }
        }
    }
}
