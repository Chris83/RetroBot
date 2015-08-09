using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RetroBot.Messenger;

namespace RetroBot
{
    class PlayerContol
    {
        private bool[] paused;                  // Holds the pause state for the corresponding player.
        private PlayerInput[] playerInputs;     // Holds the Input type for filtering commands to the right Player on the emulator.
        private List<string>[] oldGuestList;    // Hold the previous string for updating the Dictionary of individual Twitch Users.
        private List<string> donatorList;
        private List<string> topDonatorList;

        private Dictionary<string, PlayerInput> playerLookUp;

        public PlayerContol()
        {
            // We have 5 possible players to pause counting All
            paused = new bool[5]{true,true,true,true,true};
            // Set all the players to take commands from followers by default.
            playerInputs = new PlayerInput[5] { PlayerInput.Disabled, PlayerInput.Follower, PlayerInput.Follower, PlayerInput.Follower, PlayerInput.Follower };
            // Set all the oldGuestList elements to an empty List<string> initially.
            oldGuestList = new List<string>[5] { new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>() };
            donatorList = new List<string>();
            topDonatorList = new List<string>();

            playerLookUp = new Dictionary<string, PlayerInput>();

            InitMessengerListeners();
        }

        private void InitMessengerListeners()
        {
            Messenger<Player>.AddListener("TogglePlayerPause", TogglePause);
            Messenger<Player, PlayerInput>.AddListener("SetPlayerInput", SetPlayerInput);
            Messenger<Player, PlayerInput, string>.AddListener("UpdatePlayerList", UpdatePlayerList);
            Messenger<Player, PlayerInput>.AddListener("UIRequestsGuestList", SendGuestListToUI);
            Messenger<string>.AddListener("SubscriberDetected", SubscriberDetected);
            Messenger<string>.AddListener("FollowerDetected", FollowerDetected);
            Messenger<string>.AddListener("ChangePlayer", ChangePlayerForUser);
        }

        public bool IsPaused(Player player)
        {
            return paused[(int)player];
        }

        public Player GetPlayerFromName(string name)
        {
            if (playerLookUp.ContainsKey(name))
                if ((int)Array.IndexOf(playerInputs, playerLookUp[name]) > 0)
                    return (Player)Array.IndexOf(playerInputs, playerLookUp[name]);

            // If the name isnt connected to a player return Player.All, this will be ignored as the current name isnt controlling
            // an active player at the moment. This can happen when we have four guest players and the name is linked to a follower.
            return Player.All;
        }

        /// <summary>
        /// This function will add a player to our lookup table. Mostly will be used by our IRC Parser
        /// to add subscribers and everyoen else to the list of players.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="playerInput"></param>
        public void AddToLookUp(string name)
        {
            if (!playerLookUp.ContainsKey(name))
            {
                playerLookUp.Add(name, PlayerInput.Follower);
            }
        }
        public void AddToLookUp(string name, PlayerInput pInput)
        {
            Player player = GetPlayerFromInput(pInput);
            if (!playerLookUp.ContainsKey(name))
            {
                playerLookUp.Add(name, pInput);
            }
            else
            {
                PlayerInput playerTest = playerLookUp[name];
                if ((int)pInput > (int)playerTest)
                    playerLookUp[name] = pInput;
            }
        }

        private Player GetPlayerFromInput(PlayerInput input){
            for(int i=1; i< playerInputs.Length; i++){
                if (playerInputs[i] == input)
                    return (Player)i;
            }

            return Player.All;
        }

        #region Messenger Functions
        private void ChangePlayerForUser(string info)
        {
            string user = info.Split(':')[0];
            PlayerInput pInput = playerInputs[(int)Char.GetNumericValue(info.Last())];

            if (playerLookUp.ContainsKey(user))
                playerLookUp[user] = pInput;
            else
                AddToLookUp(user, pInput);
        }

        private void TogglePause(Player player){
            paused[(int)player] = !paused[(int)player];

            if(player == Player.All)
            {
                // Gotta make the rest the same as Player.All
                for (int i = 1; i < paused.Length; i++)
                {
                    paused[i] = paused[(int)player];
                }
            }
        }

        private void SetPlayerInput(Player player, PlayerInput playerInput)
        {
            playerInputs[(int)player] = playerInput;
        }

