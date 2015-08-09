using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using RetroBot.Messenger;
using RetroBot.BackgroundWokers;
using System.IO;

namespace RetroBot
{
    public partial class RetroBotForm : Form
    {
        private CommandManager cmdManager;
        private Thread commandInfoThread = null;

        private CommandInfo newCommandInfo;
        
        private bool updatingUI;
        public RetroBotForm()
        {
            
            updatingUI = false;

            InitializeComponent();

            #region Lisenters
            // Add Listener for getting KeyControlData...
            Messenger<Dictionary<int, Key>>.AddListener("KeyConrolDataUIResponse", UpdateKeyControlGroupCheckBoxes);
            // Add Listener for getting a copy of a GuestList for a player...
            Messenger<Player, string>.AddListener("PlayerListUIResponse", PopulatePlayerList);
            Messenger<CommandInfo>.AddListener("DisplayCommandInformation", SetCommandInfo);
            Messenger<KeyPressInfo[]>.AddListener("KPPFileLoaded", SetKPPInfo);
            #endregion

            #region Background Workers
            RetroBotIRCWorker.RunWorkerAsync();
            Messenger<CommandCunk>.AddListener("Player1ProcessCommands", RunPlayer1);
            Messenger<CommandCunk>.AddListener("Player2ProcessCommands", RunPlayer2);
            Messenger<CommandCunk>.AddListener("Player3ProcessCommands", RunPlayer3);
            Messenger<CommandCunk>.AddListener("Player4ProcessCommands", RunPlayer4);
            #endregion

            cmdManager = new CommandManager();

            CurrentGame.SelectedIndex = 16;
            DefaultPlayerComboBox.SelectedIndex = 0;
            KeyControlTarget.SelectedIndex = 0;
            StartEnabled.Checked = false;

            //MessageBox.Show(System.AppDomain.CurrentDomain.BaseDirectory + "Key\\Profiles\\");
        }

        #region KeyControlUI
        private void KeyControlTarget_SelectionChangeCommited(object sender, EventArgs e)
        {            
            Messenger<Player>.Broadcast("UIRequestsKeyControlData", (Player)KeyControlTarget.SelectedIndex);
        }

        private void UpdateKeyControlGroupCheckBoxes(Dictionary<int, Key> disabledKeys)
        {
            updatingUI = true;
            if (disabledKeys.Count == 0)
            {
                // There are no disabled keys. So check every CheckBox.
                AllControlsEnabled.Checked = true;
                foreach (CheckBox c in KeyControlsPanel.Controls)//when the form loads, make sure all the checkboxes are selected.
                {
                    c.Checked = true;
                }
            }
            else
            {
                // We have some disabled keys to keep track off.
                // First uncheck them all.
                AllControlsEnabled.Checked = false;

                // Next we loop through the rest and set the CheckBoxes according to our Dictionary
                foreach (CheckBox c in KeyControlsPanel.Controls) // When the form loads, make sure all the checkboxes are selected.
                {
                    if (disabledKeys.ContainsValue(ConvertCheckBoxNameToKey(c.Name)))
                    {
                        c.Checked = false;
                    }
                    else
                    {
                        c.Checked = true;
                    }
                }
            }
            updatingUI = false;
        }

        private Key ConvertCheckBoxNameToKey(string name)
        {
            return (Key)Enum.Parse(typeof(Key), name.Substring(0, name.Length-7));
        }

