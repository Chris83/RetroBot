using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using RetroBot.Messenger;
using System.Diagnostics;

namespace RetroBot
{
    class KeyControl
    {
        private Dictionary<int, Key>[] DisabledControls;

        public KeyControl()
        {
            DisabledControls = new Dictionary<int, Key>[]{
                new Dictionary<int, Key>(),
                new Dictionary<int, Key>(),
                new Dictionary<int, Key>(),
                new Dictionary<int, Key>(),
                new Dictionary<int, Key>()
            };

            InitMessengerListeners();
        }

        private void InitMessengerListeners()
        {

            Messenger<SingleDisabledKey>.AddListener("SingleKeyControlEnabled", ToggleKeyControl);
            Messenger<Player>.AddListener("UIRequestsKeyControlData", SendKeyControlDataToUI);
        }

        public bool IsKeyDisabled(Player player, Key key)
        {
            // First test if the key is in the All Player Dictionary. If it is then of course it's disabled.
            if (DisabledControls[(int)Player.All].ContainsKey((int)key))
            {
                return true;
            }

            // Now we test for the specified player, 
            // if the player isn't set to Player.All we don't need to run the same check twice.
            if(player != Player.All)
                return DisabledControls[(int)player].ContainsKey((int)key);

            // If we get to this point we know for sure the key is not disabled.
            return false;
        }

        #region Messenger Functions
        /// <summary>
        /// If a key is disabled it is added to the Dictionary.
        /// If a key is enabled it is removed from the Dictionary.
        /// There is a Dictionary for All and one for each Player.
        /// </summary>
        /// <param name="player"></param>
        /// <param name="key"></param>
        /// <param name="enabled"></param>
        private void ToggleKeyControl(SingleDisabledKey data)
        {
            
            if (data.KD_Player == Player.All)
            {
                // If the Key is for all players we have to update all dictionaries.
                for (int i = 0; i < Enum.GetNames(typeof(Player)).Length; i++)
                {
                    #region toggle
                    if (data.Enabled)
                    {
                        if (DisabledControls[i].ContainsKey((int)data.KD_Key))
                            DisabledControls[i].Remove((int)data.KD_Key);
                    }
                    else
                    {
                        if (!DisabledControls[i].ContainsKey((int)data.KD_Key))
                            DisabledControls[i].Add((int)data.KD_Key, data.KD_Key);
                    }
                    #endregion
                }
            }
            else
            {
                // If the Key is only for one player we dont have to worry about looping.
                #region toggle
                if (data.Enabled)
                {
                    //Messenger<string>.Broadcast("SomethingMagical", "ToggleKeyControl: Enable key");
                    if (DisabledControls[(int)data.KD_Player].ContainsKey((int)data.KD_Key))
                        DisabledControls[(int)data.KD_Player].Remove((int)data.KD_Key);
                }
                else
                {
                    //Messenger<string>.Broadcast("SomethingMagical", "ToggleKeyControl: Disable Key");
                    if (!DisabledControls[(int)data.KD_Player].ContainsKey((int)data.KD_Key))
                        DisabledControls[(int)data.KD_Player].Add((int)data.KD_Key, data.KD_Key);
                }
                #endregion
                
            }
        }

        /// <summary>
        /// This function is called when we receive a message that something needs a Dictionary.
        /// We will fire off a new Messenger with the requested data.
        /// </summary>
        /// <param name="player"></param>
        private void SendKeyControlDataToUI(Player player)
        {
            // Since we are sending the data to the UI it may be different than what we would send
            // to the emulator bot.
            if (player == Player.All)
            {
                // Create a custom Dictionary to send back to the UI
                // First we get the Dictionary for all Players, then we will compare it to each Players Dictionary
                Dictionary<int, Key> tempDictionary = DisabledControls[(int)Player.All];

                for (int i = 1; i < Enum.GetNames(typeof(Player)).Length; i++)
                {
                    foreach (KeyValuePair<int, Key> entry in DisabledControls[i])
                    {
                        // Test to see if the disabled control exists already in our Dictionary for All Players.
                        // If it doesnt then we must add it to our dictionary.
                        if (!tempDictionary.ContainsKey(entry.Key))
                        {
                            tempDictionary.Add(entry.Key, entry.Value);
                        }
                    }
                }

                // We have our custom Dictionary
                Messenger<Dictionary<int, Key>>.Broadcast("KeyConrolDataUIResponse", tempDictionary);
            }
            else
            {
                // Send the dictionary for the requested player.
                Messenger<Dictionary<int, Key>>.Broadcast("KeyConrolDataUIResponse", DisabledControls[(int)player]);
            }
        }
        #endregion
    }
}