        //TODO: find out why when you first take some oen off of a guest they dont become a follower... its super duper annoying!
        private void UpdatePlayerList(Player player, PlayerInput playerInput, string list)
        {
            #region Guest
            // Handle the list as a guest list if the player input is set to a guest.
            if ((int)playerInput >= (int)PlayerInput.Guest1)
            {
                IEnumerable<string> modifyingList;
                // Convert the list into an array of separate guests.
                string[] newGuestList = list.Split(',');

                if (oldGuestList[(int)player].Count > 0) // OMG! it's right here! if the list is empty cause we removed all the guests but the old guest list is empty then they dont actually get removed!
                {
                    // First we changes all old guests if they are not part of the new list to followers.
                    modifyingList = oldGuestList[(int)player].Except(newGuestList);
                    foreach (string name in modifyingList)
                    {
                        if (playerLookUp.ContainsKey(name))
                        {
                            playerLookUp[name] = PlayerInput.Follower;
                        }
                        else
                            AddToLookUp(name); // If for some reason a previous guest was not in the list add them in as a Follower
                    }
                }

                // Next we add any new names to the dictionary.
                modifyingList = newGuestList.Except(oldGuestList[(int)player]);
                foreach (string name in modifyingList)
                {
                    if (playerLookUp.ContainsKey(name))
                    {   // If the name is already in the Dictionary just update the player it's controlling
                        playerLookUp[name] = playerInput;
                    }
                    else
                    {   // Else just add the name into the Dictionary with the player it's controlling
                        playerLookUp.Add(name, playerInput);
                    }
                }
                // Set the new list as the old for the next time we get a list of guests.
                oldGuestList[(int)player] = newGuestList.ToList();
            }
            #endregion

            #region Top Donator
            // Handle the list as a top donator list if player input is set to top donator
            if (playerInput == PlayerInput.TopDonator)
            {
                IEnumerable<string> modifyingList;
                // Convert the list into an array of separate guests.
                string[] newTopDonatorList = list.Split(',');

                if (topDonatorList.Count > 0)
                {
                    // First we changes all old top donators if they are not part of the new list to donators.
                    modifyingList = topDonatorList.Except(newTopDonatorList);
                    foreach (string name in modifyingList)
                    {
                        if (playerLookUp.ContainsKey(name))
                            playerLookUp[name] = PlayerInput.Donator;
                        else
                            AddToLookUp(name, PlayerInput.Donator); // If for some reason a previous top donator was not in the list add them in as a Donator
                    }
                }

                modifyingList = newTopDonatorList.Except(topDonatorList);
                foreach (string name in modifyingList)
                {
                    if (playerLookUp.ContainsKey(name))
                    {   // If the name is already in the Dictionary just update the player it's controlling
                        playerLookUp[name] = playerInput;
                    }
                    else
                    {   // Else just add the name into the Dictionary with the player it's controlling
                        playerLookUp.Add(name, playerInput);
                    }
                }

                // Set the new list as the old for the next time we get a list of guests.
                topDonatorList = newTopDonatorList.ToList();

                // If Donators are not controlling a player for some reason we dont need to push the updated list to the UI.
                if ((int)Array.IndexOf(playerInputs, PlayerInput.Donator) > 0)
                {
                    player = (Player)Array.IndexOf(playerInputs, PlayerInput.Donator);

                    list = string.Join(",", donatorList);

                    // Send the requested data back to the UI.
                    Messenger<Player, string>.Broadcast("PlayerListUIResponse", player, list);
                }
            }
            #endregion

            #region Donator
            // Handle the list as a guest list if the player input is set to a guest.
            if (playerInput == PlayerInput.Donator)
            {
                IEnumerable<string> modifyingList;
                // Convert the list into an array of separate guests.
                string[] newDonatorList = list.Split(',');

                if (donatorList.Count > 0)
                {
                    // First we changes all old guests if they are not part of the new list to followers.
                    modifyingList = donatorList.Except(newDonatorList);
                    foreach (string name in modifyingList)
                    {
                        if (playerLookUp.ContainsKey(name))
                            playerLookUp[name] = PlayerInput.Follower;
                        else
                            AddToLookUp(name); // If for some reason a previous guest was not in the list add them in as a Follower
                    }
                }

                // Next we add any new names to the dictionary.
                modifyingList = newDonatorList.Except(donatorList);
                foreach (string name in modifyingList)
                {
                    if (playerLookUp.ContainsKey(name))
                    {   // If the name is already in the Dictionary just update the player it's controlling
                        playerLookUp[name] = playerInput;
                    }
                    else
                    {   // Else just add the name into the Dictionary with the player it's controlling
                        playerLookUp.Add(name, playerInput);
                    }
                }

                // Set the new list as the old for the next time we get a list of guests.
                donatorList = newDonatorList.ToList();
            }
            #endregion
        }

        private void SendGuestListToUI(Player player, PlayerInput playerInput)
        {
            string list;

            if ((int)playerInput >= (int)PlayerInput.Guest1)
                list = string.Join(",", oldGuestList[(int)player]);
            else if (playerInput == PlayerInput.Donator)
                list = string.Join(",", donatorList);
            else if (playerInput == PlayerInput.TopDonator)
                list = string.Join(",", topDonatorList);
            else
                list = "";

            // Send the requested data back to the UI.
            Messenger<Player, string>.Broadcast("PlayerListUIResponse", player, list);
        }

        private void SubscriberDetected(string name){
            AddToLookUp(name, PlayerInput.Subscriber);
        }

        private void FollowerDetected(string name)
        {
            AddToLookUp(name);
        }
        #endregion
    }
}