        private void AllControlsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                foreach (CheckBox c in KeyControlsPanel.Controls)//when the form loads, make sure all the checkboxes are selected.
                {
                    c.Checked = AllControlsEnabled.Checked;
                }
            }
        }

        private void AnalogLeftEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.AnalogLeft,
                    Enabled = AnalogLeftEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void StartEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.Start,
                    Enabled = StartEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void ZTriggerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.ZTrigger,
                    Enabled = ZTriggerEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void LTriggerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.LTrigger,
                    Enabled = LTriggerEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void RTriggerEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.RTrigger,
                    Enabled = RTriggerEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void CLeftEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.CLeft,
                    Enabled = CLeftEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void CDownEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.CDown,
                    Enabled = CDownEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void CRightEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.CRight,
                    Enabled = CRightEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void CUpEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.CUp,
                    Enabled = CUpEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void AEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.A,
                    Enabled = AEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void DPadLeftEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.DPadLeft,
                    Enabled = DPadLeftEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void DPadDownEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.DPadDown,
                    Enabled = DPadDownEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void DPadRightEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.DPadRight,
                    Enabled = DPadRightEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void DPadUpEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.DPadUp,
                    Enabled = DPadUpEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void AnalogDownEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.AnalogDown,
                    Enabled = AnalogDownEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void AnalogRightEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.AnalogRight,
                    Enabled = AnalogRightEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void AnalogUpEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.AnalogUp,
                    Enabled = AnalogUpEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }

        private void BEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!updatingUI)
            {
                SingleDisabledKey data = new SingleDisabledKey
                {
                    KD_Player = (Player)this.KeyControlTarget.SelectedIndex,
                    KD_Key = Key.B,
                    Enabled = BEnabled.Checked
                };

                if (!data.Enabled)
                {
                    bool temp = updatingUI;
                    updatingUI = true;
                    AllControlsEnabled.Checked = false;
                    updatingUI = temp;
                }

                Messenger<SingleDisabledKey>.Broadcast("SingleKeyControlEnabled", data);
            }
        }
        #endregion

        #region PlayerControlUI
        #region PauseControls
        private void PauseAllButton_Click(object sender, EventArgs e)
        {
            Messenger<Player>.Broadcast("TogglePlayerPause", Player.All);
            if (PauseAllButton.Text == "STOP")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 5, true);
                PauseAllButton.Text = "START";
                PauseAllButton.ForeColor = Color.Green;

                // Now we get the Player PauseButtons to match.
                Player1PauseButton.Text = "START";
                Player1PauseButton.ForeColor = Color.Green;
                Player1InputLabel.Text = "Disabled";
                Player2PauseButton.Text = "START";
                Player2PauseButton.ForeColor = Color.Green;
                Player2InputLabel.Text = "Disabled";
                Player3PauseButton.Text = "START";
                Player3PauseButton.ForeColor = Color.Green;
                Player3InputLabel.Text = "Disabled";
                Player4PauseButton.Text = "START";
                Player4PauseButton.ForeColor = Color.Green;
                Player4InputLabel.Text = "Disabled";
            }
            else if (PauseAllButton.Text == "START")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 5, false);
                PauseAllButton.Text = "STOP";
                PauseAllButton.ForeColor = Color.Red;

                // Now we get the PlayerPause Buttons to match.
                Player1PauseButton.Text = "STOP";
                Player1PauseButton.ForeColor = Color.Red;
                Player1InputLabel.Text = GetInputString(Player1RBPanel);
                Player2PauseButton.Text = "STOP";
                Player2PauseButton.ForeColor = Color.Red;
                Player2InputLabel.Text = GetInputString(Player2RBPanel);
                Player3PauseButton.Text = "STOP";
                Player3PauseButton.ForeColor = Color.Red;
                Player3InputLabel.Text = GetInputString(Player3RBPanel);
                Player4PauseButton.Text = "STOP";
                Player4PauseButton.ForeColor = Color.Red;
                Player4InputLabel.Text = GetInputString(Player4RBPanel);
            }
        }

        private void Player4PauseButton_Click(object sender, EventArgs e)
        {
            Messenger<Player>.Broadcast("TogglePlayerPause", Player.Player4);
            if (Player4PauseButton.Text == "STOP")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 4, true);
                Player4PauseButton.Text = "START";
                Player4PauseButton.ForeColor = Color.Green;
                Player4InputLabel.Text = "Disabled";
            }
            else if (Player4PauseButton.Text == "START")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 4, false);
                Player4PauseButton.Text = "STOP";
                Player4PauseButton.ForeColor = Color.Red;
                Player4InputLabel.Text = GetInputString(Player4RBPanel);
            }
        }

        private void Player2PauseButton_Click(object sender, EventArgs e)
        {
            Messenger<Player>.Broadcast("TogglePlayerPause", Player.Player2);
            if (Player2PauseButton.Text == "STOP")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 2, true);
                Player2PauseButton.Text = "START";
                Player2PauseButton.ForeColor = Color.Green;
                Player2InputLabel.Text = "Disabled";
            }
            else if (Player2PauseButton.Text == "START")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 2, false);
                Player2PauseButton.Text = "STOP";
                Player2PauseButton.ForeColor = Color.Red;
                Player2InputLabel.Text = GetInputString(Player2RBPanel);
            }
        }

        private void Player3PauseButton_Click(object sender, EventArgs e)
        {
            Messenger<Player>.Broadcast("TogglePlayerPause", Player.Player3);
            if (Player3PauseButton.Text == "STOP")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 3, true);
                Player3PauseButton.Text = "START";
                Player3PauseButton.ForeColor = Color.Green;
                Player3InputLabel.Text = "Disabled";
            }
            else if (Player3PauseButton.Text == "START")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 3, false);
                Player3PauseButton.Text = "STOP";
                Player3PauseButton.ForeColor = Color.Red;
                Player3InputLabel.Text = GetInputString(Player3RBPanel);
            }
        }

        private void Player1PauseButton_Click(object sender, EventArgs e)
        {
            Messenger<Player>.Broadcast("TogglePlayerPause", Player.Player1);
            if (Player1PauseButton.Text == "STOP")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 1, true);
                Player1PauseButton.Text = "START";
                Player1PauseButton.ForeColor = Color.Green;
                Player1InputLabel.Text = "Disabled";
            }
            else if (Player1PauseButton.Text == "START")
            {
                Messenger<int, bool>.Broadcast("PlayerPaused", 1, false);
                Player1PauseButton.Text = "STOP";
                Player1PauseButton.ForeColor = Color.Red;
                Player1InputLabel.Text = GetInputString(Player1RBPanel);
            }
        }

        private string GetInputString(Panel panel)
        {
            return panel.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
        }
        #endregion

        private void PopulatePlayerList(Player player, string list){
            switch (player)
            {
                case Player.Player1:
                    Player1GuestList.Text = list;
                    break;
                case Player.Player2:
                    Player2GuestList.Text = list;
                    break;
                case Player.Player3:
                    Player3GuestList.Text = list;
                    break;
                case Player.Player4:
                    Player4GuestList.Text = list;
                    break;
                default:
                    break;
            }
        }

        #region Player1Controller
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            // Player 1 Guest
            // Enable the TextInput and Save Button
            Player1GuestList.Enabled = true;
            SavePlayer1GuestListButton.Enabled = true;

            if (Player1PauseButton.Text != "START")
                Player1InputLabel.Text = "Followers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player1, PlayerInput.Guest1);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player1, PlayerInput.Guest1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // Player 1 Subscribers
            // Clear the TextInput
            Player1GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player1GuestList.Enabled = false;
            SavePlayer1GuestListButton.Enabled = false;

            if (Player1PauseButton.Text != "START")
                Player1InputLabel.Text = "Subscribers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player1, PlayerInput.Subscriber);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Player 1 Donators
            // Enable the TextInput and Save Button
            Player1GuestList.Enabled = true;
            SavePlayer1GuestListButton.Enabled = true;

            if (Player1PauseButton.Text != "START")
                Player1InputLabel.Text = "Donators";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player1, PlayerInput.Donator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player1, PlayerInput.Donator);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // Player 1 Top Donator
            // Enable the TextInput and Save Button
            Player1GuestList.Enabled = true;
            SavePlayer1GuestListButton.Enabled = true;

            if (Player1PauseButton.Text != "START")
                Player1InputLabel.Text = "Top Donator";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player1, PlayerInput.TopDonator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player1, PlayerInput.TopDonator);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Player1 Followewrs
            // Clear the TextInput
            Player1GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player1GuestList.Enabled = false;
            SavePlayer1GuestListButton.Enabled = false;

            if(Player1PauseButton.Text != "START")
                Player1InputLabel.Text = "Viewers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player1, PlayerInput.Follower);
        }

        private void SavePlayer1GuestListButton_Click(object sender, EventArgs e)
        {
            PlayerInput playerInput;
            if (radioButton3.Checked)
            {
                playerInput = PlayerInput.Donator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player1, playerInput, Player1GuestList.Text);
            }
            else if (radioButton4.Checked)
            {
                playerInput = PlayerInput.TopDonator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player1, playerInput, Player1GuestList.Text);
            }
            else if (radioButton5.Checked)
            {
                playerInput = PlayerInput.Guest1;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player1, playerInput, Player1GuestList.Text);
            }
        }
        #endregion

        #region Player2Controller
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            // Player 2 Guest
            // Enable the TextInput and Save Button
            Player2GuestList.Enabled = true;
            SavePlayer2GuestListButton.Enabled = true;

            if (Player2PauseButton.Text != "START")
                Player2InputLabel.Text = "Followers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player2, PlayerInput.Guest2);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player2, PlayerInput.Guest2);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            // Player 2 Subscribers
            // Clear the TextInput
            Player2GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player2GuestList.Enabled = false;
            SavePlayer2GuestListButton.Enabled = false;

            if (Player2PauseButton.Text != "START")
                Player2InputLabel.Text = "Subscribers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player2, PlayerInput.Subscriber);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            // Player 2 Donators
            // Enable the TextInput and Save Button
            Player2GuestList.Enabled = true;
            SavePlayer2GuestListButton.Enabled = true;

            if (Player2PauseButton.Text != "START")
                Player2InputLabel.Text = "Donators";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player2, PlayerInput.Donator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player2, PlayerInput.Donator);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            // Player 2 Top Donator
            // Enable the TextInput and Save Button
            Player2GuestList.Enabled = true;
            SavePlayer2GuestListButton.Enabled = true;

            if (Player2PauseButton.Text != "START")
                Player2InputLabel.Text = "Top Donator";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player2, PlayerInput.TopDonator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player2, PlayerInput.TopDonator);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            // Player2 Followewrs
            // Clear the TextInput
            Player2GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player2GuestList.Enabled = false;
            SavePlayer2GuestListButton.Enabled = false;

            if (Player2PauseButton.Text != "START")
                Player2InputLabel.Text = "Viewers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player2, PlayerInput.Follower);
        }

        private void SavePlayer2GuestListButton_Click(object sender, EventArgs e)
        {
            PlayerInput playerInput;
            if (radioButton8.Checked)
            {
                playerInput = PlayerInput.Donator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player2, playerInput, Player2GuestList.Text);
            }
            else if (radioButton7.Checked)
            {
                playerInput = PlayerInput.TopDonator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player2, playerInput, Player2GuestList.Text);
            }
            else if (radioButton6.Checked)
            {
                playerInput = PlayerInput.Guest2;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player2, playerInput, Player2GuestList.Text);
            }
        }
        #endregion

        #region Player3Controller
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            // Player 3 Guest
            // Enable the TextInput and Save Button
            Player3GuestList.Enabled = true;
            SavePlayer3GuestListButton.Enabled = true;

            if (Player3PauseButton.Text != "START")
                Player3InputLabel.Text = "Followers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player3, PlayerInput.Guest3);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player3, PlayerInput.Guest3);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            // Player 3 Subscribers
            // Clear the TextInput
            Player3GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player3GuestList.Enabled = false;
            SavePlayer3GuestListButton.Enabled = false;

            if (Player3PauseButton.Text != "START")
                Player3InputLabel.Text = "Subscribers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player3, PlayerInput.Subscriber);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            // Player 3 Donators
            // Enable the TextInput and Save Button
            Player3GuestList.Enabled = true;
            SavePlayer3GuestListButton.Enabled = true;

            if (Player3PauseButton.Text != "START")
                Player3InputLabel.Text = "Donators";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player3, PlayerInput.Donator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player3, PlayerInput.Donator);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            // Player 3 Top Donator
            // Enable the TextInput and Save Button
            Player3GuestList.Enabled = true;
            SavePlayer3GuestListButton.Enabled = true;

            if (Player3PauseButton.Text != "START")
                Player3InputLabel.Text = "Top Donator";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player3, PlayerInput.TopDonator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player3, PlayerInput.TopDonator);
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            // Player3 Followewrs
            // Clear the TextInput
            Player3GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player3GuestList.Enabled = false;
            SavePlayer3GuestListButton.Enabled = false;

            if (Player3PauseButton.Text != "START")
                Player3InputLabel.Text = "Viewers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player3, PlayerInput.Follower);
        }

        private void SavePlayer3GuestListButton_Click(object sender, EventArgs e)
        {
            PlayerInput playerInput;
            if (radioButton13.Checked)
            {
                playerInput = PlayerInput.Donator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player3, playerInput, Player3GuestList.Text);
            }
            else if (radioButton12.Checked)
            {
                playerInput = PlayerInput.TopDonator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player3, playerInput, Player3GuestList.Text);
            }
            else if (radioButton11.Checked)
            {
                playerInput = PlayerInput.Guest3;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player3, playerInput, Player3GuestList.Text);
            }
        }
        #endregion

        #region Player4Controller
        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            // Player 4 Guest
            // Enable the TextInput and Save Button
            Player4GuestList.Enabled = true;
            SavePlayer4GuestListButton.Enabled = true;

            if (Player4PauseButton.Text != "START")
                Player4InputLabel.Text = "Followers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player4, PlayerInput.Guest4);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player4, PlayerInput.Guest4);
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            // Player 4 Subscribers
            // Clear the TextInput
            Player4GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player4GuestList.Enabled = false;
            SavePlayer4GuestListButton.Enabled = false;

            if (Player4PauseButton.Text != "START")
                Player4InputLabel.Text = "Subscribers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player4, PlayerInput.Subscriber);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            // Player 4 Donators
            // Enable the TextInput and Save Button
            Player4GuestList.Enabled = true;
            SavePlayer4GuestListButton.Enabled = true;

            if (Player4PauseButton.Text != "START")
                Player4InputLabel.Text = "Donators";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player4, PlayerInput.Donator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player4, PlayerInput.Donator);
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            // Player 4 Top Donator
            // Enable the TextInput and Save Button
            Player4GuestList.Enabled = true;
            SavePlayer4GuestListButton.Enabled = true;

            if (Player4PauseButton.Text != "START")
                Player4InputLabel.Text = "Top Donator";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player4, PlayerInput.TopDonator);

            // Send a Message to get data to Populate the TextBox
            Messenger<Player, PlayerInput>.Broadcast("UIRequestsGuestList", Player.Player4, PlayerInput.TopDonator);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            // Player4 Followewrs
            // Clear the TextInput
            Player4GuestList.Text = "";
            // Disable the TextInput and Save Button
            Player4GuestList.Enabled = false;
            SavePlayer4GuestListButton.Enabled = false;

            if (Player4PauseButton.Text != "START")
                Player4InputLabel.Text = "Viewers";

            // Send a Message to set the controller of Player
            Messenger<Player, PlayerInput>.Broadcast("SetPlayerInput", Player.Player4, PlayerInput.Follower);
        }

        private void SavePlayer4GuestListButton_Click(object sender, EventArgs e)
        {
            PlayerInput playerInput;
            if (radioButton18.Checked)
            {
                playerInput = PlayerInput.Donator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player4, playerInput, Player4GuestList.Text);
            }
            else if (radioButton17.Checked)
            {
                playerInput = PlayerInput.TopDonator;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player4, playerInput, Player4GuestList.Text);
            }
            else if (radioButton16.Checked)
            {
                playerInput = PlayerInput.Guest4;
                Messenger<Player, PlayerInput, string>.Broadcast("UpdatePlayerList", Player.Player4, playerInput, Player4GuestList.Text);
            }
        }
        #endregion

        #endregion

        #region IRCBotControl
        private void RetroBotIRCWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RetroBotIRC bot = new RetroBotIRC();
        }
        #endregion

        #region Command Processors
        private void Player1ProcessorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Player1Processor proccess = new Player1Processor((CommandCunk)e.Argument);
        }

        private void Player2ProcessorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Player2Processor process = new Player2Processor((CommandCunk)e.Argument);
        }

        private void Player3ProcessorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Player3Processor process = new Player3Processor((CommandCunk)e.Argument);
            
        }

        private void Player4ProcessorWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Player4Processor process = new Player4Processor((CommandCunk)e.Argument);
        }

        private void RunPlayer1(CommandCunk chunk)
        {
            if (!Player1ProcessorWorker.IsBusy)
                Player1ProcessorWorker.RunWorkerAsync(chunk);
        }

        private void RunPlayer2(CommandCunk chunk)
        {
            if (!Player2ProcessorWorker.IsBusy)
                Player2ProcessorWorker.RunWorkerAsync(chunk);
        }

        private void RunPlayer3(CommandCunk chunk)
        {
            if (!Player3ProcessorWorker.IsBusy)
                Player3ProcessorWorker.RunWorkerAsync(chunk);
        }

        private void RunPlayer4(CommandCunk chunk)
        {
            if (!Player4ProcessorWorker.IsBusy)
                Player4ProcessorWorker.RunWorkerAsync(chunk);
        }
        #endregion

        private void CurrentGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            Messenger<string>.Broadcast("SetGameWindow", CurrentGame.SelectedItem.ToString());
        }

        //TODO: find a better way to do this shit!
        private void UpdateCommandInformation()
        {
            if (this.CommandInfoWindow.InvokeRequired)
            {
                SetCmdInfoCallback d = new SetCmdInfoCallback(UpdateCommandInformation);
                this.Invoke(d);
            }
            else
            {
                this.CommandInfoWindow.Items.RemoveAt(0);
                int index = this.CommandInfoWindow.Items.Add(newCommandInfo);
            }
        }

        delegate void SetCmdInfoCallback();

        private void SetCommandInfo(CommandInfo cmdInfo)
        {
            
            newCommandInfo = cmdInfo;
            this.commandInfoThread = new Thread(new ThreadStart(this.UpdateCommandInformation));
            this.commandInfoThread.Start();
        }

        private void CommandInfoWindow_DrawItem(object sender, DrawItemEventArgs e)
        {
            CommandInfo item = CommandInfoWindow.Items[e.Index] as CommandInfo; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.Command, // The message linked to the item
                    CommandInfoWindow.Font, // Take the font from the listbox
                    new SolidBrush(item.Color), // Set the color 
                    0, // X pixel coordinate
                    e.Index * CommandInfoWindow.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a CommandInfo, do something about it. I Chose to ignore it.
            }
        }

        private void MaxComboSetter_ValueChanged(object sender, EventArgs e)
        {
            Messenger<int>.Broadcast("MaxComboChanged", (int)this.MaxComboSetter.Value);
        }

        private void RandomAssignmentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
             Messenger<bool>.Broadcast("ToggleRandomAssignment", RandomAssignmentCheckBox.Checked);
        }

        private void DefaultPlayerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Messenger<int>.Broadcast("DefaultPlayerSet", DefaultPlayerComboBox.SelectedIndex);
        }

        #region Key Profile Tab
        // KEYPROFILES!!!!---------
        #region Save/Load Key Profiles
        private void SaveKPPFileButton_Click(object sender, EventArgs e)
        {
            if (RecentKPPFiles.SelectedText.Length > 5)
                Messenger<string>.Broadcast("SaveKPPFile", RecentKPPFiles.SelectedText);
            else
                SaveKPPFileDialog.ShowDialog();
        }

        private void SaveAsKPPFileButton_Click(object sender, EventArgs e)
        {
            SaveKPPFileDialog.ShowDialog();
        }

        private void SaveKPPFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Messenger<string>.Broadcast("SaveKPPFile", SaveKPPFileDialog.FileName);
            RecentKPPFiles.Items.Add(SaveKPPFileDialog.FileName);
        }

        private void RecentKPPFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (File.Exists(RecentKPPFiles.SelectedText))
                Messenger<string>.Broadcast("LoadKPPFile", RecentKPPFiles.SelectedText);
        }

        private void LoadKPPFileButton_Click(object sender, EventArgs e)
        {
            LoadKPPFileDialog.ShowDialog();
        }

        private void LoadKPPFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Messenger<string>.Broadcast("LoadKPPFile", LoadKPPFileDialog.FileName);
            if (RecentKPPFiles.Items.Contains(LoadKPPFileDialog.FileName))
                RecentKPPFiles.SelectedIndex = RecentKPPFiles.Items.IndexOf(LoadKPPFileDialog.FileName);
            else
                RecentKPPFiles.SelectedIndex = RecentKPPFiles.Items.Add(LoadKPPFileDialog.FileName);
        }
        #endregion       

        #region Store UI Data
        private void KPDelay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown delay = (NumericUpDown)sender;
            Messenger<Key, int>.Broadcast("KeyPressDelayChanged", (Key)Convert.ToInt32(delay.Tag), (int)delay.Value);
        }

        private void SKRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton skRadio = (RadioButton)sender;
            string which = skRadio.Name.Substring(skRadio.Name.Length-3);
            if(skRadio.Checked && which == "SKC")
                Messenger<Key, bool>.Broadcast("KeyPressSameKeysChanged", (Key)Convert.ToInt32(skRadio.Tag), true);
            if (skRadio.Checked && which == "SKD")
                Messenger<Key, bool>.Broadcast("KeyPressSameKeysChanged", (Key)Convert.ToInt32(skRadio.Tag), false);
        }

        private void DKRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton dkRadio = (RadioButton)sender;
            string which = dkRadio.Name.Substring(dkRadio.Name.Length - 3);
            if (dkRadio.Checked && which == "DKC")
                Messenger<Key, bool>.Broadcast("KeyPressDifferentKeysChanged", (Key)Convert.ToInt32(dkRadio.Tag), true);
            if (dkRadio.Checked && which == "DKD")
                Messenger<Key, bool>.Broadcast("KeyPressDifferentKeysChanged", (Key)Convert.ToInt32(dkRadio.Tag), false);
        }

        private void ScalingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox scalingEnabled = (CheckBox)sender;
            Messenger<Key, bool>.Broadcast("KeyPressScalingChanged", (Key)Convert.ToInt32(scalingEnabled.Tag), scalingEnabled.Checked);
        }

        private void ScalingMin_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown scalingMin = (NumericUpDown)sender;
            Messenger<Key, int>.Broadcast("KeyPressScalingMinChanged", (Key)Convert.ToInt32(scalingMin.Tag), (int)scalingMin.Value);
        }

        private void ScalingMax_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown scalingMax = (NumericUpDown)sender;
            Messenger<Key, int>.Broadcast("KeyPressScalingMaxChanged", (Key)Convert.ToInt32(scalingMax.Tag), (int)scalingMax.Value);
        }
        #endregion

        #region Update UI
        private void SetKPPInfo(KeyPressInfo[] keys)
        {
            string[] prefix = new string[18]{"AUp", "ARight", "ADown", "ALeft", "DUp", "DRight", "DDown", "DLeft",
                                             "CUp", "CRight", "CDown", "CLeft", "RTrigger", "LTrigger", "ZTrigger",
                                             "Start", "A", "B"};

            for(int i=0; i<keys.Length; i++){
                // Delay
                NumericUpDown nud = (NumericUpDown)this.Controls.Find(prefix[i]+"Delay", true)[0];
                nud.Value = keys[i].Delay;

                // Same Keys
                RadioButton rb;
                if(keys[i].SameKeyAction)
                    rb = (RadioButton)this.Controls.Find(prefix[i] + "SKC", true)[0];
                else
                    rb = (RadioButton)this.Controls.Find(prefix[i] + "SKD", true)[0];
                rb.Checked = true;

                // Different Keys
                if (keys[i].DifferentKeyAction)
                    rb = (RadioButton)this.Controls.Find(prefix[i] + "DKC", true)[0];
                else
                    rb = (RadioButton)this.Controls.Find(prefix[i] + "DKD", true)[0];
                rb.Checked = true;

                // Scaling Enabled
                CheckBox cb = (CheckBox)this.Controls.Find(prefix[i] + "SDECheckBox", true)[0];
                cb.Checked = keys[i].Scaling;

                // Scaling Min
                nud = (NumericUpDown)this.Controls.Find(prefix[i] + "SDMin", true)[0];
                nud.Value = keys[i].Min;

                // Scaling Max
                nud = (NumericUpDown)this.Controls.Find(prefix[i] + "SDMax", true)[0];
                nud.Value = keys[i].Max;
            }
        }
        #endregion
        #endregion

    }        
}