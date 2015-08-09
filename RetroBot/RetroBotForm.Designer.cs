namespace RetroBot
{
    partial class RetroBotForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetroBotForm));
            this.RetroBotIRCWorker = new System.ComponentModel.BackgroundWorker();
            this.Player1ProcessorWorker = new System.ComponentModel.BackgroundWorker();
            this.Player2ProcessorWorker = new System.ComponentModel.BackgroundWorker();
            this.Player3ProcessorWorker = new System.ComponentModel.BackgroundWorker();
            this.Player4ProcessorWorker = new System.ComponentModel.BackgroundWorker();
            this.CurrentGame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CommandInfoWindow = new System.Windows.Forms.ListBox();
            this.Player4InputLabel = new System.Windows.Forms.Label();
            this.Player2InputLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Player3InputLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player1InputLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MaxComboSetter = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ControllerSettingsTab = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.DefaultPlayerComboBox = new System.Windows.Forms.ComboBox();
            this.RandomAssignmentCheckBox = new System.Windows.Forms.CheckBox();
            this.Player4GroupBox = new System.Windows.Forms.GroupBox();
            this.SavePlayer4GuestListButton = new System.Windows.Forms.Button();
            this.Player4PauseButton = new System.Windows.Forms.Button();
            this.Player4GuestList = new System.Windows.Forms.TextBox();
            this.Player4RBPanel = new System.Windows.Forms.Panel();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.Player3GroupBox = new System.Windows.Forms.GroupBox();
            this.SavePlayer3GuestListButton = new System.Windows.Forms.Button();
            this.Player3PauseButton = new System.Windows.Forms.Button();
            this.Player3GuestList = new System.Windows.Forms.TextBox();
            this.Player3RBPanel = new System.Windows.Forms.Panel();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.Player2GroupBox = new System.Windows.Forms.GroupBox();
            this.SavePlayer2GuestListButton = new System.Windows.Forms.Button();
            this.Player2PauseButton = new System.Windows.Forms.Button();
            this.Player2GuestList = new System.Windows.Forms.TextBox();
            this.Player2RBPanel = new System.Windows.Forms.Panel();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.PauseAllButton = new System.Windows.Forms.Button();
            this.Player1GroupBox = new System.Windows.Forms.GroupBox();
            this.SavePlayer1GuestListButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Player1PauseButton = new System.Windows.Forms.Button();
            this.Player1GuestList = new System.Windows.Forms.TextBox();
            this.Player1RBPanel = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.KeyControlsGroup = new System.Windows.Forms.GroupBox();
            this.KeyControlsSaveButton = new System.Windows.Forms.Button();
            this.KeyControlsLoadButton = new System.Windows.Forms.Button();
            this.KeyControlsPanel = new System.Windows.Forms.Panel();
            this.BEnabled = new System.Windows.Forms.CheckBox();
            this.AnalogLeftEnabled = new System.Windows.Forms.CheckBox();
            this.StartEnabled = new System.Windows.Forms.CheckBox();
            this.ZTriggerEnabled = new System.Windows.Forms.CheckBox();
            this.LTriggerEnabled = new System.Windows.Forms.CheckBox();
            this.RTriggerEnabled = new System.Windows.Forms.CheckBox();
            this.CLeftEnabled = new System.Windows.Forms.CheckBox();
            this.CDownEnabled = new System.Windows.Forms.CheckBox();
            this.CRightEnabled = new System.Windows.Forms.CheckBox();
            this.CUpEnabled = new System.Windows.Forms.CheckBox();
            this.AEnabled = new System.Windows.Forms.CheckBox();
            this.DPadLeftEnabled = new System.Windows.Forms.CheckBox();
            this.DPadDownEnabled = new System.Windows.Forms.CheckBox();
            this.DPadRightEnabled = new System.Windows.Forms.CheckBox();
            this.DPadUpEnabled = new System.Windows.Forms.CheckBox();
            this.AnalogDownEnabled = new System.Windows.Forms.CheckBox();
            this.AnalogRightEnabled = new System.Windows.Forms.CheckBox();
            this.AnalogUpEnabled = new System.Windows.Forms.CheckBox();
            this.AllControlsEnabled = new System.Windows.Forms.CheckBox();
            this.KeyControlTarget = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BSKPanel = new System.Windows.Forms.Panel();
            this.BSKD = new System.Windows.Forms.RadioButton();
            this.BSKC = new System.Windows.Forms.RadioButton();
            this.CLeftDKPanel = new System.Windows.Forms.Panel();
            this.CLeftDKD = new System.Windows.Forms.RadioButton();
            this.CLeftDKC = new System.Windows.Forms.RadioButton();
            this.CDownDKPanel = new System.Windows.Forms.Panel();
            this.CDownDKD = new System.Windows.Forms.RadioButton();
            this.CDownDKC = new System.Windows.Forms.RadioButton();
            this.CRightSKPanel = new System.Windows.Forms.Panel();
            this.CRightSKD = new System.Windows.Forms.RadioButton();
            this.CRightSKC = new System.Windows.Forms.RadioButton();
            this.DLeftDKPanel = new System.Windows.Forms.Panel();
            this.DLeftDKD = new System.Windows.Forms.RadioButton();
            this.DLeftDKC = new System.Windows.Forms.RadioButton();
            this.DDownDKPanel = new System.Windows.Forms.Panel();
            this.DDownDKD = new System.Windows.Forms.RadioButton();
            this.DDownDKC = new System.Windows.Forms.RadioButton();
            this.panel26 = new System.Windows.Forms.Panel();
            this.ALeftDKD = new System.Windows.Forms.RadioButton();
            this.ALeftDKC = new System.Windows.Forms.RadioButton();
            this.ADownDKPanel = new System.Windows.Forms.Panel();
            this.ADownDKD = new System.Windows.Forms.RadioButton();
            this.ADownDKC = new System.Windows.Forms.RadioButton();
            this.panel15 = new System.Windows.Forms.Panel();
            this.BDelay = new System.Windows.Forms.NumericUpDown();
            this.BDKPanel = new System.Windows.Forms.Panel();
            this.BDKD = new System.Windows.Forms.RadioButton();
            this.BDKC = new System.Windows.Forms.RadioButton();
            this.BSDMax = new System.Windows.Forms.NumericUpDown();
            this.BSDMin = new System.Windows.Forms.NumericUpDown();
            this.BSDECheckBox = new System.Windows.Forms.CheckBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.RTriggerDKPanel = new System.Windows.Forms.Panel();
            this.RTriggerDKD = new System.Windows.Forms.RadioButton();
            this.RTriggerDKC = new System.Windows.Forms.RadioButton();
            this.RTriggerDelay = new System.Windows.Forms.NumericUpDown();
            this.RTriggerSKPanel = new System.Windows.Forms.Panel();
            this.RTriggerSKD = new System.Windows.Forms.RadioButton();
            this.RTriggerSKC = new System.Windows.Forms.RadioButton();
            this.RTriggerSDMax = new System.Windows.Forms.NumericUpDown();
            this.RTriggerSDMin = new System.Windows.Forms.NumericUpDown();
            this.RTriggerSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.ADelay = new System.Windows.Forms.NumericUpDown();
            this.ADKPanel = new System.Windows.Forms.Panel();
            this.ADKD = new System.Windows.Forms.RadioButton();
            this.ADKC = new System.Windows.Forms.RadioButton();
            this.ASKPanel = new System.Windows.Forms.Panel();
            this.ASKD = new System.Windows.Forms.RadioButton();
            this.ASKC = new System.Windows.Forms.RadioButton();
            this.ASDMax = new System.Windows.Forms.NumericUpDown();
            this.ASDMin = new System.Windows.Forms.NumericUpDown();
            this.ASDECheckBox = new System.Windows.Forms.CheckBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.CLeftDelay = new System.Windows.Forms.NumericUpDown();
            this.CLeftSKPanel = new System.Windows.Forms.Panel();
            this.CLeftSKD = new System.Windows.Forms.RadioButton();
            this.CLeftSKC = new System.Windows.Forms.RadioButton();
            this.CLeftSDMax = new System.Windows.Forms.NumericUpDown();
            this.CLeftSDMin = new System.Windows.Forms.NumericUpDown();
            this.CLeftSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.StartDelay = new System.Windows.Forms.NumericUpDown();
            this.StartDKPanel = new System.Windows.Forms.Panel();
            this.StartDKD = new System.Windows.Forms.RadioButton();
            this.StartDKC = new System.Windows.Forms.RadioButton();
            this.StartSKPanel = new System.Windows.Forms.Panel();
            this.StartSKD = new System.Windows.Forms.RadioButton();
            this.StartSKC = new System.Windows.Forms.RadioButton();
            this.StartSDMax = new System.Windows.Forms.NumericUpDown();
            this.StartSDMin = new System.Windows.Forms.NumericUpDown();
            this.StartSDECheckBox = new System.Windows.Forms.CheckBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.CDownDelay = new System.Windows.Forms.NumericUpDown();
            this.CDownSKPanel = new System.Windows.Forms.Panel();
            this.CDownSKD = new System.Windows.Forms.RadioButton();
            this.CDownSKC = new System.Windows.Forms.RadioButton();
            this.CDownSDMax = new System.Windows.Forms.NumericUpDown();
            this.CDownSDMin = new System.Windows.Forms.NumericUpDown();
            this.CDownSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.ZTriggerDelay = new System.Windows.Forms.NumericUpDown();
            this.ZTriggerDKPanel = new System.Windows.Forms.Panel();
            this.ZTriggerDKD = new System.Windows.Forms.RadioButton();
            this.ZTriggerDKC = new System.Windows.Forms.RadioButton();
            this.ZTriggerSKPanel = new System.Windows.Forms.Panel();
            this.ZTriggerSKD = new System.Windows.Forms.RadioButton();
            this.ZTriggerSKC = new System.Windows.Forms.RadioButton();
            this.ZTriggerSDMax = new System.Windows.Forms.NumericUpDown();
            this.ZTriggerSDMin = new System.Windows.Forms.NumericUpDown();
            this.ZTriggerSDECheckBox = new System.Windows.Forms.CheckBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.CRightDelay = new System.Windows.Forms.NumericUpDown();
            this.CRightDKPanel = new System.Windows.Forms.Panel();
            this.CRightDKD = new System.Windows.Forms.RadioButton();
            this.CRightDKC = new System.Windows.Forms.RadioButton();
            this.CRightSDMax = new System.Windows.Forms.NumericUpDown();
            this.CRightSDMin = new System.Windows.Forms.NumericUpDown();
            this.CRightSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.LTriggerDelay = new System.Windows.Forms.NumericUpDown();
            this.LTriggerDKPanel = new System.Windows.Forms.Panel();
            this.LTriggerDKD = new System.Windows.Forms.RadioButton();
            this.LTriggerDKC = new System.Windows.Forms.RadioButton();
            this.LTriggerSKPanel = new System.Windows.Forms.Panel();
            this.LTriggerSKD = new System.Windows.Forms.RadioButton();
            this.LTriggerSKC = new System.Windows.Forms.RadioButton();
            this.LTriggerSDMax = new System.Windows.Forms.NumericUpDown();
            this.LTriggerSDMin = new System.Windows.Forms.NumericUpDown();
            this.LTriggerSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CUpDelay = new System.Windows.Forms.NumericUpDown();
            this.CUpDKPanel = new System.Windows.Forms.Panel();
            this.CUpDKD = new System.Windows.Forms.RadioButton();
            this.CUpDKC = new System.Windows.Forms.RadioButton();
            this.CUpSKPanel = new System.Windows.Forms.Panel();
            this.CUpSKD = new System.Windows.Forms.RadioButton();
            this.CUpSKC = new System.Windows.Forms.RadioButton();
            this.CUpSDMax = new System.Windows.Forms.NumericUpDown();
            this.CUpSDMin = new System.Windows.Forms.NumericUpDown();
            this.CUpSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.DLeftDelay = new System.Windows.Forms.NumericUpDown();
            this.DLeftSKPanel = new System.Windows.Forms.Panel();
            this.DLeftSKD = new System.Windows.Forms.RadioButton();
            this.DLeftSKC = new System.Windows.Forms.RadioButton();
            this.DLeftSDMax = new System.Windows.Forms.NumericUpDown();
            this.DLeftSDMin = new System.Windows.Forms.NumericUpDown();
            this.DLeftSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.DDownDelay = new System.Windows.Forms.NumericUpDown();
            this.DDownSKPanel = new System.Windows.Forms.Panel();
            this.DDownSKD = new System.Windows.Forms.RadioButton();
            this.DDownSKC = new System.Windows.Forms.RadioButton();
            this.DDownSDMax = new System.Windows.Forms.NumericUpDown();
            this.DDownSDMin = new System.Windows.Forms.NumericUpDown();
            this.DDownSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.DRightDelay = new System.Windows.Forms.NumericUpDown();
            this.DRightDKPanel = new System.Windows.Forms.Panel();
            this.DRightDKD = new System.Windows.Forms.RadioButton();
            this.DRightDKC = new System.Windows.Forms.RadioButton();
            this.DRightSKPanel = new System.Windows.Forms.Panel();
            this.DRightSKD = new System.Windows.Forms.RadioButton();
            this.DRightSKC = new System.Windows.Forms.RadioButton();
            this.DRightSDMax = new System.Windows.Forms.NumericUpDown();
            this.DRightSDMin = new System.Windows.Forms.NumericUpDown();
            this.DRightSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DUpDelay = new System.Windows.Forms.NumericUpDown();
            this.DUpDKPanel = new System.Windows.Forms.Panel();
            this.DUpDKD = new System.Windows.Forms.RadioButton();
            this.DupDKC = new System.Windows.Forms.RadioButton();
            this.DUpSKPanel = new System.Windows.Forms.Panel();
            this.DUpSKD = new System.Windows.Forms.RadioButton();
            this.DUpSKC = new System.Windows.Forms.RadioButton();
            this.DUpSDMax = new System.Windows.Forms.NumericUpDown();
            this.DUpSDMin = new System.Windows.Forms.NumericUpDown();
            this.DUpSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ALeftDelay = new System.Windows.Forms.NumericUpDown();
            this.ALeftDKPanel = new System.Windows.Forms.Panel();
            this.ALeftSKD = new System.Windows.Forms.RadioButton();
            this.ALeftSKC = new System.Windows.Forms.RadioButton();
            this.ALeftSDMax = new System.Windows.Forms.NumericUpDown();
            this.ALeftSDMin = new System.Windows.Forms.NumericUpDown();
            this.ALeftSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ADownDelay = new System.Windows.Forms.NumericUpDown();
            this.ADownSKPanel = new System.Windows.Forms.Panel();
            this.ADownSKD = new System.Windows.Forms.RadioButton();
            this.ADownSKC = new System.Windows.Forms.RadioButton();
            this.ADownSDMax = new System.Windows.Forms.NumericUpDown();
            this.ADownSDMin = new System.Windows.Forms.NumericUpDown();
            this.ADownSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ARightDelay = new System.Windows.Forms.NumericUpDown();
            this.ARightDKPanel = new System.Windows.Forms.Panel();
            this.ARightDKD = new System.Windows.Forms.RadioButton();
            this.ARightDKC = new System.Windows.Forms.RadioButton();
            this.ARightSKPanel = new System.Windows.Forms.Panel();
            this.ARightSKD = new System.Windows.Forms.RadioButton();
            this.ARightSKC = new System.Windows.Forms.RadioButton();
            this.ARightSDMax = new System.Windows.Forms.NumericUpDown();
            this.ARightSDMin = new System.Windows.Forms.NumericUpDown();
            this.ARightSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AUpDelay = new System.Windows.Forms.NumericUpDown();
            this.AUpDKPanel = new System.Windows.Forms.Panel();
            this.AUpDKD = new System.Windows.Forms.RadioButton();
            this.AUpDKC = new System.Windows.Forms.RadioButton();
            this.AUpSKPanel = new System.Windows.Forms.Panel();
            this.AUpSKD = new System.Windows.Forms.RadioButton();
            this.AUpSKC = new System.Windows.Forms.RadioButton();
            this.AUpSDMax = new System.Windows.Forms.NumericUpDown();
            this.AUpSDMin = new System.Windows.Forms.NumericUpDown();
            this.AUpSDECheckBox = new System.Windows.Forms.CheckBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.SaveKPPFileButton = new System.Windows.Forms.Button();
            this.SaveAsKPPFileButton = new System.Windows.Forms.Button();
            this.LoadKPPFileButton = new System.Windows.Forms.Button();
            this.RecentKPPFiles = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LoadKPPFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveKPPFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxComboSetter)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ControllerSettingsTab.SuspendLayout();
            this.Player4GroupBox.SuspendLayout();
            this.Player4RBPanel.SuspendLayout();
            this.Player3GroupBox.SuspendLayout();
            this.Player3RBPanel.SuspendLayout();
            this.Player2GroupBox.SuspendLayout();
            this.Player2RBPanel.SuspendLayout();
            this.Player1GroupBox.SuspendLayout();
            this.Player1RBPanel.SuspendLayout();
            this.KeyControlsGroup.SuspendLayout();
            this.KeyControlsPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.BSKPanel.SuspendLayout();
            this.CLeftDKPanel.SuspendLayout();
            this.CDownDKPanel.SuspendLayout();
            this.CRightSKPanel.SuspendLayout();
            this.DLeftDKPanel.SuspendLayout();
            this.DDownDKPanel.SuspendLayout();
            this.panel26.SuspendLayout();
            this.ADownDKPanel.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDelay)).BeginInit();
            this.BDKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDMin)).BeginInit();
            this.panel14.SuspendLayout();
            this.RTriggerDKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTriggerDelay)).BeginInit();
            this.RTriggerSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTriggerSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTriggerSDMin)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADelay)).BeginInit();
            this.ADKPanel.SuspendLayout();
            this.ASKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ASDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASDMin)).BeginInit();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLeftDelay)).BeginInit();
            this.CLeftSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLeftSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLeftSDMin)).BeginInit();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartDelay)).BeginInit();
            this.StartDKPanel.SuspendLayout();
            this.StartSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartSDMin)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDownDelay)).BeginInit();
            this.CDownSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDownSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDownSDMin)).BeginInit();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZTriggerDelay)).BeginInit();
            this.ZTriggerDKPanel.SuspendLayout();
            this.ZTriggerSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZTriggerSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTriggerSDMin)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CRightDelay)).BeginInit();
            this.CRightDKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CRightSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRightSDMin)).BeginInit();
            this.panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTriggerDelay)).BeginInit();
            this.LTriggerDKPanel.SuspendLayout();
            this.LTriggerSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTriggerSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTriggerSDMin)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUpDelay)).BeginInit();
            this.CUpDKPanel.SuspendLayout();
            this.CUpSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUpSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUpSDMin)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DLeftDelay)).BeginInit();
            this.DLeftSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DLeftSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DLeftSDMin)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DDownDelay)).BeginInit();
            this.DDownSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DDownSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDownSDMin)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DRightDelay)).BeginInit();
            this.DRightDKPanel.SuspendLayout();
            this.DRightSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DRightSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRightSDMin)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DUpDelay)).BeginInit();
            this.DUpDKPanel.SuspendLayout();
            this.DUpSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DUpSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUpSDMin)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALeftDelay)).BeginInit();
            this.ALeftDKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALeftSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALeftSDMin)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADownDelay)).BeginInit();
            this.ADownSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADownSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADownSDMin)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARightDelay)).BeginInit();
            this.ARightDKPanel.SuspendLayout();
            this.ARightSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARightSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARightSDMin)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDelay)).BeginInit();
            this.AUpDKPanel.SuspendLayout();
            this.AUpSKPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUpSDMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUpSDMin)).BeginInit();
            this.SuspendLayout();
            // 
            // RetroBotIRCWorker
            // 
            this.RetroBotIRCWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RetroBotIRCWorker_DoWork);
            // 
            // Player1ProcessorWorker
            // 
            this.Player1ProcessorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Player1ProcessorWorker_DoWork);
            // 
            // Player2ProcessorWorker
            // 
            this.Player2ProcessorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Player2ProcessorWorker_DoWork);
            // 
            // Player3ProcessorWorker
            // 
            this.Player3ProcessorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Player3ProcessorWorker_DoWork);
            // 
            // Player4ProcessorWorker
            // 
            this.Player4ProcessorWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Player4ProcessorWorker_DoWork);
            // 
            // CurrentGame
            // 
            this.CurrentGame.FormattingEnabled = true;
            this.CurrentGame.Items.AddRange(new object[] {
            "1080 Snowboarding (JU) (M2) - Project64 2.0",
            "Banjo-Kazooie (U) (V1.0) - Project64 2.0",
            "Conker\'s Bad Fur Day (U) - Project64 2.0",
            "GoldenEye 007 (U) - Project64 2.0",
            "Harvest Moon 64 (U) - Project64 2.0",
            "Mario Golf (U) - Project64 2.0",
            "Mario Kart 64 (U) - Project64 2.0",
            "Mario Party (U) - Project64 2.0",
            "Mario Party 2 (U) - Project64 2.0",
            "Mario Party 3 (U) - Project64 2.0",
            "Mortal Kombat 4 (U) - Project64 2.0",
            "Paper Mario (U) - Project64 2.0",
            "Perfect Dark (U) (V1.1) - Project64 2.0",
            "Pokemon Snap (U) - Project64 2.0",
            "Scooby-Doo - Classic Creep Capers (U) - Project64 2.0",
            "South Park (U) - Project64 2.0",
            "Super Smash Bros. (U) - Project64 2.0",
            "The Legend of Zelda - Ocarina of Time (U) (V1.0) - Project64 2.0",
            "Tony Hawk\'s Pro Skater (U) (V1.0) - Project64 2.0",
            "Wheel of Fortune (U) - Project64 2.0",
            "Worms - Armageddon (U) (M3) - Project64 2.0",
            "WWF WrestleMania 2000 (U) - Project64 2.0"});
            this.CurrentGame.Location = new System.Drawing.Point(92, 12);
            this.CurrentGame.Name = "CurrentGame";
            this.CurrentGame.Size = new System.Drawing.Size(465, 21);
            this.CurrentGame.Sorted = true;
            this.CurrentGame.TabIndex = 7;
            this.CurrentGame.SelectedIndexChanged += new System.EventHandler(this.CurrentGame_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Game";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.CommandInfoWindow);
            this.panel1.Controls.Add(this.Player4InputLabel);
            this.panel1.Controls.Add(this.Player2InputLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Player3InputLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Player1InputLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(711, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 439);
            this.panel1.TabIndex = 9;
            // 
            // CommandInfoWindow
            // 
            this.CommandInfoWindow.BackColor = System.Drawing.Color.Black;
            this.CommandInfoWindow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CommandInfoWindow.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CommandInfoWindow.FormattingEnabled = true;
            this.CommandInfoWindow.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.CommandInfoWindow.Location = new System.Drawing.Point(3, 195);
            this.CommandInfoWindow.Name = "CommandInfoWindow";
            this.CommandInfoWindow.Size = new System.Drawing.Size(197, 234);
            this.CommandInfoWindow.TabIndex = 12;
            this.CommandInfoWindow.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.CommandInfoWindow_DrawItem);
            // 
            // Player4InputLabel
            // 
            this.Player4InputLabel.BackColor = System.Drawing.Color.Black;
            this.Player4InputLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player4InputLabel.Location = new System.Drawing.Point(10, 155);
            this.Player4InputLabel.Name = "Player4InputLabel";
            this.Player4InputLabel.Size = new System.Drawing.Size(193, 23);
            this.Player4InputLabel.TabIndex = 11;
            this.Player4InputLabel.Text = "Disabled";
            // 
            // Player2InputLabel
            // 
            this.Player2InputLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player2InputLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2InputLabel.Location = new System.Drawing.Point(10, 70);
            this.Player2InputLabel.Name = "Player2InputLabel";
            this.Player2InputLabel.Size = new System.Drawing.Size(193, 23);
            this.Player2InputLabel.TabIndex = 9;
            this.Player2InputLabel.Text = "Disabled";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(147)))), ((int)(((byte)(48)))));
            this.label8.Location = new System.Drawing.Point(3, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "Player 4";
            // 
            // Player3InputLabel
            // 
            this.Player3InputLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player3InputLabel.Location = new System.Drawing.Point(10, 113);
            this.Player3InputLabel.Name = "Player3InputLabel";
            this.Player3InputLabel.Size = new System.Drawing.Size(193, 23);
            this.Player3InputLabel.TabIndex = 5;
            this.Player3InputLabel.Text = "Disabled";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(1)))));
            this.label6.Location = new System.Drawing.Point(3, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Player 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(67)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Player 2";
            // 
            // Player1InputLabel
            // 
            this.Player1InputLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1InputLabel.Location = new System.Drawing.Point(10, 27);
            this.Player1InputLabel.Name = "Player1InputLabel";
            this.Player1InputLabel.Size = new System.Drawing.Size(193, 23);
            this.Player1InputLabel.TabIndex = 1;
            this.Player1InputLabel.Text = "Disabled";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(32)))), ((int)(((byte)(21)))));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player 1";
            // 
            // MaxComboSetter
            // 
            this.MaxComboSetter.InterceptArrowKeys = false;
            this.MaxComboSetter.Location = new System.Drawing.Point(632, 12);
            this.MaxComboSetter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxComboSetter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxComboSetter.Name = "MaxComboSetter";
            this.MaxComboSetter.Size = new System.Drawing.Size(30, 20);
            this.MaxComboSetter.TabIndex = 11;
            this.MaxComboSetter.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaxComboSetter.ValueChanged += new System.EventHandler(this.MaxComboSetter_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(563, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Max Combo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ControllerSettingsTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 39);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 491);
            this.tabControl1.TabIndex = 13;
            // 
            // ControllerSettingsTab
            // 
            this.ControllerSettingsTab.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ControllerSettingsTab.Controls.Add(this.label5);
            this.ControllerSettingsTab.Controls.Add(this.DefaultPlayerComboBox);
            this.ControllerSettingsTab.Controls.Add(this.RandomAssignmentCheckBox);
            this.ControllerSettingsTab.Controls.Add(this.Player4GroupBox);
            this.ControllerSettingsTab.Controls.Add(this.Player3GroupBox);
            this.ControllerSettingsTab.Controls.Add(this.Player2GroupBox);
            this.ControllerSettingsTab.Controls.Add(this.PauseAllButton);
            this.ControllerSettingsTab.Controls.Add(this.Player1GroupBox);
            this.ControllerSettingsTab.Controls.Add(this.KeyControlsGroup);
            this.ControllerSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.ControllerSettingsTab.Name = "ControllerSettingsTab";
            this.ControllerSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControllerSettingsTab.Size = new System.Drawing.Size(684, 465);
            this.ControllerSettingsTab.TabIndex = 0;
            this.ControllerSettingsTab.Text = "Controller Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Defualt Player";
            // 
            // DefaultPlayerComboBox
            // 
            this.DefaultPlayerComboBox.FormattingEnabled = true;
            this.DefaultPlayerComboBox.Items.AddRange(new object[] {
            "Player 1",
            "Player 2",
            "Player 3",
            "Player 4"});
            this.DefaultPlayerComboBox.Location = new System.Drawing.Point(318, 433);
            this.DefaultPlayerComboBox.MaxDropDownItems = 4;
            this.DefaultPlayerComboBox.Name = "DefaultPlayerComboBox";
            this.DefaultPlayerComboBox.Size = new System.Drawing.Size(121, 21);
            this.DefaultPlayerComboBox.TabIndex = 23;
            this.DefaultPlayerComboBox.SelectedIndexChanged += new System.EventHandler(this.DefaultPlayerComboBox_SelectedIndexChanged);
            // 
            // RandomAssignmentCheckBox
            // 
            this.RandomAssignmentCheckBox.AutoSize = true;
            this.RandomAssignmentCheckBox.Location = new System.Drawing.Point(19, 435);
            this.RandomAssignmentCheckBox.Name = "RandomAssignmentCheckBox";
            this.RandomAssignmentCheckBox.Size = new System.Drawing.Size(155, 17);
            this.RandomAssignmentCheckBox.TabIndex = 22;
            this.RandomAssignmentCheckBox.Text = "Random Player Assignment";
            this.RandomAssignmentCheckBox.UseVisualStyleBackColor = true;
            this.RandomAssignmentCheckBox.CheckedChanged += new System.EventHandler(this.RandomAssignmentCheckBox_CheckedChanged);
            // 
            // Player4GroupBox
            // 
            this.Player4GroupBox.Controls.Add(this.SavePlayer4GuestListButton);
            this.Player4GroupBox.Controls.Add(this.Player4PauseButton);
            this.Player4GroupBox.Controls.Add(this.Player4GuestList);
            this.Player4GroupBox.Controls.Add(this.Player4RBPanel);
            this.Player4GroupBox.Location = new System.Drawing.Point(13, 343);
            this.Player4GroupBox.Name = "Player4GroupBox";
            this.Player4GroupBox.Size = new System.Drawing.Size(426, 83);
            this.Player4GroupBox.TabIndex = 21;
            this.Player4GroupBox.TabStop = false;
            this.Player4GroupBox.Text = "Player 4";
            // 
            // SavePlayer4GuestListButton
            // 
            this.SavePlayer4GuestListButton.Enabled = false;
            this.SavePlayer4GuestListButton.ForeColor = System.Drawing.Color.Black;
            this.SavePlayer4GuestListButton.Location = new System.Drawing.Point(293, 17);
            this.SavePlayer4GuestListButton.Name = "SavePlayer4GuestListButton";
            this.SavePlayer4GuestListButton.Size = new System.Drawing.Size(59, 23);
            this.SavePlayer4GuestListButton.TabIndex = 4;
            this.SavePlayer4GuestListButton.Text = "Save";
            this.SavePlayer4GuestListButton.UseVisualStyleBackColor = true;
            this.SavePlayer4GuestListButton.Click += new System.EventHandler(this.SavePlayer4GuestListButton_Click);
            // 
            // Player4PauseButton
            // 
            this.Player4PauseButton.ForeColor = System.Drawing.Color.Green;
            this.Player4PauseButton.Location = new System.Drawing.Point(358, 17);
            this.Player4PauseButton.Name = "Player4PauseButton";
            this.Player4PauseButton.Size = new System.Drawing.Size(59, 23);
            this.Player4PauseButton.TabIndex = 2;
            this.Player4PauseButton.Text = "START";
            this.Player4PauseButton.UseVisualStyleBackColor = true;
            this.Player4PauseButton.Click += new System.EventHandler(this.Player4PauseButton_Click);
            // 
            // Player4GuestList
            // 
            this.Player4GuestList.Enabled = false;
            this.Player4GuestList.Location = new System.Drawing.Point(7, 20);
            this.Player4GuestList.Name = "Player4GuestList";
            this.Player4GuestList.Size = new System.Drawing.Size(280, 20);
            this.Player4GuestList.TabIndex = 1;
            // 
            // Player4RBPanel
            // 
            this.Player4RBPanel.Controls.Add(this.radioButton16);
            this.Player4RBPanel.Controls.Add(this.radioButton17);
            this.Player4RBPanel.Controls.Add(this.radioButton18);
            this.Player4RBPanel.Controls.Add(this.radioButton19);
            this.Player4RBPanel.Controls.Add(this.radioButton20);
            this.Player4RBPanel.Location = new System.Drawing.Point(7, 53);
            this.Player4RBPanel.Name = "Player4RBPanel";
            this.Player4RBPanel.Size = new System.Drawing.Size(419, 24);
            this.Player4RBPanel.TabIndex = 0;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(351, 3);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(69, 17);
            this.radioButton16.TabIndex = 4;
            this.radioButton16.Text = "Followers";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.radioButton16_CheckedChanged);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(255, 3);
            this.radioButton17.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(85, 17);
            this.radioButton17.TabIndex = 3;
            this.radioButton17.Text = "Top Donator";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.radioButton17_CheckedChanged);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(176, 3);
            this.radioButton18.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(68, 17);
            this.radioButton18.TabIndex = 2;
            this.radioButton18.Text = "Donators";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.radioButton18_CheckedChanged);
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(85, 3);
            this.radioButton19.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(80, 17);
            this.radioButton19.TabIndex = 1;
            this.radioButton19.Text = "Subscribers";
            this.radioButton19.UseVisualStyleBackColor = true;
            this.radioButton19.CheckedChanged += new System.EventHandler(this.radioButton19_CheckedChanged);
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Checked = true;
            this.radioButton20.Location = new System.Drawing.Point(5, 3);
            this.radioButton20.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(62, 17);
            this.radioButton20.TabIndex = 0;
            this.radioButton20.TabStop = true;
            this.radioButton20.Text = "Viewers";
            this.radioButton20.UseVisualStyleBackColor = true;
            this.radioButton20.CheckedChanged += new System.EventHandler(this.radioButton20_CheckedChanged);
            // 
            // Player3GroupBox
            // 
            this.Player3GroupBox.Controls.Add(this.SavePlayer3GuestListButton);
            this.Player3GroupBox.Controls.Add(this.Player3PauseButton);
            this.Player3GroupBox.Controls.Add(this.Player3GuestList);
            this.Player3GroupBox.Controls.Add(this.Player3RBPanel);
            this.Player3GroupBox.Location = new System.Drawing.Point(13, 237);
            this.Player3GroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.Player3GroupBox.Name = "Player3GroupBox";
            this.Player3GroupBox.Size = new System.Drawing.Size(426, 83);
            this.Player3GroupBox.TabIndex = 20;
            this.Player3GroupBox.TabStop = false;
            this.Player3GroupBox.Text = "Player 3";
            // 
            // SavePlayer3GuestListButton
            // 
            this.SavePlayer3GuestListButton.Enabled = false;
            this.SavePlayer3GuestListButton.ForeColor = System.Drawing.Color.Black;
            this.SavePlayer3GuestListButton.Location = new System.Drawing.Point(293, 17);
            this.SavePlayer3GuestListButton.Name = "SavePlayer3GuestListButton";
            this.SavePlayer3GuestListButton.Size = new System.Drawing.Size(59, 23);
            this.SavePlayer3GuestListButton.TabIndex = 4;
            this.SavePlayer3GuestListButton.Text = "Save";
            this.SavePlayer3GuestListButton.UseVisualStyleBackColor = true;
            this.SavePlayer3GuestListButton.Click += new System.EventHandler(this.SavePlayer3GuestListButton_Click);
            // 
            // Player3PauseButton
            // 
            this.Player3PauseButton.ForeColor = System.Drawing.Color.Green;
            this.Player3PauseButton.Location = new System.Drawing.Point(358, 17);
            this.Player3PauseButton.Name = "Player3PauseButton";
            this.Player3PauseButton.Size = new System.Drawing.Size(59, 23);
            this.Player3PauseButton.TabIndex = 2;
            this.Player3PauseButton.Text = "START";
            this.Player3PauseButton.UseVisualStyleBackColor = true;
            this.Player3PauseButton.Click += new System.EventHandler(this.Player3PauseButton_Click);
            // 
            // Player3GuestList
            // 
            this.Player3GuestList.Enabled = false;
            this.Player3GuestList.Location = new System.Drawing.Point(7, 20);
            this.Player3GuestList.Name = "Player3GuestList";
            this.Player3GuestList.Size = new System.Drawing.Size(280, 20);
            this.Player3GuestList.TabIndex = 1;
            // 
            // Player3RBPanel
            // 
            this.Player3RBPanel.Controls.Add(this.radioButton11);
            this.Player3RBPanel.Controls.Add(this.radioButton12);
            this.Player3RBPanel.Controls.Add(this.radioButton13);
            this.Player3RBPanel.Controls.Add(this.radioButton14);
            this.Player3RBPanel.Controls.Add(this.radioButton15);
            this.Player3RBPanel.Location = new System.Drawing.Point(7, 53);
            this.Player3RBPanel.Name = "Player3RBPanel";
            this.Player3RBPanel.Size = new System.Drawing.Size(419, 24);
            this.Player3RBPanel.TabIndex = 0;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(351, 3);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(69, 17);
            this.radioButton11.TabIndex = 4;
            this.radioButton11.Text = "Followers";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton11_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(255, 3);
            this.radioButton12.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(85, 17);
            this.radioButton12.TabIndex = 3;
            this.radioButton12.Text = "Top Donator";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(176, 3);
            this.radioButton13.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(68, 17);
            this.radioButton13.TabIndex = 2;
            this.radioButton13.Text = "Donators";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton13_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(85, 3);
            this.radioButton14.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(80, 17);
            this.radioButton14.TabIndex = 1;
            this.radioButton14.Text = "Subscribers";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton14_CheckedChanged);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Checked = true;
            this.radioButton15.Location = new System.Drawing.Point(5, 3);
            this.radioButton15.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(62, 17);
            this.radioButton15.TabIndex = 0;
            this.radioButton15.TabStop = true;
            this.radioButton15.Text = "Viewers";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.radioButton15_CheckedChanged);
            // 
            // Player2GroupBox
            // 
            this.Player2GroupBox.Controls.Add(this.SavePlayer2GuestListButton);
            this.Player2GroupBox.Controls.Add(this.Player2PauseButton);
            this.Player2GroupBox.Controls.Add(this.Player2GuestList);
            this.Player2GroupBox.Controls.Add(this.Player2RBPanel);
            this.Player2GroupBox.Location = new System.Drawing.Point(13, 129);
            this.Player2GroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 22);
            this.Player2GroupBox.Name = "Player2GroupBox";
            this.Player2GroupBox.Size = new System.Drawing.Size(426, 83);
            this.Player2GroupBox.TabIndex = 19;
            this.Player2GroupBox.TabStop = false;
            this.Player2GroupBox.Text = "Player 2";
            // 
            // SavePlayer2GuestListButton
            // 
            this.SavePlayer2GuestListButton.Enabled = false;
            this.SavePlayer2GuestListButton.ForeColor = System.Drawing.Color.Black;
            this.SavePlayer2GuestListButton.Location = new System.Drawing.Point(293, 17);
            this.SavePlayer2GuestListButton.Name = "SavePlayer2GuestListButton";
            this.SavePlayer2GuestListButton.Size = new System.Drawing.Size(59, 23);
            this.SavePlayer2GuestListButton.TabIndex = 4;
            this.SavePlayer2GuestListButton.Text = "Save";
            this.SavePlayer2GuestListButton.UseVisualStyleBackColor = true;
            this.SavePlayer2GuestListButton.Click += new System.EventHandler(this.SavePlayer2GuestListButton_Click);
            // 
            // Player2PauseButton
            // 
            this.Player2PauseButton.ForeColor = System.Drawing.Color.Green;
            this.Player2PauseButton.Location = new System.Drawing.Point(358, 17);
            this.Player2PauseButton.Name = "Player2PauseButton";
            this.Player2PauseButton.Size = new System.Drawing.Size(59, 23);
            this.Player2PauseButton.TabIndex = 2;
            this.Player2PauseButton.Text = "START";
            this.Player2PauseButton.UseVisualStyleBackColor = true;
            this.Player2PauseButton.Click += new System.EventHandler(this.Player2PauseButton_Click);
            // 
            // Player2GuestList
            // 
            this.Player2GuestList.Enabled = false;
            this.Player2GuestList.Location = new System.Drawing.Point(7, 20);
            this.Player2GuestList.Name = "Player2GuestList";
            this.Player2GuestList.Size = new System.Drawing.Size(280, 20);
            this.Player2GuestList.TabIndex = 1;
            // 
            // Player2RBPanel
            // 
            this.Player2RBPanel.Controls.Add(this.radioButton6);
            this.Player2RBPanel.Controls.Add(this.radioButton7);
            this.Player2RBPanel.Controls.Add(this.radioButton8);
            this.Player2RBPanel.Controls.Add(this.radioButton9);
            this.Player2RBPanel.Controls.Add(this.radioButton10);
            this.Player2RBPanel.Location = new System.Drawing.Point(7, 53);
            this.Player2RBPanel.Name = "Player2RBPanel";
            this.Player2RBPanel.Size = new System.Drawing.Size(419, 24);
            this.Player2RBPanel.TabIndex = 0;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(351, 3);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(69, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "Followers";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(255, 3);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(85, 17);
            this.radioButton7.TabIndex = 3;
            this.radioButton7.Text = "Top Donator";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(176, 3);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(68, 17);
            this.radioButton8.TabIndex = 2;
            this.radioButton8.Text = "Donators";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(85, 3);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(80, 17);
            this.radioButton9.TabIndex = 1;
            this.radioButton9.Text = "Subscribers";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(5, 3);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(62, 17);
            this.radioButton10.TabIndex = 0;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Viewers";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // PauseAllButton
            // 
            this.PauseAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseAllButton.ForeColor = System.Drawing.Color.Green;
            this.PauseAllButton.Location = new System.Drawing.Point(462, 411);
            this.PauseAllButton.Name = "PauseAllButton";
            this.PauseAllButton.Size = new System.Drawing.Size(208, 46);
            this.PauseAllButton.TabIndex = 16;
            this.PauseAllButton.Text = "START";
            this.PauseAllButton.UseVisualStyleBackColor = true;
            this.PauseAllButton.Click += new System.EventHandler(this.PauseAllButton_Click);
            // 
            // Player1GroupBox
            // 
            this.Player1GroupBox.Controls.Add(this.SavePlayer1GuestListButton);
            this.Player1GroupBox.Controls.Add(this.button2);
            this.Player1GroupBox.Controls.Add(this.button3);
            this.Player1GroupBox.Controls.Add(this.button4);
            this.Player1GroupBox.Controls.Add(this.Player1PauseButton);
            this.Player1GroupBox.Controls.Add(this.Player1GuestList);
            this.Player1GroupBox.Controls.Add(this.Player1RBPanel);
            this.Player1GroupBox.Location = new System.Drawing.Point(13, 21);
            this.Player1GroupBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 22);
            this.Player1GroupBox.Name = "Player1GroupBox";
            this.Player1GroupBox.Size = new System.Drawing.Size(426, 83);
            this.Player1GroupBox.TabIndex = 18;
            this.Player1GroupBox.TabStop = false;
            this.Player1GroupBox.Text = "Player 1";
            // 
            // SavePlayer1GuestListButton
            // 
            this.SavePlayer1GuestListButton.Enabled = false;
            this.SavePlayer1GuestListButton.ForeColor = System.Drawing.Color.Black;
            this.SavePlayer1GuestListButton.Location = new System.Drawing.Point(293, 17);
            this.SavePlayer1GuestListButton.Name = "SavePlayer1GuestListButton";
            this.SavePlayer1GuestListButton.Size = new System.Drawing.Size(59, 23);
            this.SavePlayer1GuestListButton.TabIndex = 3;
            this.SavePlayer1GuestListButton.Text = "Save";
            this.SavePlayer1GuestListButton.UseVisualStyleBackColor = true;
            this.SavePlayer1GuestListButton.Click += new System.EventHandler(this.SavePlayer1GuestListButton_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(293, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(293, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "START";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.Green;
            this.button4.Location = new System.Drawing.Point(293, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "START";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Player1PauseButton
            // 
            this.Player1PauseButton.ForeColor = System.Drawing.Color.Green;
            this.Player1PauseButton.Location = new System.Drawing.Point(358, 17);
            this.Player1PauseButton.Name = "Player1PauseButton";
            this.Player1PauseButton.Size = new System.Drawing.Size(59, 23);
            this.Player1PauseButton.TabIndex = 2;
            this.Player1PauseButton.Text = "START";
            this.Player1PauseButton.UseVisualStyleBackColor = true;
            this.Player1PauseButton.Click += new System.EventHandler(this.Player1PauseButton_Click);
            // 
            // Player1GuestList
            // 
            this.Player1GuestList.Enabled = false;
            this.Player1GuestList.Location = new System.Drawing.Point(7, 20);
            this.Player1GuestList.Name = "Player1GuestList";
            this.Player1GuestList.Size = new System.Drawing.Size(280, 20);
            this.Player1GuestList.TabIndex = 1;
            // 
            // Player1RBPanel
            // 
            this.Player1RBPanel.Controls.Add(this.radioButton5);
            this.Player1RBPanel.Controls.Add(this.radioButton4);
            this.Player1RBPanel.Controls.Add(this.radioButton3);
            this.Player1RBPanel.Controls.Add(this.radioButton2);
            this.Player1RBPanel.Controls.Add(this.radioButton1);
            this.Player1RBPanel.Location = new System.Drawing.Point(7, 53);
            this.Player1RBPanel.Name = "Player1RBPanel";
            this.Player1RBPanel.Size = new System.Drawing.Size(419, 24);
            this.Player1RBPanel.TabIndex = 0;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(351, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(69, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Followers";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(255, 3);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Top Donator";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(176, 3);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(68, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Donators";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(85, 3);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Subscribers";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(5, 3);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Viewers";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // KeyControlsGroup
            // 
            this.KeyControlsGroup.Controls.Add(this.KeyControlsSaveButton);
            this.KeyControlsGroup.Controls.Add(this.KeyControlsLoadButton);
            this.KeyControlsGroup.Controls.Add(this.KeyControlsPanel);
            this.KeyControlsGroup.Controls.Add(this.AllControlsEnabled);
            this.KeyControlsGroup.Controls.Add(this.KeyControlTarget);
            this.KeyControlsGroup.Location = new System.Drawing.Point(462, 21);
            this.KeyControlsGroup.Name = "KeyControlsGroup";
            this.KeyControlsGroup.Size = new System.Drawing.Size(208, 384);
            this.KeyControlsGroup.TabIndex = 17;
            this.KeyControlsGroup.TabStop = false;
            this.KeyControlsGroup.Text = "Key Controls Enabled";
            // 
            // KeyControlsSaveButton
            // 
            this.KeyControlsSaveButton.Location = new System.Drawing.Point(127, 354);
            this.KeyControlsSaveButton.Name = "KeyControlsSaveButton";
            this.KeyControlsSaveButton.Size = new System.Drawing.Size(75, 23);
            this.KeyControlsSaveButton.TabIndex = 23;
            this.KeyControlsSaveButton.Text = "Save As...";
            this.KeyControlsSaveButton.UseVisualStyleBackColor = true;
            // 
            // KeyControlsLoadButton
            // 
            this.KeyControlsLoadButton.Location = new System.Drawing.Point(7, 354);
            this.KeyControlsLoadButton.Name = "KeyControlsLoadButton";
            this.KeyControlsLoadButton.Size = new System.Drawing.Size(75, 23);
            this.KeyControlsLoadButton.TabIndex = 22;
            this.KeyControlsLoadButton.Text = "Load";
            this.KeyControlsLoadButton.UseVisualStyleBackColor = true;
            // 
            // KeyControlsPanel
            // 
            this.KeyControlsPanel.Controls.Add(this.BEnabled);
            this.KeyControlsPanel.Controls.Add(this.AnalogLeftEnabled);
            this.KeyControlsPanel.Controls.Add(this.StartEnabled);
            this.KeyControlsPanel.Controls.Add(this.ZTriggerEnabled);
            this.KeyControlsPanel.Controls.Add(this.LTriggerEnabled);
            this.KeyControlsPanel.Controls.Add(this.RTriggerEnabled);
            this.KeyControlsPanel.Controls.Add(this.CLeftEnabled);
            this.KeyControlsPanel.Controls.Add(this.CDownEnabled);
            this.KeyControlsPanel.Controls.Add(this.CRightEnabled);
            this.KeyControlsPanel.Controls.Add(this.CUpEnabled);
            this.KeyControlsPanel.Controls.Add(this.AEnabled);
            this.KeyControlsPanel.Controls.Add(this.DPadLeftEnabled);
            this.KeyControlsPanel.Controls.Add(this.DPadDownEnabled);
            this.KeyControlsPanel.Controls.Add(this.DPadRightEnabled);
            this.KeyControlsPanel.Controls.Add(this.DPadUpEnabled);
            this.KeyControlsPanel.Controls.Add(this.AnalogDownEnabled);
            this.KeyControlsPanel.Controls.Add(this.AnalogRightEnabled);
            this.KeyControlsPanel.Controls.Add(this.AnalogUpEnabled);
            this.KeyControlsPanel.Location = new System.Drawing.Point(7, 70);
            this.KeyControlsPanel.Name = "KeyControlsPanel";
            this.KeyControlsPanel.Size = new System.Drawing.Size(195, 277);
            this.KeyControlsPanel.TabIndex = 21;
            // 
            // BEnabled
            // 
            this.BEnabled.AutoSize = true;
            this.BEnabled.Checked = true;
            this.BEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BEnabled.Location = new System.Drawing.Point(110, 250);
            this.BEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BEnabled.Name = "BEnabled";
            this.BEnabled.Size = new System.Drawing.Size(67, 17);
            this.BEnabled.TabIndex = 56;
            this.BEnabled.Text = "B Button";
            this.BEnabled.UseVisualStyleBackColor = true;
            this.BEnabled.CheckedChanged += new System.EventHandler(this.BEnabled_CheckedChanged);
            // 
            // AnalogLeftEnabled
            // 
            this.AnalogLeftEnabled.AutoSize = true;
            this.AnalogLeftEnabled.Checked = true;
            this.AnalogLeftEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalogLeftEnabled.Location = new System.Drawing.Point(9, 100);
            this.AnalogLeftEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AnalogLeftEnabled.Name = "AnalogLeftEnabled";
            this.AnalogLeftEnabled.Size = new System.Drawing.Size(80, 17);
            this.AnalogLeftEnabled.TabIndex = 46;
            this.AnalogLeftEnabled.Text = "Analog Left";
            this.AnalogLeftEnabled.UseVisualStyleBackColor = true;
            this.AnalogLeftEnabled.CheckedChanged += new System.EventHandler(this.AnalogLeftEnabled_CheckedChanged);
            // 
            // StartEnabled
            // 
            this.StartEnabled.AutoSize = true;
            this.StartEnabled.Checked = true;
            this.StartEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartEnabled.Location = new System.Drawing.Point(110, 220);
            this.StartEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.StartEnabled.Name = "StartEnabled";
            this.StartEnabled.Size = new System.Drawing.Size(82, 17);
            this.StartEnabled.TabIndex = 55;
            this.StartEnabled.Text = "Start Button";
            this.StartEnabled.UseVisualStyleBackColor = true;
            this.StartEnabled.CheckedChanged += new System.EventHandler(this.StartEnabled_CheckedChanged);
            // 
            // ZTriggerEnabled
            // 
            this.ZTriggerEnabled.AutoSize = true;
            this.ZTriggerEnabled.Checked = true;
            this.ZTriggerEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ZTriggerEnabled.Location = new System.Drawing.Point(110, 190);
            this.ZTriggerEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ZTriggerEnabled.Name = "ZTriggerEnabled";
            this.ZTriggerEnabled.Size = new System.Drawing.Size(69, 17);
            this.ZTriggerEnabled.TabIndex = 54;
            this.ZTriggerEnabled.Text = "Z Trigger";
            this.ZTriggerEnabled.UseVisualStyleBackColor = true;
            this.ZTriggerEnabled.CheckedChanged += new System.EventHandler(this.ZTriggerEnabled_CheckedChanged);
            // 
            // LTriggerEnabled
            // 
            this.LTriggerEnabled.AutoSize = true;
            this.LTriggerEnabled.Checked = true;
            this.LTriggerEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LTriggerEnabled.Location = new System.Drawing.Point(110, 160);
            this.LTriggerEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LTriggerEnabled.Name = "LTriggerEnabled";
            this.LTriggerEnabled.Size = new System.Drawing.Size(68, 17);
            this.LTriggerEnabled.TabIndex = 53;
            this.LTriggerEnabled.Text = "L Trigger";
            this.LTriggerEnabled.UseVisualStyleBackColor = true;
            this.LTriggerEnabled.CheckedChanged += new System.EventHandler(this.LTriggerEnabled_CheckedChanged);
            // 
            // RTriggerEnabled
            // 
            this.RTriggerEnabled.AutoSize = true;
            this.RTriggerEnabled.Checked = true;
            this.RTriggerEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RTriggerEnabled.Location = new System.Drawing.Point(110, 130);
            this.RTriggerEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.RTriggerEnabled.Name = "RTriggerEnabled";
            this.RTriggerEnabled.Size = new System.Drawing.Size(70, 17);
            this.RTriggerEnabled.TabIndex = 52;
            this.RTriggerEnabled.Text = "R Trigger";
            this.RTriggerEnabled.UseVisualStyleBackColor = true;
            this.RTriggerEnabled.CheckedChanged += new System.EventHandler(this.RTriggerEnabled_CheckedChanged);
            // 
            // CLeftEnabled
            // 
            this.CLeftEnabled.AutoSize = true;
            this.CLeftEnabled.Checked = true;
            this.CLeftEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CLeftEnabled.Location = new System.Drawing.Point(110, 100);
            this.CLeftEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CLeftEnabled.Name = "CLeftEnabled";
            this.CLeftEnabled.Size = new System.Drawing.Size(54, 17);
            this.CLeftEnabled.TabIndex = 51;
            this.CLeftEnabled.Text = "C Left";
            this.CLeftEnabled.UseVisualStyleBackColor = true;
            this.CLeftEnabled.CheckedChanged += new System.EventHandler(this.CLeftEnabled_CheckedChanged);
            // 
            // CDownEnabled
            // 
            this.CDownEnabled.AutoSize = true;
            this.CDownEnabled.Checked = true;
            this.CDownEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CDownEnabled.Location = new System.Drawing.Point(110, 70);
            this.CDownEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CDownEnabled.Name = "CDownEnabled";
            this.CDownEnabled.Size = new System.Drawing.Size(64, 17);
            this.CDownEnabled.TabIndex = 50;
            this.CDownEnabled.Text = "C Down";
            this.CDownEnabled.UseVisualStyleBackColor = true;
            this.CDownEnabled.CheckedChanged += new System.EventHandler(this.CDownEnabled_CheckedChanged);
            // 
            // CRightEnabled
            // 
            this.CRightEnabled.AutoSize = true;
            this.CRightEnabled.Checked = true;
            this.CRightEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CRightEnabled.Location = new System.Drawing.Point(110, 40);
            this.CRightEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CRightEnabled.Name = "CRightEnabled";
            this.CRightEnabled.Size = new System.Drawing.Size(61, 17);
            this.CRightEnabled.TabIndex = 49;
            this.CRightEnabled.Text = "C Right";
            this.CRightEnabled.UseVisualStyleBackColor = true;
            this.CRightEnabled.CheckedChanged += new System.EventHandler(this.CRightEnabled_CheckedChanged);
            // 
            // CUpEnabled
            // 
            this.CUpEnabled.AutoSize = true;
            this.CUpEnabled.Checked = true;
            this.CUpEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CUpEnabled.Location = new System.Drawing.Point(110, 10);
            this.CUpEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.CUpEnabled.Name = "CUpEnabled";
            this.CUpEnabled.Size = new System.Drawing.Size(50, 17);
            this.CUpEnabled.TabIndex = 48;
            this.CUpEnabled.Text = "C Up";
            this.CUpEnabled.UseVisualStyleBackColor = true;
            this.CUpEnabled.CheckedChanged += new System.EventHandler(this.CUpEnabled_CheckedChanged);
            // 
            // AEnabled
            // 
            this.AEnabled.AutoSize = true;
            this.AEnabled.Checked = true;
            this.AEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AEnabled.Location = new System.Drawing.Point(9, 250);
            this.AEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AEnabled.Name = "AEnabled";
            this.AEnabled.Size = new System.Drawing.Size(67, 17);
            this.AEnabled.TabIndex = 47;
            this.AEnabled.Text = "A Button";
            this.AEnabled.UseVisualStyleBackColor = true;
            this.AEnabled.CheckedChanged += new System.EventHandler(this.AEnabled_CheckedChanged);
            // 
            // DPadLeftEnabled
            // 
            this.DPadLeftEnabled.AutoSize = true;
            this.DPadLeftEnabled.Checked = true;
            this.DPadLeftEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPadLeftEnabled.Location = new System.Drawing.Point(9, 220);
            this.DPadLeftEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DPadLeftEnabled.Name = "DPadLeftEnabled";
            this.DPadLeftEnabled.Size = new System.Drawing.Size(77, 17);
            this.DPadLeftEnabled.TabIndex = 45;
            this.DPadLeftEnabled.Text = "D Pad Left";
            this.DPadLeftEnabled.UseVisualStyleBackColor = true;
            this.DPadLeftEnabled.CheckedChanged += new System.EventHandler(this.DPadLeftEnabled_CheckedChanged);
            // 
            // DPadDownEnabled
            // 
            this.DPadDownEnabled.AutoSize = true;
            this.DPadDownEnabled.Checked = true;
            this.DPadDownEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPadDownEnabled.Location = new System.Drawing.Point(9, 190);
            this.DPadDownEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DPadDownEnabled.Name = "DPadDownEnabled";
            this.DPadDownEnabled.Size = new System.Drawing.Size(87, 17);
            this.DPadDownEnabled.TabIndex = 44;
            this.DPadDownEnabled.Text = "D Pad Down";
            this.DPadDownEnabled.UseVisualStyleBackColor = true;
            this.DPadDownEnabled.CheckedChanged += new System.EventHandler(this.DPadDownEnabled_CheckedChanged);
            // 
            // DPadRightEnabled
            // 
            this.DPadRightEnabled.AutoSize = true;
            this.DPadRightEnabled.Checked = true;
            this.DPadRightEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPadRightEnabled.Location = new System.Drawing.Point(9, 160);
            this.DPadRightEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DPadRightEnabled.Name = "DPadRightEnabled";
            this.DPadRightEnabled.Size = new System.Drawing.Size(84, 17);
            this.DPadRightEnabled.TabIndex = 43;
            this.DPadRightEnabled.Text = "D Pad Right";
            this.DPadRightEnabled.UseVisualStyleBackColor = true;
            this.DPadRightEnabled.CheckedChanged += new System.EventHandler(this.DPadRightEnabled_CheckedChanged);
            // 
            // DPadUpEnabled
            // 
            this.DPadUpEnabled.AutoSize = true;
            this.DPadUpEnabled.Checked = true;
            this.DPadUpEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DPadUpEnabled.Location = new System.Drawing.Point(9, 130);
            this.DPadUpEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.DPadUpEnabled.Name = "DPadUpEnabled";
            this.DPadUpEnabled.Size = new System.Drawing.Size(73, 17);
            this.DPadUpEnabled.TabIndex = 42;
            this.DPadUpEnabled.Text = "D Pad Up";
            this.DPadUpEnabled.UseVisualStyleBackColor = true;
            this.DPadUpEnabled.CheckedChanged += new System.EventHandler(this.DPadUpEnabled_CheckedChanged);
            // 
            // AnalogDownEnabled
            // 
            this.AnalogDownEnabled.AutoSize = true;
            this.AnalogDownEnabled.Checked = true;
            this.AnalogDownEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalogDownEnabled.Location = new System.Drawing.Point(9, 70);
            this.AnalogDownEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AnalogDownEnabled.Name = "AnalogDownEnabled";
            this.AnalogDownEnabled.Size = new System.Drawing.Size(90, 17);
            this.AnalogDownEnabled.TabIndex = 41;
            this.AnalogDownEnabled.Text = "Analog Down";
            this.AnalogDownEnabled.UseVisualStyleBackColor = true;
            this.AnalogDownEnabled.CheckedChanged += new System.EventHandler(this.AnalogDownEnabled_CheckedChanged);
            // 
            // AnalogRightEnabled
            // 
            this.AnalogRightEnabled.AutoSize = true;
            this.AnalogRightEnabled.Checked = true;
            this.AnalogRightEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalogRightEnabled.Location = new System.Drawing.Point(9, 40);
            this.AnalogRightEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AnalogRightEnabled.Name = "AnalogRightEnabled";
            this.AnalogRightEnabled.Size = new System.Drawing.Size(87, 17);
            this.AnalogRightEnabled.TabIndex = 40;
            this.AnalogRightEnabled.Text = "Analog Right";
            this.AnalogRightEnabled.UseVisualStyleBackColor = true;
            this.AnalogRightEnabled.CheckedChanged += new System.EventHandler(this.AnalogRightEnabled_CheckedChanged);
            // 
            // AnalogUpEnabled
            // 
            this.AnalogUpEnabled.AutoSize = true;
            this.AnalogUpEnabled.Checked = true;
            this.AnalogUpEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalogUpEnabled.Location = new System.Drawing.Point(9, 10);
            this.AnalogUpEnabled.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AnalogUpEnabled.Name = "AnalogUpEnabled";
            this.AnalogUpEnabled.Size = new System.Drawing.Size(76, 17);
            this.AnalogUpEnabled.TabIndex = 39;
            this.AnalogUpEnabled.Text = "Analog Up";
            this.AnalogUpEnabled.UseVisualStyleBackColor = true;
            this.AnalogUpEnabled.CheckedChanged += new System.EventHandler(this.AnalogUpEnabled_CheckedChanged);
            // 
            // AllControlsEnabled
            // 
            this.AllControlsEnabled.AutoSize = true;
            this.AllControlsEnabled.Checked = true;
            this.AllControlsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllControlsEnabled.Location = new System.Drawing.Point(7, 47);
            this.AllControlsEnabled.Name = "AllControlsEnabled";
            this.AllControlsEnabled.Size = new System.Drawing.Size(78, 17);
            this.AllControlsEnabled.TabIndex = 20;
            this.AllControlsEnabled.Text = "All Controls";
            this.AllControlsEnabled.UseVisualStyleBackColor = true;
            this.AllControlsEnabled.CheckedChanged += new System.EventHandler(this.AllControlsEnabled_CheckedChanged);
            // 
            // KeyControlTarget
            // 
            this.KeyControlTarget.FormattingEnabled = true;
            this.KeyControlTarget.Items.AddRange(new object[] {
            "All Players",
            "Player 1",
            "Player 2",
            "Player 3",
            "Player 4"});
            this.KeyControlTarget.Location = new System.Drawing.Point(7, 20);
            this.KeyControlTarget.MaxDropDownItems = 5;
            this.KeyControlTarget.Name = "KeyControlTarget";
            this.KeyControlTarget.Size = new System.Drawing.Size(187, 21);
            this.KeyControlTarget.TabIndex = 0;
            this.KeyControlTarget.TabStop = false;
            this.KeyControlTarget.SelectedIndexChanged += new System.EventHandler(this.KeyControlTarget_SelectionChangeCommited);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.BSKPanel);
            this.tabPage2.Controls.Add(this.CLeftDKPanel);
            this.tabPage2.Controls.Add(this.CDownDKPanel);
            this.tabPage2.Controls.Add(this.CRightSKPanel);
            this.tabPage2.Controls.Add(this.DLeftDKPanel);
            this.tabPage2.Controls.Add(this.DDownDKPanel);
            this.tabPage2.Controls.Add(this.panel26);
            this.tabPage2.Controls.Add(this.ADownDKPanel);
            this.tabPage2.Controls.Add(this.panel15);
            this.tabPage2.Controls.Add(this.panel14);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.panel16);
            this.tabPage2.Controls.Add(this.panel13);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.panel17);
            this.tabPage2.Controls.Add(this.panel12);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.panel18);
            this.tabPage2.Controls.Add(this.panel11);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.panel19);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.panel10);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.label26);
            this.tabPage2.Controls.Add(this.SaveKPPFileButton);
            this.tabPage2.Controls.Add(this.SaveAsKPPFileButton);
            this.tabPage2.Controls.Add(this.LoadKPPFileButton);
            this.tabPage2.Controls.Add(this.RecentKPPFiles);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(684, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Key Press Settings";
            // 
            // BSKPanel
            // 
            this.BSKPanel.Controls.Add(this.BSKD);
            this.BSKPanel.Controls.Add(this.BSKC);
            this.BSKPanel.Location = new System.Drawing.Point(194, 540);
            this.BSKPanel.Name = "BSKPanel";
            this.BSKPanel.Size = new System.Drawing.Size(102, 25);
            this.BSKPanel.TabIndex = 9;
            // 
            // BSKD
            // 
            this.BSKD.AutoSize = true;
            this.BSKD.Checked = true;
            this.BSKD.Location = new System.Drawing.Point(75, 4);
            this.BSKD.Name = "BSKD";
            this.BSKD.Size = new System.Drawing.Size(14, 13);
            this.BSKD.TabIndex = 1;
            this.BSKD.TabStop = true;
            this.BSKD.Tag = "17";
            this.BSKD.UseVisualStyleBackColor = true;
            this.BSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // BSKC
            // 
            this.BSKC.AutoSize = true;
            this.BSKC.Location = new System.Drawing.Point(14, 4);
            this.BSKC.Name = "BSKC";
            this.BSKC.Size = new System.Drawing.Size(14, 13);
            this.BSKC.TabIndex = 0;
            this.BSKC.Tag = "17";
            this.BSKC.UseVisualStyleBackColor = true;
            this.BSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CLeftDKPanel
            // 
            this.CLeftDKPanel.Controls.Add(this.CLeftDKD);
            this.CLeftDKPanel.Controls.Add(this.CLeftDKC);
            this.CLeftDKPanel.Location = new System.Drawing.Point(337, 372);
            this.CLeftDKPanel.Name = "CLeftDKPanel";
            this.CLeftDKPanel.Size = new System.Drawing.Size(102, 25);
            this.CLeftDKPanel.TabIndex = 9;
            // 
            // CLeftDKD
            // 
            this.CLeftDKD.AutoSize = true;
            this.CLeftDKD.Location = new System.Drawing.Point(75, 4);
            this.CLeftDKD.Name = "CLeftDKD";
            this.CLeftDKD.Size = new System.Drawing.Size(14, 13);
            this.CLeftDKD.TabIndex = 1;
            this.CLeftDKD.Tag = "11";
            this.CLeftDKD.UseVisualStyleBackColor = true;
            this.CLeftDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CLeftDKC
            // 
            this.CLeftDKC.AutoSize = true;
            this.CLeftDKC.Checked = true;
            this.CLeftDKC.Location = new System.Drawing.Point(14, 4);
            this.CLeftDKC.Name = "CLeftDKC";
            this.CLeftDKC.Size = new System.Drawing.Size(14, 13);
            this.CLeftDKC.TabIndex = 0;
            this.CLeftDKC.TabStop = true;
            this.CLeftDKC.Tag = "11";
            this.CLeftDKC.UseVisualStyleBackColor = true;
            this.CLeftDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CDownDKPanel
            // 
            this.CDownDKPanel.Controls.Add(this.CDownDKD);
            this.CDownDKPanel.Controls.Add(this.CDownDKC);
            this.CDownDKPanel.Location = new System.Drawing.Point(337, 344);
            this.CDownDKPanel.Name = "CDownDKPanel";
            this.CDownDKPanel.Size = new System.Drawing.Size(102, 25);
            this.CDownDKPanel.TabIndex = 9;
            // 
            // CDownDKD
            // 
            this.CDownDKD.AutoSize = true;
            this.CDownDKD.Location = new System.Drawing.Point(75, 4);
            this.CDownDKD.Name = "CDownDKD";
            this.CDownDKD.Size = new System.Drawing.Size(14, 13);
            this.CDownDKD.TabIndex = 1;
            this.CDownDKD.Tag = "10";
            this.CDownDKD.UseVisualStyleBackColor = true;
            this.CDownDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CDownDKC
            // 
            this.CDownDKC.AutoSize = true;
            this.CDownDKC.Checked = true;
            this.CDownDKC.Location = new System.Drawing.Point(14, 4);
            this.CDownDKC.Name = "CDownDKC";
            this.CDownDKC.Size = new System.Drawing.Size(14, 13);
            this.CDownDKC.TabIndex = 0;
            this.CDownDKC.TabStop = true;
            this.CDownDKC.Tag = "10";
            this.CDownDKC.UseVisualStyleBackColor = true;
            this.CDownDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CRightSKPanel
            // 
            this.CRightSKPanel.Controls.Add(this.CRightSKD);
            this.CRightSKPanel.Controls.Add(this.CRightSKC);
            this.CRightSKPanel.Location = new System.Drawing.Point(194, 316);
            this.CRightSKPanel.Name = "CRightSKPanel";
            this.CRightSKPanel.Size = new System.Drawing.Size(102, 25);
            this.CRightSKPanel.TabIndex = 9;
            // 
            // CRightSKD
            // 
            this.CRightSKD.AutoSize = true;
            this.CRightSKD.Checked = true;
            this.CRightSKD.Location = new System.Drawing.Point(75, 4);
            this.CRightSKD.Name = "CRightSKD";
            this.CRightSKD.Size = new System.Drawing.Size(14, 13);
            this.CRightSKD.TabIndex = 1;
            this.CRightSKD.TabStop = true;
            this.CRightSKD.Tag = "9";
            this.CRightSKD.UseVisualStyleBackColor = true;
            this.CRightSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CRightSKC
            // 
            this.CRightSKC.AutoSize = true;
            this.CRightSKC.Location = new System.Drawing.Point(14, 4);
            this.CRightSKC.Name = "CRightSKC";
            this.CRightSKC.Size = new System.Drawing.Size(14, 13);
            this.CRightSKC.TabIndex = 0;
            this.CRightSKC.Tag = "9";
            this.CRightSKC.UseVisualStyleBackColor = true;
            this.CRightSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DLeftDKPanel
            // 
            this.DLeftDKPanel.Controls.Add(this.DLeftDKD);
            this.DLeftDKPanel.Controls.Add(this.DLeftDKC);
            this.DLeftDKPanel.Location = new System.Drawing.Point(337, 260);
            this.DLeftDKPanel.Name = "DLeftDKPanel";
            this.DLeftDKPanel.Size = new System.Drawing.Size(102, 25);
            this.DLeftDKPanel.TabIndex = 9;
            // 
            // DLeftDKD
            // 
            this.DLeftDKD.AutoSize = true;
            this.DLeftDKD.Location = new System.Drawing.Point(75, 4);
            this.DLeftDKD.Name = "DLeftDKD";
            this.DLeftDKD.Size = new System.Drawing.Size(14, 13);
            this.DLeftDKD.TabIndex = 1;
            this.DLeftDKD.Tag = "7";
            this.DLeftDKD.UseVisualStyleBackColor = true;
            this.DLeftDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DLeftDKC
            // 
            this.DLeftDKC.AutoSize = true;
            this.DLeftDKC.Checked = true;
            this.DLeftDKC.Location = new System.Drawing.Point(14, 4);
            this.DLeftDKC.Name = "DLeftDKC";
            this.DLeftDKC.Size = new System.Drawing.Size(14, 13);
            this.DLeftDKC.TabIndex = 0;
            this.DLeftDKC.TabStop = true;
            this.DLeftDKC.Tag = "7";
            this.DLeftDKC.UseVisualStyleBackColor = true;
            this.DLeftDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DDownDKPanel
            // 
            this.DDownDKPanel.Controls.Add(this.DDownDKD);
            this.DDownDKPanel.Controls.Add(this.DDownDKC);
            this.DDownDKPanel.Location = new System.Drawing.Point(337, 232);
            this.DDownDKPanel.Name = "DDownDKPanel";
            this.DDownDKPanel.Size = new System.Drawing.Size(102, 25);
            this.DDownDKPanel.TabIndex = 9;
            // 
            // DDownDKD
            // 
            this.DDownDKD.AutoSize = true;
            this.DDownDKD.Location = new System.Drawing.Point(75, 4);
            this.DDownDKD.Name = "DDownDKD";
            this.DDownDKD.Size = new System.Drawing.Size(14, 13);
            this.DDownDKD.TabIndex = 1;
            this.DDownDKD.Tag = "6";
            this.DDownDKD.UseVisualStyleBackColor = true;
            this.DDownDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DDownDKC
            // 
            this.DDownDKC.AutoSize = true;
            this.DDownDKC.Checked = true;
            this.DDownDKC.Location = new System.Drawing.Point(14, 4);
            this.DDownDKC.Name = "DDownDKC";
            this.DDownDKC.Size = new System.Drawing.Size(14, 13);
            this.DDownDKC.TabIndex = 0;
            this.DDownDKC.TabStop = true;
            this.DDownDKC.Tag = "6";
            this.DDownDKC.UseVisualStyleBackColor = true;
            this.DDownDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.ALeftDKD);
            this.panel26.Controls.Add(this.ALeftDKC);
            this.panel26.Location = new System.Drawing.Point(337, 148);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(102, 25);
            this.panel26.TabIndex = 9;
            // 
            // ALeftDKD
            // 
            this.ALeftDKD.AutoSize = true;
            this.ALeftDKD.Location = new System.Drawing.Point(75, 4);
            this.ALeftDKD.Name = "ALeftDKD";
            this.ALeftDKD.Size = new System.Drawing.Size(14, 13);
            this.ALeftDKD.TabIndex = 1;
            this.ALeftDKD.Tag = "3";
            this.ALeftDKD.UseVisualStyleBackColor = true;
            this.ALeftDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ALeftDKC
            // 
            this.ALeftDKC.AutoSize = true;
            this.ALeftDKC.Checked = true;
            this.ALeftDKC.Location = new System.Drawing.Point(14, 4);
            this.ALeftDKC.Name = "ALeftDKC";
            this.ALeftDKC.Size = new System.Drawing.Size(14, 13);
            this.ALeftDKC.TabIndex = 0;
            this.ALeftDKC.TabStop = true;
            this.ALeftDKC.Tag = "3";
            this.ALeftDKC.UseVisualStyleBackColor = true;
            this.ALeftDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ADownDKPanel
            // 
            this.ADownDKPanel.Controls.Add(this.ADownDKD);
            this.ADownDKPanel.Controls.Add(this.ADownDKC);
            this.ADownDKPanel.Location = new System.Drawing.Point(337, 120);
            this.ADownDKPanel.Name = "ADownDKPanel";
            this.ADownDKPanel.Size = new System.Drawing.Size(102, 25);
            this.ADownDKPanel.TabIndex = 9;
            // 
            // ADownDKD
            // 
            this.ADownDKD.AutoSize = true;
            this.ADownDKD.Location = new System.Drawing.Point(75, 4);
            this.ADownDKD.Name = "ADownDKD";
            this.ADownDKD.Size = new System.Drawing.Size(14, 13);
            this.ADownDKD.TabIndex = 1;
            this.ADownDKD.Tag = "2";
            this.ADownDKD.UseVisualStyleBackColor = true;
            this.ADownDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ADownDKC
            // 
            this.ADownDKC.AutoSize = true;
            this.ADownDKC.Checked = true;
            this.ADownDKC.Location = new System.Drawing.Point(14, 4);
            this.ADownDKC.Name = "ADownDKC";
            this.ADownDKC.Size = new System.Drawing.Size(14, 13);
            this.ADownDKC.TabIndex = 0;
            this.ADownDKC.TabStop = true;
            this.ADownDKC.Tag = "2";
            this.ADownDKC.UseVisualStyleBackColor = true;
            this.ADownDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.BDelay);
            this.panel15.Controls.Add(this.BDKPanel);
            this.panel15.Controls.Add(this.BSDMax);
            this.panel15.Controls.Add(this.BSDMin);
            this.panel15.Controls.Add(this.BSDECheckBox);
            this.panel15.Location = new System.Drawing.Point(90, 540);
            this.panel15.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(556, 25);
            this.panel15.TabIndex = 41;
            // 
            // BDelay
            // 
            this.BDelay.Location = new System.Drawing.Point(22, 2);
            this.BDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.BDelay.Name = "BDelay";
            this.BDelay.Size = new System.Drawing.Size(46, 20);
            this.BDelay.TabIndex = 12;
            this.BDelay.Tag = "17";
            this.BDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.BDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // BDKPanel
            // 
            this.BDKPanel.Controls.Add(this.BDKD);
            this.BDKPanel.Controls.Add(this.BDKC);
            this.BDKPanel.Location = new System.Drawing.Point(247, 0);
            this.BDKPanel.Name = "BDKPanel";
            this.BDKPanel.Size = new System.Drawing.Size(102, 25);
            this.BDKPanel.TabIndex = 9;
            // 
            // BDKD
            // 
            this.BDKD.AutoSize = true;
            this.BDKD.Location = new System.Drawing.Point(75, 4);
            this.BDKD.Name = "BDKD";
            this.BDKD.Size = new System.Drawing.Size(14, 13);
            this.BDKD.TabIndex = 1;
            this.BDKD.Tag = "17";
            this.BDKD.UseVisualStyleBackColor = true;
            this.BDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // BDKC
            // 
            this.BDKC.AutoSize = true;
            this.BDKC.Checked = true;
            this.BDKC.Location = new System.Drawing.Point(14, 4);
            this.BDKC.Name = "BDKC";
            this.BDKC.Size = new System.Drawing.Size(14, 13);
            this.BDKC.TabIndex = 0;
            this.BDKC.TabStop = true;
            this.BDKC.Tag = "17";
            this.BDKC.UseVisualStyleBackColor = true;
            this.BDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // BSDMax
            // 
            this.BSDMax.Location = new System.Drawing.Point(503, 2);
            this.BSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.BSDMax.Name = "BSDMax";
            this.BSDMax.Size = new System.Drawing.Size(45, 20);
            this.BSDMax.TabIndex = 7;
            this.BSDMax.Tag = "17";
            this.BSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // BSDMin
            // 
            this.BSDMin.Location = new System.Drawing.Point(451, 2);
            this.BSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.BSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.BSDMin.Name = "BSDMin";
            this.BSDMin.Size = new System.Drawing.Size(46, 20);
            this.BSDMin.TabIndex = 6;
            this.BSDMin.Tag = "17";
            this.BSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.BSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // BSDECheckBox
            // 
            this.BSDECheckBox.AutoSize = true;
            this.BSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.BSDECheckBox.Name = "BSDECheckBox";
            this.BSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.BSDECheckBox.TabIndex = 4;
            this.BSDECheckBox.Tag = "17";
            this.BSDECheckBox.UseVisualStyleBackColor = true;
            this.BSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.RTriggerDKPanel);
            this.panel14.Controls.Add(this.RTriggerDelay);
            this.panel14.Controls.Add(this.RTriggerSKPanel);
            this.panel14.Controls.Add(this.RTriggerSDMax);
            this.panel14.Controls.Add(this.RTriggerSDMin);
            this.panel14.Controls.Add(this.RTriggerSDECheckBox);
            this.panel14.Location = new System.Drawing.Point(90, 400);
            this.panel14.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(556, 25);
            this.panel14.TabIndex = 35;
            // 
            // RTriggerDKPanel
            // 
            this.RTriggerDKPanel.Controls.Add(this.RTriggerDKD);
            this.RTriggerDKPanel.Controls.Add(this.RTriggerDKC);
            this.RTriggerDKPanel.Location = new System.Drawing.Point(247, 0);
            this.RTriggerDKPanel.Name = "RTriggerDKPanel";
            this.RTriggerDKPanel.Size = new System.Drawing.Size(102, 25);
            this.RTriggerDKPanel.TabIndex = 9;
            // 
            // RTriggerDKD
            // 
            this.RTriggerDKD.AutoSize = true;
            this.RTriggerDKD.Location = new System.Drawing.Point(75, 4);
            this.RTriggerDKD.Name = "RTriggerDKD";
            this.RTriggerDKD.Size = new System.Drawing.Size(14, 13);
            this.RTriggerDKD.TabIndex = 1;
            this.RTriggerDKD.Tag = "12";
            this.RTriggerDKD.UseVisualStyleBackColor = true;
            this.RTriggerDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // RTriggerDKC
            // 
            this.RTriggerDKC.AutoSize = true;
            this.RTriggerDKC.Checked = true;
            this.RTriggerDKC.Location = new System.Drawing.Point(14, 4);
            this.RTriggerDKC.Name = "RTriggerDKC";
            this.RTriggerDKC.Size = new System.Drawing.Size(14, 13);
            this.RTriggerDKC.TabIndex = 0;
            this.RTriggerDKC.TabStop = true;
            this.RTriggerDKC.Tag = "12";
            this.RTriggerDKC.UseVisualStyleBackColor = true;
            this.RTriggerDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // RTriggerDelay
            // 
            this.RTriggerDelay.Location = new System.Drawing.Point(22, 2);
            this.RTriggerDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RTriggerDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RTriggerDelay.Name = "RTriggerDelay";
            this.RTriggerDelay.Size = new System.Drawing.Size(46, 20);
            this.RTriggerDelay.TabIndex = 11;
            this.RTriggerDelay.Tag = "12";
            this.RTriggerDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RTriggerDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // RTriggerSKPanel
            // 
            this.RTriggerSKPanel.Controls.Add(this.RTriggerSKD);
            this.RTriggerSKPanel.Controls.Add(this.RTriggerSKC);
            this.RTriggerSKPanel.Location = new System.Drawing.Point(104, 0);
            this.RTriggerSKPanel.Name = "RTriggerSKPanel";
            this.RTriggerSKPanel.Size = new System.Drawing.Size(102, 25);
            this.RTriggerSKPanel.TabIndex = 9;
            // 
            // RTriggerSKD
            // 
            this.RTriggerSKD.AutoSize = true;
            this.RTriggerSKD.Checked = true;
            this.RTriggerSKD.Location = new System.Drawing.Point(75, 4);
            this.RTriggerSKD.Name = "RTriggerSKD";
            this.RTriggerSKD.Size = new System.Drawing.Size(14, 13);
            this.RTriggerSKD.TabIndex = 1;
            this.RTriggerSKD.TabStop = true;
            this.RTriggerSKD.Tag = "12";
            this.RTriggerSKD.UseVisualStyleBackColor = true;
            this.RTriggerSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // RTriggerSKC
            // 
            this.RTriggerSKC.AutoSize = true;
            this.RTriggerSKC.Location = new System.Drawing.Point(14, 4);
            this.RTriggerSKC.Name = "RTriggerSKC";
            this.RTriggerSKC.Size = new System.Drawing.Size(14, 13);
            this.RTriggerSKC.TabIndex = 0;
            this.RTriggerSKC.Tag = "12";
            this.RTriggerSKC.UseVisualStyleBackColor = true;
            this.RTriggerSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // RTriggerSDMax
            // 
            this.RTriggerSDMax.Location = new System.Drawing.Point(503, 2);
            this.RTriggerSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RTriggerSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RTriggerSDMax.Name = "RTriggerSDMax";
            this.RTriggerSDMax.Size = new System.Drawing.Size(45, 20);
            this.RTriggerSDMax.TabIndex = 7;
            this.RTriggerSDMax.Tag = "12";
            this.RTriggerSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RTriggerSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // RTriggerSDMin
            // 
            this.RTriggerSDMin.Location = new System.Drawing.Point(451, 2);
            this.RTriggerSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RTriggerSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RTriggerSDMin.Name = "RTriggerSDMin";
            this.RTriggerSDMin.Size = new System.Drawing.Size(46, 20);
            this.RTriggerSDMin.TabIndex = 6;
            this.RTriggerSDMin.Tag = "12";
            this.RTriggerSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.RTriggerSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // RTriggerSDECheckBox
            // 
            this.RTriggerSDECheckBox.AutoSize = true;
            this.RTriggerSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.RTriggerSDECheckBox.Name = "RTriggerSDECheckBox";
            this.RTriggerSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.RTriggerSDECheckBox.TabIndex = 4;
            this.RTriggerSDECheckBox.Tag = "12";
            this.RTriggerSDECheckBox.UseVisualStyleBackColor = true;
            this.RTriggerSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(68, 542);
            this.label21.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(14, 13);
            this.label21.TabIndex = 36;
            this.label21.Text = "B";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 402);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "R Trigger";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.ADelay);
            this.panel16.Controls.Add(this.ADKPanel);
            this.panel16.Controls.Add(this.ASKPanel);
            this.panel16.Controls.Add(this.ASDMax);
            this.panel16.Controls.Add(this.ASDMin);
            this.panel16.Controls.Add(this.ASDECheckBox);
            this.panel16.Location = new System.Drawing.Point(90, 512);
            this.panel16.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(556, 25);
            this.panel16.TabIndex = 42;
            // 
            // ADelay
            // 
            this.ADelay.Location = new System.Drawing.Point(22, 2);
            this.ADelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ADelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADelay.Name = "ADelay";
            this.ADelay.Size = new System.Drawing.Size(46, 20);
            this.ADelay.TabIndex = 11;
            this.ADelay.Tag = "16";
            this.ADelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // ADKPanel
            // 
            this.ADKPanel.Controls.Add(this.ADKD);
            this.ADKPanel.Controls.Add(this.ADKC);
            this.ADKPanel.Location = new System.Drawing.Point(247, 0);
            this.ADKPanel.Name = "ADKPanel";
            this.ADKPanel.Size = new System.Drawing.Size(102, 25);
            this.ADKPanel.TabIndex = 9;
            // 
            // ADKD
            // 
            this.ADKD.AutoSize = true;
            this.ADKD.Location = new System.Drawing.Point(75, 4);
            this.ADKD.Name = "ADKD";
            this.ADKD.Size = new System.Drawing.Size(14, 13);
            this.ADKD.TabIndex = 1;
            this.ADKD.Tag = "16";
            this.ADKD.UseVisualStyleBackColor = true;
            this.ADKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ADKC
            // 
            this.ADKC.AutoSize = true;
            this.ADKC.Checked = true;
            this.ADKC.Location = new System.Drawing.Point(14, 4);
            this.ADKC.Name = "ADKC";
            this.ADKC.Size = new System.Drawing.Size(14, 13);
            this.ADKC.TabIndex = 0;
            this.ADKC.TabStop = true;
            this.ADKC.Tag = "16";
            this.ADKC.UseVisualStyleBackColor = true;
            this.ADKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ASKPanel
            // 
            this.ASKPanel.Controls.Add(this.ASKD);
            this.ASKPanel.Controls.Add(this.ASKC);
            this.ASKPanel.Location = new System.Drawing.Point(104, 0);
            this.ASKPanel.Name = "ASKPanel";
            this.ASKPanel.Size = new System.Drawing.Size(102, 25);
            this.ASKPanel.TabIndex = 9;
            // 
            // ASKD
            // 
            this.ASKD.AutoSize = true;
            this.ASKD.Checked = true;
            this.ASKD.Location = new System.Drawing.Point(75, 4);
            this.ASKD.Name = "ASKD";
            this.ASKD.Size = new System.Drawing.Size(14, 13);
            this.ASKD.TabIndex = 1;
            this.ASKD.TabStop = true;
            this.ASKD.Tag = "16";
            this.ASKD.UseVisualStyleBackColor = true;
            this.ASKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ASKC
            // 
            this.ASKC.AutoSize = true;
            this.ASKC.Location = new System.Drawing.Point(14, 4);
            this.ASKC.Name = "ASKC";
            this.ASKC.Size = new System.Drawing.Size(14, 13);
            this.ASKC.TabIndex = 0;
            this.ASKC.Tag = "16";
            this.ASKC.UseVisualStyleBackColor = true;
            this.ASKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ASDMax
            // 
            this.ASDMax.Location = new System.Drawing.Point(503, 2);
            this.ASDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ASDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ASDMax.Name = "ASDMax";
            this.ASDMax.Size = new System.Drawing.Size(45, 20);
            this.ASDMax.TabIndex = 7;
            this.ASDMax.Tag = "16";
            this.ASDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ASDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // ASDMin
            // 
            this.ASDMin.Location = new System.Drawing.Point(451, 2);
            this.ASDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ASDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ASDMin.Name = "ASDMin";
            this.ASDMin.Size = new System.Drawing.Size(46, 20);
            this.ASDMin.TabIndex = 6;
            this.ASDMin.Tag = "16";
            this.ASDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ASDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // ASDECheckBox
            // 
            this.ASDECheckBox.AutoSize = true;
            this.ASDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.ASDECheckBox.Name = "ASDECheckBox";
            this.ASDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.ASDECheckBox.TabIndex = 4;
            this.ASDECheckBox.Tag = "16";
            this.ASDECheckBox.UseVisualStyleBackColor = true;
            this.ASDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.CLeftDelay);
            this.panel13.Controls.Add(this.CLeftSKPanel);
            this.panel13.Controls.Add(this.CLeftSDMax);
            this.panel13.Controls.Add(this.CLeftSDMin);
            this.panel13.Controls.Add(this.CLeftSDECheckBox);
            this.panel13.Location = new System.Drawing.Point(90, 372);
            this.panel13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(556, 25);
            this.panel13.TabIndex = 35;
            // 
            // CLeftDelay
            // 
            this.CLeftDelay.Location = new System.Drawing.Point(22, 2);
            this.CLeftDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CLeftDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CLeftDelay.Name = "CLeftDelay";
            this.CLeftDelay.Size = new System.Drawing.Size(46, 20);
            this.CLeftDelay.TabIndex = 11;
            this.CLeftDelay.Tag = "11";
            this.CLeftDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CLeftDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // CLeftSKPanel
            // 
            this.CLeftSKPanel.Controls.Add(this.CLeftSKD);
            this.CLeftSKPanel.Controls.Add(this.CLeftSKC);
            this.CLeftSKPanel.Location = new System.Drawing.Point(104, 0);
            this.CLeftSKPanel.Name = "CLeftSKPanel";
            this.CLeftSKPanel.Size = new System.Drawing.Size(102, 25);
            this.CLeftSKPanel.TabIndex = 9;
            // 
            // CLeftSKD
            // 
            this.CLeftSKD.AutoSize = true;
            this.CLeftSKD.Checked = true;
            this.CLeftSKD.Location = new System.Drawing.Point(75, 4);
            this.CLeftSKD.Name = "CLeftSKD";
            this.CLeftSKD.Size = new System.Drawing.Size(14, 13);
            this.CLeftSKD.TabIndex = 1;
            this.CLeftSKD.TabStop = true;
            this.CLeftSKD.Tag = "11";
            this.CLeftSKD.UseVisualStyleBackColor = true;
            this.CLeftSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CLeftSKC
            // 
            this.CLeftSKC.AutoSize = true;
            this.CLeftSKC.Location = new System.Drawing.Point(14, 4);
            this.CLeftSKC.Name = "CLeftSKC";
            this.CLeftSKC.Size = new System.Drawing.Size(14, 13);
            this.CLeftSKC.TabIndex = 0;
            this.CLeftSKC.Tag = "11";
            this.CLeftSKC.UseVisualStyleBackColor = true;
            this.CLeftSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CLeftSDMax
            // 
            this.CLeftSDMax.Location = new System.Drawing.Point(503, 2);
            this.CLeftSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CLeftSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CLeftSDMax.Name = "CLeftSDMax";
            this.CLeftSDMax.Size = new System.Drawing.Size(45, 20);
            this.CLeftSDMax.TabIndex = 7;
            this.CLeftSDMax.Tag = "11";
            this.CLeftSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CLeftSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // CLeftSDMin
            // 
            this.CLeftSDMin.Location = new System.Drawing.Point(451, 2);
            this.CLeftSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CLeftSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CLeftSDMin.Name = "CLeftSDMin";
            this.CLeftSDMin.Size = new System.Drawing.Size(46, 20);
            this.CLeftSDMin.TabIndex = 6;
            this.CLeftSDMin.Tag = "11";
            this.CLeftSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CLeftSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // CLeftSDECheckBox
            // 
            this.CLeftSDECheckBox.AutoSize = true;
            this.CLeftSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.CLeftSDECheckBox.Name = "CLeftSDECheckBox";
            this.CLeftSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.CLeftSDECheckBox.TabIndex = 4;
            this.CLeftSDECheckBox.Tag = "11";
            this.CLeftSDECheckBox.UseVisualStyleBackColor = true;
            this.CLeftSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(68, 514);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(14, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "A";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(47, 374);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "C Left";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.StartDelay);
            this.panel17.Controls.Add(this.StartDKPanel);
            this.panel17.Controls.Add(this.StartSKPanel);
            this.panel17.Controls.Add(this.StartSDMax);
            this.panel17.Controls.Add(this.StartSDMin);
            this.panel17.Controls.Add(this.StartSDECheckBox);
            this.panel17.Location = new System.Drawing.Point(90, 484);
            this.panel17.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(556, 25);
            this.panel17.TabIndex = 43;
            // 
            // StartDelay
            // 
            this.StartDelay.Location = new System.Drawing.Point(22, 2);
            this.StartDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.StartDelay.Name = "StartDelay";
            this.StartDelay.Size = new System.Drawing.Size(46, 20);
            this.StartDelay.TabIndex = 13;
            this.StartDelay.Tag = "15";
            this.StartDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.StartDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // StartDKPanel
            // 
            this.StartDKPanel.Controls.Add(this.StartDKD);
            this.StartDKPanel.Controls.Add(this.StartDKC);
            this.StartDKPanel.Location = new System.Drawing.Point(247, 0);
            this.StartDKPanel.Name = "StartDKPanel";
            this.StartDKPanel.Size = new System.Drawing.Size(102, 25);
            this.StartDKPanel.TabIndex = 9;
            // 
            // StartDKD
            // 
            this.StartDKD.AutoSize = true;
            this.StartDKD.Location = new System.Drawing.Point(75, 4);
            this.StartDKD.Name = "StartDKD";
            this.StartDKD.Size = new System.Drawing.Size(14, 13);
            this.StartDKD.TabIndex = 1;
            this.StartDKD.Tag = "15";
            this.StartDKD.UseVisualStyleBackColor = true;
            this.StartDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // StartDKC
            // 
            this.StartDKC.AutoSize = true;
            this.StartDKC.Checked = true;
            this.StartDKC.Location = new System.Drawing.Point(14, 4);
            this.StartDKC.Name = "StartDKC";
            this.StartDKC.Size = new System.Drawing.Size(14, 13);
            this.StartDKC.TabIndex = 0;
            this.StartDKC.TabStop = true;
            this.StartDKC.Tag = "15";
            this.StartDKC.UseVisualStyleBackColor = true;
            this.StartDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // StartSKPanel
            // 
            this.StartSKPanel.Controls.Add(this.StartSKD);
            this.StartSKPanel.Controls.Add(this.StartSKC);
            this.StartSKPanel.Location = new System.Drawing.Point(104, 0);
            this.StartSKPanel.Name = "StartSKPanel";
            this.StartSKPanel.Size = new System.Drawing.Size(102, 25);
            this.StartSKPanel.TabIndex = 9;
            // 
            // StartSKD
            // 
            this.StartSKD.AutoSize = true;
            this.StartSKD.Checked = true;
            this.StartSKD.Location = new System.Drawing.Point(75, 4);
            this.StartSKD.Name = "StartSKD";
            this.StartSKD.Size = new System.Drawing.Size(14, 13);
            this.StartSKD.TabIndex = 1;
            this.StartSKD.TabStop = true;
            this.StartSKD.Tag = "15";
            this.StartSKD.UseVisualStyleBackColor = true;
            this.StartSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // StartSKC
            // 
            this.StartSKC.AutoSize = true;
            this.StartSKC.Location = new System.Drawing.Point(14, 4);
            this.StartSKC.Name = "StartSKC";
            this.StartSKC.Size = new System.Drawing.Size(14, 13);
            this.StartSKC.TabIndex = 0;
            this.StartSKC.Tag = "15";
            this.StartSKC.UseVisualStyleBackColor = true;
            this.StartSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // StartSDMax
            // 
            this.StartSDMax.Location = new System.Drawing.Point(503, 2);
            this.StartSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.StartSDMax.Name = "StartSDMax";
            this.StartSDMax.Size = new System.Drawing.Size(45, 20);
            this.StartSDMax.TabIndex = 7;
            this.StartSDMax.Tag = "15";
            this.StartSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // StartSDMin
            // 
            this.StartSDMin.Location = new System.Drawing.Point(451, 2);
            this.StartSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StartSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.StartSDMin.Name = "StartSDMin";
            this.StartSDMin.Size = new System.Drawing.Size(46, 20);
            this.StartSDMin.TabIndex = 6;
            this.StartSDMin.Tag = "15";
            this.StartSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.StartSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // StartSDECheckBox
            // 
            this.StartSDECheckBox.AutoSize = true;
            this.StartSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.StartSDECheckBox.Name = "StartSDECheckBox";
            this.StartSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.StartSDECheckBox.TabIndex = 4;
            this.StartSDECheckBox.Tag = "15";
            this.StartSDECheckBox.UseVisualStyleBackColor = true;
            this.StartSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.CDownDelay);
            this.panel12.Controls.Add(this.CDownSKPanel);
            this.panel12.Controls.Add(this.CDownSDMax);
            this.panel12.Controls.Add(this.CDownSDMin);
            this.panel12.Controls.Add(this.CDownSDECheckBox);
            this.panel12.Location = new System.Drawing.Point(90, 344);
            this.panel12.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(556, 25);
            this.panel12.TabIndex = 35;
            // 
            // CDownDelay
            // 
            this.CDownDelay.Location = new System.Drawing.Point(22, 2);
            this.CDownDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CDownDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CDownDelay.Name = "CDownDelay";
            this.CDownDelay.Size = new System.Drawing.Size(46, 20);
            this.CDownDelay.TabIndex = 11;
            this.CDownDelay.Tag = "10";
            this.CDownDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CDownDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // CDownSKPanel
            // 
            this.CDownSKPanel.Controls.Add(this.CDownSKD);
            this.CDownSKPanel.Controls.Add(this.CDownSKC);
            this.CDownSKPanel.Location = new System.Drawing.Point(104, 0);
            this.CDownSKPanel.Name = "CDownSKPanel";
            this.CDownSKPanel.Size = new System.Drawing.Size(102, 25);
            this.CDownSKPanel.TabIndex = 9;
            // 
            // CDownSKD
            // 
            this.CDownSKD.AutoSize = true;
            this.CDownSKD.Checked = true;
            this.CDownSKD.Location = new System.Drawing.Point(75, 4);
            this.CDownSKD.Name = "CDownSKD";
            this.CDownSKD.Size = new System.Drawing.Size(14, 13);
            this.CDownSKD.TabIndex = 1;
            this.CDownSKD.TabStop = true;
            this.CDownSKD.Tag = "10";
            this.CDownSKD.UseVisualStyleBackColor = true;
            this.CDownSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CDownSKC
            // 
            this.CDownSKC.AutoSize = true;
            this.CDownSKC.Location = new System.Drawing.Point(14, 4);
            this.CDownSKC.Name = "CDownSKC";
            this.CDownSKC.Size = new System.Drawing.Size(14, 13);
            this.CDownSKC.TabIndex = 0;
            this.CDownSKC.Tag = "10";
            this.CDownSKC.UseVisualStyleBackColor = true;
            this.CDownSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CDownSDMax
            // 
            this.CDownSDMax.Location = new System.Drawing.Point(503, 2);
            this.CDownSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CDownSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CDownSDMax.Name = "CDownSDMax";
            this.CDownSDMax.Size = new System.Drawing.Size(45, 20);
            this.CDownSDMax.TabIndex = 7;
            this.CDownSDMax.Tag = "10";
            this.CDownSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CDownSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // CDownSDMin
            // 
            this.CDownSDMin.Location = new System.Drawing.Point(451, 2);
            this.CDownSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CDownSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CDownSDMin.Name = "CDownSDMin";
            this.CDownSDMin.Size = new System.Drawing.Size(46, 20);
            this.CDownSDMin.TabIndex = 6;
            this.CDownSDMin.Tag = "10";
            this.CDownSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CDownSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // CDownSDECheckBox
            // 
            this.CDownSDECheckBox.AutoSize = true;
            this.CDownSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.CDownSDECheckBox.Name = "CDownSDECheckBox";
            this.CDownSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.CDownSDECheckBox.TabIndex = 4;
            this.CDownSDECheckBox.Tag = "10";
            this.CDownSDECheckBox.UseVisualStyleBackColor = true;
            this.CDownSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(53, 486);
            this.label23.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 13);
            this.label23.TabIndex = 38;
            this.label23.Text = "Start";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(37, 346);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "C Down";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.ZTriggerDelay);
            this.panel18.Controls.Add(this.ZTriggerDKPanel);
            this.panel18.Controls.Add(this.ZTriggerSKPanel);
            this.panel18.Controls.Add(this.ZTriggerSDMax);
            this.panel18.Controls.Add(this.ZTriggerSDMin);
            this.panel18.Controls.Add(this.ZTriggerSDECheckBox);
            this.panel18.Location = new System.Drawing.Point(90, 456);
            this.panel18.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(556, 25);
            this.panel18.TabIndex = 44;
            // 
            // ZTriggerDelay
            // 
            this.ZTriggerDelay.Location = new System.Drawing.Point(22, 2);
            this.ZTriggerDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZTriggerDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ZTriggerDelay.Name = "ZTriggerDelay";
            this.ZTriggerDelay.Size = new System.Drawing.Size(46, 20);
            this.ZTriggerDelay.TabIndex = 12;
            this.ZTriggerDelay.Tag = "14";
            this.ZTriggerDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ZTriggerDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // ZTriggerDKPanel
            // 
            this.ZTriggerDKPanel.Controls.Add(this.ZTriggerDKD);
            this.ZTriggerDKPanel.Controls.Add(this.ZTriggerDKC);
            this.ZTriggerDKPanel.Location = new System.Drawing.Point(247, 0);
            this.ZTriggerDKPanel.Name = "ZTriggerDKPanel";
            this.ZTriggerDKPanel.Size = new System.Drawing.Size(102, 25);
            this.ZTriggerDKPanel.TabIndex = 9;
            // 
            // ZTriggerDKD
            // 
            this.ZTriggerDKD.AutoSize = true;
            this.ZTriggerDKD.Location = new System.Drawing.Point(75, 4);
            this.ZTriggerDKD.Name = "ZTriggerDKD";
            this.ZTriggerDKD.Size = new System.Drawing.Size(14, 13);
            this.ZTriggerDKD.TabIndex = 1;
            this.ZTriggerDKD.Tag = "14";
            this.ZTriggerDKD.UseVisualStyleBackColor = true;
            this.ZTriggerDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ZTriggerDKC
            // 
            this.ZTriggerDKC.AutoSize = true;
            this.ZTriggerDKC.Checked = true;
            this.ZTriggerDKC.Location = new System.Drawing.Point(14, 4);
            this.ZTriggerDKC.Name = "ZTriggerDKC";
            this.ZTriggerDKC.Size = new System.Drawing.Size(14, 13);
            this.ZTriggerDKC.TabIndex = 0;
            this.ZTriggerDKC.TabStop = true;
            this.ZTriggerDKC.Tag = "14";
            this.ZTriggerDKC.UseVisualStyleBackColor = true;
            this.ZTriggerDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ZTriggerSKPanel
            // 
            this.ZTriggerSKPanel.Controls.Add(this.ZTriggerSKD);
            this.ZTriggerSKPanel.Controls.Add(this.ZTriggerSKC);
            this.ZTriggerSKPanel.Location = new System.Drawing.Point(104, 0);
            this.ZTriggerSKPanel.Name = "ZTriggerSKPanel";
            this.ZTriggerSKPanel.Size = new System.Drawing.Size(102, 25);
            this.ZTriggerSKPanel.TabIndex = 9;
            // 
            // ZTriggerSKD
            // 
            this.ZTriggerSKD.AutoSize = true;
            this.ZTriggerSKD.Checked = true;
            this.ZTriggerSKD.Location = new System.Drawing.Point(75, 4);
            this.ZTriggerSKD.Name = "ZTriggerSKD";
            this.ZTriggerSKD.Size = new System.Drawing.Size(14, 13);
            this.ZTriggerSKD.TabIndex = 1;
            this.ZTriggerSKD.TabStop = true;
            this.ZTriggerSKD.Tag = "14";
            this.ZTriggerSKD.UseVisualStyleBackColor = true;
            this.ZTriggerSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ZTriggerSKC
            // 
            this.ZTriggerSKC.AutoSize = true;
            this.ZTriggerSKC.Location = new System.Drawing.Point(14, 4);
            this.ZTriggerSKC.Name = "ZTriggerSKC";
            this.ZTriggerSKC.Size = new System.Drawing.Size(14, 13);
            this.ZTriggerSKC.TabIndex = 0;
            this.ZTriggerSKC.Tag = "14";
            this.ZTriggerSKC.UseVisualStyleBackColor = true;
            this.ZTriggerSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ZTriggerSDMax
            // 
            this.ZTriggerSDMax.Location = new System.Drawing.Point(503, 2);
            this.ZTriggerSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZTriggerSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ZTriggerSDMax.Name = "ZTriggerSDMax";
            this.ZTriggerSDMax.Size = new System.Drawing.Size(45, 20);
            this.ZTriggerSDMax.TabIndex = 7;
            this.ZTriggerSDMax.Tag = "14";
            this.ZTriggerSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZTriggerSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // ZTriggerSDMin
            // 
            this.ZTriggerSDMin.Location = new System.Drawing.Point(451, 2);
            this.ZTriggerSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZTriggerSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ZTriggerSDMin.Name = "ZTriggerSDMin";
            this.ZTriggerSDMin.Size = new System.Drawing.Size(46, 20);
            this.ZTriggerSDMin.TabIndex = 6;
            this.ZTriggerSDMin.Tag = "14";
            this.ZTriggerSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ZTriggerSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // ZTriggerSDECheckBox
            // 
            this.ZTriggerSDECheckBox.AutoSize = true;
            this.ZTriggerSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.ZTriggerSDECheckBox.Name = "ZTriggerSDECheckBox";
            this.ZTriggerSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.ZTriggerSDECheckBox.TabIndex = 4;
            this.ZTriggerSDECheckBox.Tag = "14";
            this.ZTriggerSDECheckBox.UseVisualStyleBackColor = true;
            this.ZTriggerSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.CRightDelay);
            this.panel11.Controls.Add(this.CRightDKPanel);
            this.panel11.Controls.Add(this.CRightSDMax);
            this.panel11.Controls.Add(this.CRightSDMin);
            this.panel11.Controls.Add(this.CRightSDECheckBox);
            this.panel11.Location = new System.Drawing.Point(90, 316);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(556, 25);
            this.panel11.TabIndex = 35;
            // 
            // CRightDelay
            // 
            this.CRightDelay.Location = new System.Drawing.Point(22, 2);
            this.CRightDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CRightDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CRightDelay.Name = "CRightDelay";
            this.CRightDelay.Size = new System.Drawing.Size(46, 20);
            this.CRightDelay.TabIndex = 11;
            this.CRightDelay.Tag = "9";
            this.CRightDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CRightDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // CRightDKPanel
            // 
            this.CRightDKPanel.Controls.Add(this.CRightDKD);
            this.CRightDKPanel.Controls.Add(this.CRightDKC);
            this.CRightDKPanel.Location = new System.Drawing.Point(247, 0);
            this.CRightDKPanel.Name = "CRightDKPanel";
            this.CRightDKPanel.Size = new System.Drawing.Size(102, 25);
            this.CRightDKPanel.TabIndex = 9;
            // 
            // CRightDKD
            // 
            this.CRightDKD.AutoSize = true;
            this.CRightDKD.Location = new System.Drawing.Point(75, 4);
            this.CRightDKD.Name = "CRightDKD";
            this.CRightDKD.Size = new System.Drawing.Size(14, 13);
            this.CRightDKD.TabIndex = 1;
            this.CRightDKD.Tag = "9";
            this.CRightDKD.UseVisualStyleBackColor = true;
            this.CRightDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CRightDKC
            // 
            this.CRightDKC.AutoSize = true;
            this.CRightDKC.Checked = true;
            this.CRightDKC.Location = new System.Drawing.Point(14, 4);
            this.CRightDKC.Name = "CRightDKC";
            this.CRightDKC.Size = new System.Drawing.Size(14, 13);
            this.CRightDKC.TabIndex = 0;
            this.CRightDKC.TabStop = true;
            this.CRightDKC.Tag = "9";
            this.CRightDKC.UseVisualStyleBackColor = true;
            this.CRightDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CRightSDMax
            // 
            this.CRightSDMax.Location = new System.Drawing.Point(503, 2);
            this.CRightSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CRightSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CRightSDMax.Name = "CRightSDMax";
            this.CRightSDMax.Size = new System.Drawing.Size(45, 20);
            this.CRightSDMax.TabIndex = 7;
            this.CRightSDMax.Tag = "9";
            this.CRightSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CRightSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // CRightSDMin
            // 
            this.CRightSDMin.Location = new System.Drawing.Point(451, 2);
            this.CRightSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CRightSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CRightSDMin.Name = "CRightSDMin";
            this.CRightSDMin.Size = new System.Drawing.Size(46, 20);
            this.CRightSDMin.TabIndex = 6;
            this.CRightSDMin.Tag = "9";
            this.CRightSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CRightSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // CRightSDECheckBox
            // 
            this.CRightSDECheckBox.AutoSize = true;
            this.CRightSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.CRightSDECheckBox.Name = "CRightSDECheckBox";
            this.CRightSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.CRightSDECheckBox.TabIndex = 4;
            this.CRightSDECheckBox.Tag = "9";
            this.CRightSDECheckBox.UseVisualStyleBackColor = true;
            this.CRightSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(32, 458);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 39;
            this.label24.Text = "Z Trigger";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 318);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "C Right";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.LTriggerDelay);
            this.panel19.Controls.Add(this.LTriggerDKPanel);
            this.panel19.Controls.Add(this.LTriggerSKPanel);
            this.panel19.Controls.Add(this.LTriggerSDMax);
            this.panel19.Controls.Add(this.LTriggerSDMin);
            this.panel19.Controls.Add(this.LTriggerSDECheckBox);
            this.panel19.Location = new System.Drawing.Point(90, 428);
            this.panel19.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(556, 25);
            this.panel19.TabIndex = 45;
            // 
            // LTriggerDelay
            // 
            this.LTriggerDelay.Location = new System.Drawing.Point(22, 2);
            this.LTriggerDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LTriggerDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.LTriggerDelay.Name = "LTriggerDelay";
            this.LTriggerDelay.Size = new System.Drawing.Size(46, 20);
            this.LTriggerDelay.TabIndex = 11;
            this.LTriggerDelay.Tag = "13";
            this.LTriggerDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.LTriggerDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // LTriggerDKPanel
            // 
            this.LTriggerDKPanel.Controls.Add(this.LTriggerDKD);
            this.LTriggerDKPanel.Controls.Add(this.LTriggerDKC);
            this.LTriggerDKPanel.Location = new System.Drawing.Point(247, 0);
            this.LTriggerDKPanel.Name = "LTriggerDKPanel";
            this.LTriggerDKPanel.Size = new System.Drawing.Size(102, 25);
            this.LTriggerDKPanel.TabIndex = 9;
            // 
            // LTriggerDKD
            // 
            this.LTriggerDKD.AutoSize = true;
            this.LTriggerDKD.Location = new System.Drawing.Point(75, 4);
            this.LTriggerDKD.Name = "LTriggerDKD";
            this.LTriggerDKD.Size = new System.Drawing.Size(14, 13);
            this.LTriggerDKD.TabIndex = 1;
            this.LTriggerDKD.Tag = "13";
            this.LTriggerDKD.UseVisualStyleBackColor = true;
            this.LTriggerDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // LTriggerDKC
            // 
            this.LTriggerDKC.AutoSize = true;
            this.LTriggerDKC.Checked = true;
            this.LTriggerDKC.Location = new System.Drawing.Point(14, 4);
            this.LTriggerDKC.Name = "LTriggerDKC";
            this.LTriggerDKC.Size = new System.Drawing.Size(14, 13);
            this.LTriggerDKC.TabIndex = 0;
            this.LTriggerDKC.TabStop = true;
            this.LTriggerDKC.Tag = "13";
            this.LTriggerDKC.UseVisualStyleBackColor = true;
            this.LTriggerDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // LTriggerSKPanel
            // 
            this.LTriggerSKPanel.Controls.Add(this.LTriggerSKD);
            this.LTriggerSKPanel.Controls.Add(this.LTriggerSKC);
            this.LTriggerSKPanel.Location = new System.Drawing.Point(104, 0);
            this.LTriggerSKPanel.Name = "LTriggerSKPanel";
            this.LTriggerSKPanel.Size = new System.Drawing.Size(102, 25);
            this.LTriggerSKPanel.TabIndex = 9;
            // 
            // LTriggerSKD
            // 
            this.LTriggerSKD.AutoSize = true;
            this.LTriggerSKD.Checked = true;
            this.LTriggerSKD.Location = new System.Drawing.Point(75, 4);
            this.LTriggerSKD.Name = "LTriggerSKD";
            this.LTriggerSKD.Size = new System.Drawing.Size(14, 13);
            this.LTriggerSKD.TabIndex = 1;
            this.LTriggerSKD.TabStop = true;
            this.LTriggerSKD.Tag = "13";
            this.LTriggerSKD.UseVisualStyleBackColor = true;
            this.LTriggerSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // LTriggerSKC
            // 
            this.LTriggerSKC.AutoSize = true;
            this.LTriggerSKC.Location = new System.Drawing.Point(14, 4);
            this.LTriggerSKC.Name = "LTriggerSKC";
            this.LTriggerSKC.Size = new System.Drawing.Size(14, 13);
            this.LTriggerSKC.TabIndex = 0;
            this.LTriggerSKC.Tag = "13";
            this.LTriggerSKC.UseVisualStyleBackColor = true;
            this.LTriggerSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // LTriggerSDMax
            // 
            this.LTriggerSDMax.Location = new System.Drawing.Point(503, 2);
            this.LTriggerSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LTriggerSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.LTriggerSDMax.Name = "LTriggerSDMax";
            this.LTriggerSDMax.Size = new System.Drawing.Size(45, 20);
            this.LTriggerSDMax.TabIndex = 7;
            this.LTriggerSDMax.Tag = "13";
            this.LTriggerSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LTriggerSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // LTriggerSDMin
            // 
            this.LTriggerSDMin.Location = new System.Drawing.Point(451, 2);
            this.LTriggerSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LTriggerSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.LTriggerSDMin.Name = "LTriggerSDMin";
            this.LTriggerSDMin.Size = new System.Drawing.Size(46, 20);
            this.LTriggerSDMin.TabIndex = 6;
            this.LTriggerSDMin.Tag = "13";
            this.LTriggerSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.LTriggerSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // LTriggerSDECheckBox
            // 
            this.LTriggerSDECheckBox.AutoSize = true;
            this.LTriggerSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.LTriggerSDECheckBox.Name = "LTriggerSDECheckBox";
            this.LTriggerSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.LTriggerSDECheckBox.TabIndex = 4;
            this.LTriggerSDECheckBox.Tag = "13";
            this.LTriggerSDECheckBox.UseVisualStyleBackColor = true;
            this.LTriggerSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 430);
            this.label25.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 13);
            this.label25.TabIndex = 40;
            this.label25.Text = "L Trigger";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.CUpDelay);
            this.panel10.Controls.Add(this.CUpDKPanel);
            this.panel10.Controls.Add(this.CUpSKPanel);
            this.panel10.Controls.Add(this.CUpSDMax);
            this.panel10.Controls.Add(this.CUpSDMin);
            this.panel10.Controls.Add(this.CUpSDECheckBox);
            this.panel10.Location = new System.Drawing.Point(90, 288);
            this.panel10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(556, 25);
            this.panel10.TabIndex = 35;
            // 
            // CUpDelay
            // 
            this.CUpDelay.Location = new System.Drawing.Point(22, 2);
            this.CUpDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CUpDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CUpDelay.Name = "CUpDelay";
            this.CUpDelay.Size = new System.Drawing.Size(46, 20);
            this.CUpDelay.TabIndex = 16;
            this.CUpDelay.Tag = "8";
            this.CUpDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CUpDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // CUpDKPanel
            // 
            this.CUpDKPanel.Controls.Add(this.CUpDKD);
            this.CUpDKPanel.Controls.Add(this.CUpDKC);
            this.CUpDKPanel.Location = new System.Drawing.Point(247, 0);
            this.CUpDKPanel.Name = "CUpDKPanel";
            this.CUpDKPanel.Size = new System.Drawing.Size(102, 25);
            this.CUpDKPanel.TabIndex = 9;
            // 
            // CUpDKD
            // 
            this.CUpDKD.AutoSize = true;
            this.CUpDKD.Location = new System.Drawing.Point(75, 4);
            this.CUpDKD.Name = "CUpDKD";
            this.CUpDKD.Size = new System.Drawing.Size(14, 13);
            this.CUpDKD.TabIndex = 1;
            this.CUpDKD.Tag = "8";
            this.CUpDKD.UseVisualStyleBackColor = true;
            this.CUpDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CUpDKC
            // 
            this.CUpDKC.AutoSize = true;
            this.CUpDKC.Checked = true;
            this.CUpDKC.Location = new System.Drawing.Point(14, 4);
            this.CUpDKC.Name = "CUpDKC";
            this.CUpDKC.Size = new System.Drawing.Size(14, 13);
            this.CUpDKC.TabIndex = 0;
            this.CUpDKC.TabStop = true;
            this.CUpDKC.Tag = "8";
            this.CUpDKC.UseVisualStyleBackColor = true;
            this.CUpDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // CUpSKPanel
            // 
            this.CUpSKPanel.Controls.Add(this.CUpSKD);
            this.CUpSKPanel.Controls.Add(this.CUpSKC);
            this.CUpSKPanel.Location = new System.Drawing.Point(104, 0);
            this.CUpSKPanel.Name = "CUpSKPanel";
            this.CUpSKPanel.Size = new System.Drawing.Size(102, 25);
            this.CUpSKPanel.TabIndex = 9;
            // 
            // CUpSKD
            // 
            this.CUpSKD.AutoSize = true;
            this.CUpSKD.Checked = true;
            this.CUpSKD.Location = new System.Drawing.Point(75, 4);
            this.CUpSKD.Name = "CUpSKD";
            this.CUpSKD.Size = new System.Drawing.Size(14, 13);
            this.CUpSKD.TabIndex = 1;
            this.CUpSKD.TabStop = true;
            this.CUpSKD.Tag = "8";
            this.CUpSKD.UseVisualStyleBackColor = true;
            this.CUpSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CUpSKC
            // 
            this.CUpSKC.AutoSize = true;
            this.CUpSKC.Location = new System.Drawing.Point(14, 4);
            this.CUpSKC.Name = "CUpSKC";
            this.CUpSKC.Size = new System.Drawing.Size(14, 13);
            this.CUpSKC.TabIndex = 0;
            this.CUpSKC.Tag = "8";
            this.CUpSKC.UseVisualStyleBackColor = true;
            this.CUpSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // CUpSDMax
            // 
            this.CUpSDMax.Location = new System.Drawing.Point(503, 2);
            this.CUpSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CUpSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CUpSDMax.Name = "CUpSDMax";
            this.CUpSDMax.Size = new System.Drawing.Size(45, 20);
            this.CUpSDMax.TabIndex = 7;
            this.CUpSDMax.Tag = "8";
            this.CUpSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CUpSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // CUpSDMin
            // 
            this.CUpSDMin.Location = new System.Drawing.Point(451, 2);
            this.CUpSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CUpSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CUpSDMin.Name = "CUpSDMin";
            this.CUpSDMin.Size = new System.Drawing.Size(46, 20);
            this.CUpSDMin.TabIndex = 6;
            this.CUpSDMin.Tag = "8";
            this.CUpSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.CUpSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // CUpSDECheckBox
            // 
            this.CUpSDECheckBox.AutoSize = true;
            this.CUpSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.CUpSDECheckBox.Name = "CUpSDECheckBox";
            this.CUpSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.CUpSDECheckBox.TabIndex = 4;
            this.CUpSDECheckBox.Tag = "8";
            this.CUpSDECheckBox.UseVisualStyleBackColor = true;
            this.CUpSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(51, 290);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "C Up";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.DLeftDelay);
            this.panel9.Controls.Add(this.DLeftSKPanel);
            this.panel9.Controls.Add(this.DLeftSDMax);
            this.panel9.Controls.Add(this.DLeftSDMin);
            this.panel9.Controls.Add(this.DLeftSDECheckBox);
            this.panel9.Location = new System.Drawing.Point(90, 260);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(556, 25);
            this.panel9.TabIndex = 35;
            // 
            // DLeftDelay
            // 
            this.DLeftDelay.Location = new System.Drawing.Point(22, 2);
            this.DLeftDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DLeftDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DLeftDelay.Name = "DLeftDelay";
            this.DLeftDelay.Size = new System.Drawing.Size(46, 20);
            this.DLeftDelay.TabIndex = 15;
            this.DLeftDelay.Tag = "7";
            this.DLeftDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DLeftDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // DLeftSKPanel
            // 
            this.DLeftSKPanel.Controls.Add(this.DLeftSKD);
            this.DLeftSKPanel.Controls.Add(this.DLeftSKC);
            this.DLeftSKPanel.Location = new System.Drawing.Point(104, 0);
            this.DLeftSKPanel.Name = "DLeftSKPanel";
            this.DLeftSKPanel.Size = new System.Drawing.Size(102, 25);
            this.DLeftSKPanel.TabIndex = 9;
            // 
            // DLeftSKD
            // 
            this.DLeftSKD.AutoSize = true;
            this.DLeftSKD.Checked = true;
            this.DLeftSKD.Location = new System.Drawing.Point(75, 4);
            this.DLeftSKD.Name = "DLeftSKD";
            this.DLeftSKD.Size = new System.Drawing.Size(14, 13);
            this.DLeftSKD.TabIndex = 1;
            this.DLeftSKD.TabStop = true;
            this.DLeftSKD.Tag = "7";
            this.DLeftSKD.UseVisualStyleBackColor = true;
            this.DLeftSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DLeftSKC
            // 
            this.DLeftSKC.AutoSize = true;
            this.DLeftSKC.Location = new System.Drawing.Point(14, 4);
            this.DLeftSKC.Name = "DLeftSKC";
            this.DLeftSKC.Size = new System.Drawing.Size(14, 13);
            this.DLeftSKC.TabIndex = 0;
            this.DLeftSKC.Tag = "7";
            this.DLeftSKC.UseVisualStyleBackColor = true;
            this.DLeftSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DLeftSDMax
            // 
            this.DLeftSDMax.Location = new System.Drawing.Point(503, 2);
            this.DLeftSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DLeftSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DLeftSDMax.Name = "DLeftSDMax";
            this.DLeftSDMax.Size = new System.Drawing.Size(45, 20);
            this.DLeftSDMax.TabIndex = 7;
            this.DLeftSDMax.Tag = "7";
            this.DLeftSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DLeftSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // DLeftSDMin
            // 
            this.DLeftSDMin.Location = new System.Drawing.Point(451, 2);
            this.DLeftSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DLeftSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DLeftSDMin.Name = "DLeftSDMin";
            this.DLeftSDMin.Size = new System.Drawing.Size(46, 20);
            this.DLeftSDMin.TabIndex = 6;
            this.DLeftSDMin.Tag = "7";
            this.DLeftSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DLeftSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // DLeftSDECheckBox
            // 
            this.DLeftSDECheckBox.AutoSize = true;
            this.DLeftSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.DLeftSDECheckBox.Name = "DLeftSDECheckBox";
            this.DLeftSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.DLeftSDECheckBox.TabIndex = 4;
            this.DLeftSDECheckBox.Tag = "7";
            this.DLeftSDECheckBox.UseVisualStyleBackColor = true;
            this.DLeftSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 261);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "DPad Left";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DDownDelay);
            this.panel8.Controls.Add(this.DDownSKPanel);
            this.panel8.Controls.Add(this.DDownSDMax);
            this.panel8.Controls.Add(this.DDownSDMin);
            this.panel8.Controls.Add(this.DDownSDECheckBox);
            this.panel8.Location = new System.Drawing.Point(90, 232);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(556, 25);
            this.panel8.TabIndex = 35;
            // 
            // DDownDelay
            // 
            this.DDownDelay.Location = new System.Drawing.Point(22, 2);
            this.DDownDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DDownDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DDownDelay.Name = "DDownDelay";
            this.DDownDelay.Size = new System.Drawing.Size(46, 20);
            this.DDownDelay.TabIndex = 14;
            this.DDownDelay.Tag = "6";
            this.DDownDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DDownDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // DDownSKPanel
            // 
            this.DDownSKPanel.Controls.Add(this.DDownSKD);
            this.DDownSKPanel.Controls.Add(this.DDownSKC);
            this.DDownSKPanel.Location = new System.Drawing.Point(104, 0);
            this.DDownSKPanel.Name = "DDownSKPanel";
            this.DDownSKPanel.Size = new System.Drawing.Size(102, 25);
            this.DDownSKPanel.TabIndex = 9;
            // 
            // DDownSKD
            // 
            this.DDownSKD.AutoSize = true;
            this.DDownSKD.Checked = true;
            this.DDownSKD.Location = new System.Drawing.Point(75, 4);
            this.DDownSKD.Name = "DDownSKD";
            this.DDownSKD.Size = new System.Drawing.Size(14, 13);
            this.DDownSKD.TabIndex = 1;
            this.DDownSKD.TabStop = true;
            this.DDownSKD.Tag = "6";
            this.DDownSKD.UseVisualStyleBackColor = true;
            this.DDownSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DDownSKC
            // 
            this.DDownSKC.AutoSize = true;
            this.DDownSKC.Location = new System.Drawing.Point(14, 4);
            this.DDownSKC.Name = "DDownSKC";
            this.DDownSKC.Size = new System.Drawing.Size(14, 13);
            this.DDownSKC.TabIndex = 0;
            this.DDownSKC.Tag = "6";
            this.DDownSKC.UseVisualStyleBackColor = true;
            this.DDownSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DDownSDMax
            // 
            this.DDownSDMax.Location = new System.Drawing.Point(503, 2);
            this.DDownSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DDownSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DDownSDMax.Name = "DDownSDMax";
            this.DDownSDMax.Size = new System.Drawing.Size(45, 20);
            this.DDownSDMax.TabIndex = 7;
            this.DDownSDMax.Tag = "6";
            this.DDownSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DDownSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // DDownSDMin
            // 
            this.DDownSDMin.Location = new System.Drawing.Point(451, 2);
            this.DDownSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DDownSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DDownSDMin.Name = "DDownSDMin";
            this.DDownSDMin.Size = new System.Drawing.Size(46, 20);
            this.DDownSDMin.TabIndex = 6;
            this.DDownSDMin.Tag = "6";
            this.DDownSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DDownSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // DDownSDECheckBox
            // 
            this.DDownSDECheckBox.AutoSize = true;
            this.DDownSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.DDownSDECheckBox.Name = "DDownSDECheckBox";
            this.DDownSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.DDownSDECheckBox.TabIndex = 4;
            this.DDownSDECheckBox.Tag = "6";
            this.DDownSDECheckBox.UseVisualStyleBackColor = true;
            this.DDownSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 234);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "DPad Down";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.DRightDelay);
            this.panel7.Controls.Add(this.DRightDKPanel);
            this.panel7.Controls.Add(this.DRightSKPanel);
            this.panel7.Controls.Add(this.DRightSDMax);
            this.panel7.Controls.Add(this.DRightSDMin);
            this.panel7.Controls.Add(this.DRightSDECheckBox);
            this.panel7.Location = new System.Drawing.Point(90, 204);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(556, 25);
            this.panel7.TabIndex = 35;
            // 
            // DRightDelay
            // 
            this.DRightDelay.Location = new System.Drawing.Point(22, 2);
            this.DRightDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DRightDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DRightDelay.Name = "DRightDelay";
            this.DRightDelay.Size = new System.Drawing.Size(46, 20);
            this.DRightDelay.TabIndex = 13;
            this.DRightDelay.Tag = "5";
            this.DRightDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DRightDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // DRightDKPanel
            // 
            this.DRightDKPanel.Controls.Add(this.DRightDKD);
            this.DRightDKPanel.Controls.Add(this.DRightDKC);
            this.DRightDKPanel.Location = new System.Drawing.Point(247, 0);
            this.DRightDKPanel.Name = "DRightDKPanel";
            this.DRightDKPanel.Size = new System.Drawing.Size(102, 25);
            this.DRightDKPanel.TabIndex = 9;
            // 
            // DRightDKD
            // 
            this.DRightDKD.AutoSize = true;
            this.DRightDKD.Location = new System.Drawing.Point(75, 4);
            this.DRightDKD.Name = "DRightDKD";
            this.DRightDKD.Size = new System.Drawing.Size(14, 13);
            this.DRightDKD.TabIndex = 1;
            this.DRightDKD.Tag = "5";
            this.DRightDKD.UseVisualStyleBackColor = true;
            this.DRightDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DRightDKC
            // 
            this.DRightDKC.AutoSize = true;
            this.DRightDKC.Checked = true;
            this.DRightDKC.Location = new System.Drawing.Point(14, 4);
            this.DRightDKC.Name = "DRightDKC";
            this.DRightDKC.Size = new System.Drawing.Size(14, 13);
            this.DRightDKC.TabIndex = 0;
            this.DRightDKC.TabStop = true;
            this.DRightDKC.Tag = "5";
            this.DRightDKC.UseVisualStyleBackColor = true;
            this.DRightDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DRightSKPanel
            // 
            this.DRightSKPanel.Controls.Add(this.DRightSKD);
            this.DRightSKPanel.Controls.Add(this.DRightSKC);
            this.DRightSKPanel.Location = new System.Drawing.Point(104, 0);
            this.DRightSKPanel.Name = "DRightSKPanel";
            this.DRightSKPanel.Size = new System.Drawing.Size(102, 25);
            this.DRightSKPanel.TabIndex = 9;
            // 
            // DRightSKD
            // 
            this.DRightSKD.AutoSize = true;
            this.DRightSKD.Checked = true;
            this.DRightSKD.Location = new System.Drawing.Point(75, 4);
            this.DRightSKD.Name = "DRightSKD";
            this.DRightSKD.Size = new System.Drawing.Size(14, 13);
            this.DRightSKD.TabIndex = 1;
            this.DRightSKD.TabStop = true;
            this.DRightSKD.Tag = "5";
            this.DRightSKD.UseVisualStyleBackColor = true;
            this.DRightSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DRightSKC
            // 
            this.DRightSKC.AutoSize = true;
            this.DRightSKC.Location = new System.Drawing.Point(14, 4);
            this.DRightSKC.Name = "DRightSKC";
            this.DRightSKC.Size = new System.Drawing.Size(14, 13);
            this.DRightSKC.TabIndex = 0;
            this.DRightSKC.Tag = "5";
            this.DRightSKC.UseVisualStyleBackColor = true;
            this.DRightSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DRightSDMax
            // 
            this.DRightSDMax.Location = new System.Drawing.Point(503, 2);
            this.DRightSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DRightSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DRightSDMax.Name = "DRightSDMax";
            this.DRightSDMax.Size = new System.Drawing.Size(45, 20);
            this.DRightSDMax.TabIndex = 7;
            this.DRightSDMax.Tag = "5";
            this.DRightSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DRightSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // DRightSDMin
            // 
            this.DRightSDMin.Location = new System.Drawing.Point(451, 2);
            this.DRightSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DRightSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DRightSDMin.Name = "DRightSDMin";
            this.DRightSDMin.Size = new System.Drawing.Size(46, 20);
            this.DRightSDMin.TabIndex = 6;
            this.DRightSDMin.Tag = "5";
            this.DRightSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DRightSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // DRightSDECheckBox
            // 
            this.DRightSDECheckBox.AutoSize = true;
            this.DRightSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.DRightSDECheckBox.Name = "DRightSDECheckBox";
            this.DRightSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.DRightSDECheckBox.TabIndex = 4;
            this.DRightSDECheckBox.Tag = "5";
            this.DRightSDECheckBox.UseVisualStyleBackColor = true;
            this.DRightSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "DPad Right";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DUpDelay);
            this.panel6.Controls.Add(this.DUpDKPanel);
            this.panel6.Controls.Add(this.DUpSKPanel);
            this.panel6.Controls.Add(this.DUpSDMax);
            this.panel6.Controls.Add(this.DUpSDMin);
            this.panel6.Controls.Add(this.DUpSDECheckBox);
            this.panel6.Location = new System.Drawing.Point(90, 176);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 25);
            this.panel6.TabIndex = 35;
            // 
            // DUpDelay
            // 
            this.DUpDelay.Location = new System.Drawing.Point(22, 2);
            this.DUpDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DUpDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DUpDelay.Name = "DUpDelay";
            this.DUpDelay.Size = new System.Drawing.Size(46, 20);
            this.DUpDelay.TabIndex = 47;
            this.DUpDelay.Tag = "4";
            this.DUpDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DUpDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // DUpDKPanel
            // 
            this.DUpDKPanel.Controls.Add(this.DUpDKD);
            this.DUpDKPanel.Controls.Add(this.DupDKC);
            this.DUpDKPanel.Location = new System.Drawing.Point(247, 0);
            this.DUpDKPanel.Name = "DUpDKPanel";
            this.DUpDKPanel.Size = new System.Drawing.Size(102, 25);
            this.DUpDKPanel.TabIndex = 9;
            // 
            // DUpDKD
            // 
            this.DUpDKD.AutoSize = true;
            this.DUpDKD.Location = new System.Drawing.Point(75, 4);
            this.DUpDKD.Name = "DUpDKD";
            this.DUpDKD.Size = new System.Drawing.Size(14, 13);
            this.DUpDKD.TabIndex = 1;
            this.DUpDKD.Tag = "4";
            this.DUpDKD.UseVisualStyleBackColor = true;
            this.DUpDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DupDKC
            // 
            this.DupDKC.AutoSize = true;
            this.DupDKC.Checked = true;
            this.DupDKC.Location = new System.Drawing.Point(14, 4);
            this.DupDKC.Name = "DupDKC";
            this.DupDKC.Size = new System.Drawing.Size(14, 13);
            this.DupDKC.TabIndex = 0;
            this.DupDKC.TabStop = true;
            this.DupDKC.Tag = "4";
            this.DupDKC.UseVisualStyleBackColor = true;
            this.DupDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // DUpSKPanel
            // 
            this.DUpSKPanel.Controls.Add(this.DUpSKD);
            this.DUpSKPanel.Controls.Add(this.DUpSKC);
            this.DUpSKPanel.Location = new System.Drawing.Point(104, 0);
            this.DUpSKPanel.Name = "DUpSKPanel";
            this.DUpSKPanel.Size = new System.Drawing.Size(102, 25);
            this.DUpSKPanel.TabIndex = 9;
            // 
            // DUpSKD
            // 
            this.DUpSKD.AutoSize = true;
            this.DUpSKD.Checked = true;
            this.DUpSKD.Location = new System.Drawing.Point(75, 4);
            this.DUpSKD.Name = "DUpSKD";
            this.DUpSKD.Size = new System.Drawing.Size(14, 13);
            this.DUpSKD.TabIndex = 1;
            this.DUpSKD.TabStop = true;
            this.DUpSKD.Tag = "4";
            this.DUpSKD.UseVisualStyleBackColor = true;
            this.DUpSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DUpSKC
            // 
            this.DUpSKC.AutoSize = true;
            this.DUpSKC.Location = new System.Drawing.Point(14, 4);
            this.DUpSKC.Name = "DUpSKC";
            this.DUpSKC.Size = new System.Drawing.Size(14, 13);
            this.DUpSKC.TabIndex = 0;
            this.DUpSKC.Tag = "4";
            this.DUpSKC.UseVisualStyleBackColor = true;
            this.DUpSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // DUpSDMax
            // 
            this.DUpSDMax.Location = new System.Drawing.Point(503, 2);
            this.DUpSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DUpSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DUpSDMax.Name = "DUpSDMax";
            this.DUpSDMax.Size = new System.Drawing.Size(45, 20);
            this.DUpSDMax.TabIndex = 7;
            this.DUpSDMax.Tag = "4";
            this.DUpSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DUpSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // DUpSDMin
            // 
            this.DUpSDMin.Location = new System.Drawing.Point(451, 2);
            this.DUpSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DUpSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DUpSDMin.Name = "DUpSDMin";
            this.DUpSDMin.Size = new System.Drawing.Size(46, 20);
            this.DUpSDMin.TabIndex = 6;
            this.DUpSDMin.Tag = "4";
            this.DUpSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.DUpSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // DUpSDECheckBox
            // 
            this.DUpSDECheckBox.AutoSize = true;
            this.DUpSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.DUpSDECheckBox.Name = "DUpSDECheckBox";
            this.DUpSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.DUpSDECheckBox.TabIndex = 4;
            this.DUpSDECheckBox.Tag = "4";
            this.DUpSDECheckBox.UseVisualStyleBackColor = true;
            this.DUpSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 178);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "DPad Up";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ALeftDelay);
            this.panel5.Controls.Add(this.ALeftDKPanel);
            this.panel5.Controls.Add(this.ALeftSDMax);
            this.panel5.Controls.Add(this.ALeftSDMin);
            this.panel5.Controls.Add(this.ALeftSDECheckBox);
            this.panel5.Location = new System.Drawing.Point(90, 148);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(556, 25);
            this.panel5.TabIndex = 35;
            // 
            // ALeftDelay
            // 
            this.ALeftDelay.Location = new System.Drawing.Point(22, 2);
            this.ALeftDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ALeftDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ALeftDelay.Name = "ALeftDelay";
            this.ALeftDelay.Size = new System.Drawing.Size(46, 20);
            this.ALeftDelay.TabIndex = 46;
            this.ALeftDelay.Tag = "3";
            this.ALeftDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ALeftDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // ALeftDKPanel
            // 
            this.ALeftDKPanel.Controls.Add(this.ALeftSKD);
            this.ALeftDKPanel.Controls.Add(this.ALeftSKC);
            this.ALeftDKPanel.Location = new System.Drawing.Point(104, 0);
            this.ALeftDKPanel.Name = "ALeftDKPanel";
            this.ALeftDKPanel.Size = new System.Drawing.Size(102, 25);
            this.ALeftDKPanel.TabIndex = 9;
            // 
            // ALeftSKD
            // 
            this.ALeftSKD.AutoSize = true;
            this.ALeftSKD.Checked = true;
            this.ALeftSKD.Location = new System.Drawing.Point(75, 4);
            this.ALeftSKD.Name = "ALeftSKD";
            this.ALeftSKD.Size = new System.Drawing.Size(14, 13);
            this.ALeftSKD.TabIndex = 1;
            this.ALeftSKD.TabStop = true;
            this.ALeftSKD.Tag = "3";
            this.ALeftSKD.UseVisualStyleBackColor = true;
            this.ALeftSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ALeftSKC
            // 
            this.ALeftSKC.AutoSize = true;
            this.ALeftSKC.Location = new System.Drawing.Point(14, 4);
            this.ALeftSKC.Name = "ALeftSKC";
            this.ALeftSKC.Size = new System.Drawing.Size(14, 13);
            this.ALeftSKC.TabIndex = 0;
            this.ALeftSKC.Tag = "3";
            this.ALeftSKC.UseVisualStyleBackColor = true;
            this.ALeftSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ALeftSDMax
            // 
            this.ALeftSDMax.Location = new System.Drawing.Point(503, 2);
            this.ALeftSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ALeftSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ALeftSDMax.Name = "ALeftSDMax";
            this.ALeftSDMax.Size = new System.Drawing.Size(45, 20);
            this.ALeftSDMax.TabIndex = 7;
            this.ALeftSDMax.Tag = "3";
            this.ALeftSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ALeftSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // ALeftSDMin
            // 
            this.ALeftSDMin.Location = new System.Drawing.Point(451, 2);
            this.ALeftSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ALeftSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ALeftSDMin.Name = "ALeftSDMin";
            this.ALeftSDMin.Size = new System.Drawing.Size(46, 20);
            this.ALeftSDMin.TabIndex = 6;
            this.ALeftSDMin.Tag = "3";
            this.ALeftSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ALeftSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // ALeftSDECheckBox
            // 
            this.ALeftSDECheckBox.AutoSize = true;
            this.ALeftSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.ALeftSDECheckBox.Name = "ALeftSDECheckBox";
            this.ALeftSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.ALeftSDECheckBox.TabIndex = 4;
            this.ALeftSDECheckBox.Tag = "3";
            this.ALeftSDECheckBox.UseVisualStyleBackColor = true;
            this.ALeftSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 122);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Analog Down";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ADownDelay);
            this.panel4.Controls.Add(this.ADownSKPanel);
            this.panel4.Controls.Add(this.ADownSDMax);
            this.panel4.Controls.Add(this.ADownSDMin);
            this.panel4.Controls.Add(this.ADownSDECheckBox);
            this.panel4.Location = new System.Drawing.Point(90, 120);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 25);
            this.panel4.TabIndex = 35;
            // 
            // ADownDelay
            // 
            this.ADownDelay.Location = new System.Drawing.Point(22, 2);
            this.ADownDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ADownDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADownDelay.Name = "ADownDelay";
            this.ADownDelay.Size = new System.Drawing.Size(46, 20);
            this.ADownDelay.TabIndex = 47;
            this.ADownDelay.Tag = "2";
            this.ADownDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADownDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // ADownSKPanel
            // 
            this.ADownSKPanel.Controls.Add(this.ADownSKD);
            this.ADownSKPanel.Controls.Add(this.ADownSKC);
            this.ADownSKPanel.Location = new System.Drawing.Point(104, 0);
            this.ADownSKPanel.Name = "ADownSKPanel";
            this.ADownSKPanel.Size = new System.Drawing.Size(102, 25);
            this.ADownSKPanel.TabIndex = 9;
            // 
            // ADownSKD
            // 
            this.ADownSKD.AutoSize = true;
            this.ADownSKD.Checked = true;
            this.ADownSKD.Location = new System.Drawing.Point(75, 4);
            this.ADownSKD.Name = "ADownSKD";
            this.ADownSKD.Size = new System.Drawing.Size(14, 13);
            this.ADownSKD.TabIndex = 1;
            this.ADownSKD.TabStop = true;
            this.ADownSKD.Tag = "2";
            this.ADownSKD.UseVisualStyleBackColor = true;
            this.ADownSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ADownSKC
            // 
            this.ADownSKC.AutoSize = true;
            this.ADownSKC.Location = new System.Drawing.Point(14, 4);
            this.ADownSKC.Name = "ADownSKC";
            this.ADownSKC.Size = new System.Drawing.Size(14, 13);
            this.ADownSKC.TabIndex = 0;
            this.ADownSKC.Tag = "2";
            this.ADownSKC.UseVisualStyleBackColor = true;
            this.ADownSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ADownSDMax
            // 
            this.ADownSDMax.Location = new System.Drawing.Point(503, 2);
            this.ADownSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ADownSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADownSDMax.Name = "ADownSDMax";
            this.ADownSDMax.Size = new System.Drawing.Size(45, 20);
            this.ADownSDMax.TabIndex = 7;
            this.ADownSDMax.Tag = "2";
            this.ADownSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ADownSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // ADownSDMin
            // 
            this.ADownSDMin.Location = new System.Drawing.Point(451, 2);
            this.ADownSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ADownSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADownSDMin.Name = "ADownSDMin";
            this.ADownSDMin.Size = new System.Drawing.Size(46, 20);
            this.ADownSDMin.TabIndex = 6;
            this.ADownSDMin.Tag = "2";
            this.ADownSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ADownSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // ADownSDECheckBox
            // 
            this.ADownSDECheckBox.AutoSize = true;
            this.ADownSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.ADownSDECheckBox.Name = "ADownSDECheckBox";
            this.ADownSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.ADownSDECheckBox.TabIndex = 4;
            this.ADownSDECheckBox.Tag = "2";
            this.ADownSDECheckBox.UseVisualStyleBackColor = true;
            this.ADownSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Analog Left";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ARightDelay);
            this.panel3.Controls.Add(this.ARightDKPanel);
            this.panel3.Controls.Add(this.ARightSKPanel);
            this.panel3.Controls.Add(this.ARightSDMax);
            this.panel3.Controls.Add(this.ARightSDMin);
            this.panel3.Controls.Add(this.ARightSDECheckBox);
            this.panel3.Location = new System.Drawing.Point(90, 92);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(556, 25);
            this.panel3.TabIndex = 35;
            // 
            // ARightDelay
            // 
            this.ARightDelay.Location = new System.Drawing.Point(22, 2);
            this.ARightDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ARightDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ARightDelay.Name = "ARightDelay";
            this.ARightDelay.Size = new System.Drawing.Size(46, 20);
            this.ARightDelay.TabIndex = 11;
            this.ARightDelay.Tag = "1";
            this.ARightDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ARightDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // ARightDKPanel
            // 
            this.ARightDKPanel.Controls.Add(this.ARightDKD);
            this.ARightDKPanel.Controls.Add(this.ARightDKC);
            this.ARightDKPanel.Location = new System.Drawing.Point(247, 0);
            this.ARightDKPanel.Name = "ARightDKPanel";
            this.ARightDKPanel.Size = new System.Drawing.Size(102, 25);
            this.ARightDKPanel.TabIndex = 9;
            // 
            // ARightDKD
            // 
            this.ARightDKD.AutoSize = true;
            this.ARightDKD.Location = new System.Drawing.Point(75, 4);
            this.ARightDKD.Name = "ARightDKD";
            this.ARightDKD.Size = new System.Drawing.Size(14, 13);
            this.ARightDKD.TabIndex = 1;
            this.ARightDKD.Tag = "1";
            this.ARightDKD.UseVisualStyleBackColor = true;
            this.ARightDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ARightDKC
            // 
            this.ARightDKC.AutoSize = true;
            this.ARightDKC.Checked = true;
            this.ARightDKC.Location = new System.Drawing.Point(14, 4);
            this.ARightDKC.Name = "ARightDKC";
            this.ARightDKC.Size = new System.Drawing.Size(14, 13);
            this.ARightDKC.TabIndex = 0;
            this.ARightDKC.TabStop = true;
            this.ARightDKC.Tag = "1";
            this.ARightDKC.UseVisualStyleBackColor = true;
            this.ARightDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // ARightSKPanel
            // 
            this.ARightSKPanel.Controls.Add(this.ARightSKD);
            this.ARightSKPanel.Controls.Add(this.ARightSKC);
            this.ARightSKPanel.Location = new System.Drawing.Point(104, 0);
            this.ARightSKPanel.Name = "ARightSKPanel";
            this.ARightSKPanel.Size = new System.Drawing.Size(102, 25);
            this.ARightSKPanel.TabIndex = 46;
            // 
            // ARightSKD
            // 
            this.ARightSKD.AutoSize = true;
            this.ARightSKD.Checked = true;
            this.ARightSKD.Location = new System.Drawing.Point(75, 4);
            this.ARightSKD.Name = "ARightSKD";
            this.ARightSKD.Size = new System.Drawing.Size(14, 13);
            this.ARightSKD.TabIndex = 1;
            this.ARightSKD.TabStop = true;
            this.ARightSKD.Tag = "1";
            this.ARightSKD.UseVisualStyleBackColor = true;
            this.ARightSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ARightSKC
            // 
            this.ARightSKC.AutoSize = true;
            this.ARightSKC.Location = new System.Drawing.Point(14, 4);
            this.ARightSKC.Name = "ARightSKC";
            this.ARightSKC.Size = new System.Drawing.Size(14, 13);
            this.ARightSKC.TabIndex = 0;
            this.ARightSKC.Tag = "1";
            this.ARightSKC.UseVisualStyleBackColor = true;
            this.ARightSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // ARightSDMax
            // 
            this.ARightSDMax.Location = new System.Drawing.Point(503, 2);
            this.ARightSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ARightSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ARightSDMax.Name = "ARightSDMax";
            this.ARightSDMax.Size = new System.Drawing.Size(45, 20);
            this.ARightSDMax.TabIndex = 7;
            this.ARightSDMax.Tag = "1";
            this.ARightSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ARightSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // ARightSDMin
            // 
            this.ARightSDMin.Location = new System.Drawing.Point(451, 2);
            this.ARightSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ARightSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ARightSDMin.Name = "ARightSDMin";
            this.ARightSDMin.Size = new System.Drawing.Size(46, 20);
            this.ARightSDMin.TabIndex = 6;
            this.ARightSDMin.Tag = "1";
            this.ARightSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.ARightSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // ARightSDECheckBox
            // 
            this.ARightSDECheckBox.AutoSize = true;
            this.ARightSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.ARightSDECheckBox.Name = "ARightSDECheckBox";
            this.ARightSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.ARightSDECheckBox.TabIndex = 4;
            this.ARightSDECheckBox.Tag = "1";
            this.ARightSDECheckBox.UseVisualStyleBackColor = true;
            this.ARightSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 94);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Analog Right";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AUpDelay);
            this.panel2.Controls.Add(this.AUpDKPanel);
            this.panel2.Controls.Add(this.AUpSKPanel);
            this.panel2.Controls.Add(this.AUpSDMax);
            this.panel2.Controls.Add(this.AUpSDMin);
            this.panel2.Controls.Add(this.AUpSDECheckBox);
            this.panel2.Location = new System.Drawing.Point(90, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 25);
            this.panel2.TabIndex = 33;
            // 
            // AUpDelay
            // 
            this.AUpDelay.Location = new System.Drawing.Point(22, 2);
            this.AUpDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AUpDelay.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.AUpDelay.Name = "AUpDelay";
            this.AUpDelay.Size = new System.Drawing.Size(46, 20);
            this.AUpDelay.TabIndex = 10;
            this.AUpDelay.Tag = "0";
            this.AUpDelay.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.AUpDelay.ValueChanged += new System.EventHandler(this.KPDelay_ValueChanged);
            // 
            // AUpDKPanel
            // 
            this.AUpDKPanel.Controls.Add(this.AUpDKD);
            this.AUpDKPanel.Controls.Add(this.AUpDKC);
            this.AUpDKPanel.Location = new System.Drawing.Point(247, 0);
            this.AUpDKPanel.Name = "AUpDKPanel";
            this.AUpDKPanel.Size = new System.Drawing.Size(102, 25);
            this.AUpDKPanel.TabIndex = 9;
            // 
            // AUpDKD
            // 
            this.AUpDKD.AutoSize = true;
            this.AUpDKD.Location = new System.Drawing.Point(75, 4);
            this.AUpDKD.Name = "AUpDKD";
            this.AUpDKD.Size = new System.Drawing.Size(14, 13);
            this.AUpDKD.TabIndex = 1;
            this.AUpDKD.Tag = "0";
            this.AUpDKD.UseVisualStyleBackColor = true;
            this.AUpDKD.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // AUpDKC
            // 
            this.AUpDKC.AutoSize = true;
            this.AUpDKC.Checked = true;
            this.AUpDKC.Location = new System.Drawing.Point(14, 4);
            this.AUpDKC.Name = "AUpDKC";
            this.AUpDKC.Size = new System.Drawing.Size(14, 13);
            this.AUpDKC.TabIndex = 0;
            this.AUpDKC.TabStop = true;
            this.AUpDKC.Tag = "0";
            this.AUpDKC.UseVisualStyleBackColor = true;
            this.AUpDKC.CheckedChanged += new System.EventHandler(this.DKRadioButton_CheckedChanged);
            // 
            // AUpSKPanel
            // 
            this.AUpSKPanel.Controls.Add(this.AUpSKD);
            this.AUpSKPanel.Controls.Add(this.AUpSKC);
            this.AUpSKPanel.Location = new System.Drawing.Point(104, 0);
            this.AUpSKPanel.Name = "AUpSKPanel";
            this.AUpSKPanel.Size = new System.Drawing.Size(102, 25);
            this.AUpSKPanel.TabIndex = 8;
            // 
            // AUpSKD
            // 
            this.AUpSKD.AutoSize = true;
            this.AUpSKD.Checked = true;
            this.AUpSKD.Location = new System.Drawing.Point(75, 4);
            this.AUpSKD.Name = "AUpSKD";
            this.AUpSKD.Size = new System.Drawing.Size(14, 13);
            this.AUpSKD.TabIndex = 1;
            this.AUpSKD.TabStop = true;
            this.AUpSKD.Tag = "0";
            this.AUpSKD.UseVisualStyleBackColor = true;
            this.AUpSKD.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // AUpSKC
            // 
            this.AUpSKC.AutoSize = true;
            this.AUpSKC.Location = new System.Drawing.Point(14, 4);
            this.AUpSKC.Name = "AUpSKC";
            this.AUpSKC.Size = new System.Drawing.Size(14, 13);
            this.AUpSKC.TabIndex = 0;
            this.AUpSKC.Tag = "0";
            this.AUpSKC.UseVisualStyleBackColor = true;
            this.AUpSKC.CheckedChanged += new System.EventHandler(this.SKRadioButton_CheckedChanged);
            // 
            // AUpSDMax
            // 
            this.AUpSDMax.Location = new System.Drawing.Point(503, 2);
            this.AUpSDMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AUpSDMax.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.AUpSDMax.Name = "AUpSDMax";
            this.AUpSDMax.Size = new System.Drawing.Size(45, 20);
            this.AUpSDMax.TabIndex = 7;
            this.AUpSDMax.Tag = "0";
            this.AUpSDMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AUpSDMax.ValueChanged += new System.EventHandler(this.ScalingMax_ValueChanged);
            // 
            // AUpSDMin
            // 
            this.AUpSDMin.Location = new System.Drawing.Point(451, 2);
            this.AUpSDMin.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.AUpSDMin.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.AUpSDMin.Name = "AUpSDMin";
            this.AUpSDMin.Size = new System.Drawing.Size(46, 20);
            this.AUpSDMin.TabIndex = 6;
            this.AUpSDMin.Tag = "0";
            this.AUpSDMin.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.AUpSDMin.ValueChanged += new System.EventHandler(this.ScalingMin_ValueChanged);
            // 
            // AUpSDECheckBox
            // 
            this.AUpSDECheckBox.AutoSize = true;
            this.AUpSDECheckBox.Location = new System.Drawing.Point(423, 5);
            this.AUpSDECheckBox.Name = "AUpSDECheckBox";
            this.AUpSDECheckBox.Size = new System.Drawing.Size(15, 14);
            this.AUpSDECheckBox.TabIndex = 4;
            this.AUpSDECheckBox.Tag = "0";
            this.AUpSDECheckBox.UseVisualStyleBackColor = true;
            this.AUpSDECheckBox.CheckedChanged += new System.EventHandler(this.ScalingCheckBox_CheckedChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(489, 45);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(46, 13);
            this.label36.TabIndex = 32;
            this.label36.Text = "Enabled";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(591, 45);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(27, 13);
            this.label35.TabIndex = 31;
            this.label35.Text = "Max";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(544, 45);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(24, 13);
            this.label34.TabIndex = 30;
            this.label34.Text = "Min";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(529, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(72, 13);
            this.label33.TabIndex = 29;
            this.label33.Text = "Scaling Delay";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(394, 45);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(42, 13);
            this.label30.TabIndex = 28;
            this.label30.Text = "Distinct";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(331, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 13);
            this.label31.TabIndex = 27;
            this.label31.Text = "Combine";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(350, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 13);
            this.label32.TabIndex = 26;
            this.label32.Text = "Different Keys";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(251, 45);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 13);
            this.label29.TabIndex = 25;
            this.label29.Text = "Distinct";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(188, 45);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 24;
            this.label28.Text = "Combine";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(211, 32);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 23;
            this.label27.Text = "Same Keys";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(118, 45);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 13);
            this.label26.TabIndex = 22;
            this.label26.Text = "Delay";
            // 
            // SaveKPPFileButton
            // 
            this.SaveKPPFileButton.Location = new System.Drawing.Point(574, 4);
            this.SaveKPPFileButton.Name = "SaveKPPFileButton";
            this.SaveKPPFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveKPPFileButton.TabIndex = 4;
            this.SaveKPPFileButton.Text = "Save";
            this.SaveKPPFileButton.UseVisualStyleBackColor = true;
            this.SaveKPPFileButton.Click += new System.EventHandler(this.SaveKPPFileButton_Click);
            // 
            // SaveAsKPPFileButton
            // 
            this.SaveAsKPPFileButton.Location = new System.Drawing.Point(493, 4);
            this.SaveAsKPPFileButton.Name = "SaveAsKPPFileButton";
            this.SaveAsKPPFileButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAsKPPFileButton.TabIndex = 3;
            this.SaveAsKPPFileButton.Text = "Save As...";
            this.SaveAsKPPFileButton.UseVisualStyleBackColor = true;
            this.SaveAsKPPFileButton.Click += new System.EventHandler(this.SaveAsKPPFileButton_Click);
            // 
            // LoadKPPFileButton
            // 
            this.LoadKPPFileButton.Location = new System.Drawing.Point(412, 4);
            this.LoadKPPFileButton.Name = "LoadKPPFileButton";
            this.LoadKPPFileButton.Size = new System.Drawing.Size(75, 23);
            this.LoadKPPFileButton.TabIndex = 2;
            this.LoadKPPFileButton.Text = "Load";
            this.LoadKPPFileButton.UseVisualStyleBackColor = true;
            this.LoadKPPFileButton.Click += new System.EventHandler(this.LoadKPPFileButton_Click);
            // 
            // RecentKPPFiles
            // 
            this.RecentKPPFiles.FormattingEnabled = true;
            this.RecentKPPFiles.Location = new System.Drawing.Point(17, 6);
            this.RecentKPPFiles.MaxDropDownItems = 32;
            this.RecentKPPFiles.Name = "RecentKPPFiles";
            this.RecentKPPFiles.Size = new System.Drawing.Size(389, 21);
            this.RecentKPPFiles.Sorted = true;
            this.RecentKPPFiles.TabIndex = 1;
            this.RecentKPPFiles.SelectedIndexChanged += new System.EventHandler(this.RecentKPPFiles_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Analog Up";
            // 
            // LoadKPPFileDialog
            // 
            this.LoadKPPFileDialog.DefaultExt = "kpp";
            this.LoadKPPFileDialog.Filter = "Key Press Profiles|*.kpp";
            this.LoadKPPFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "Key\\Profiles\\";
            this.LoadKPPFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadKPPFileDialog_FileOk);
            // 
            // SaveKPPFileDialog
            // 
            this.SaveKPPFileDialog.DefaultExt = "kpp";
            this.SaveKPPFileDialog.FileName = "default.kpp";
            this.SaveKPPFileDialog.Filter = "Key Press Profile (*.kpp)|*.kpp|All Files|*.*";
            this.SaveKPPFileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "Key\\Profiles\\";
            this.SaveKPPFileDialog.RestoreDirectory = true;
            this.SaveKPPFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveKPPFileDialog_FileOk);
            // 
            // RetroBotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxComboSetter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurrentGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RetroBotForm";
            this.Text = "RetroBot";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxComboSetter)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ControllerSettingsTab.ResumeLayout(false);
            this.ControllerSettingsTab.PerformLayout();
            this.Player4GroupBox.ResumeLayout(false);
            this.Player4GroupBox.PerformLayout();
            this.Player4RBPanel.ResumeLayout(false);
            this.Player4RBPanel.PerformLayout();
            this.Player3GroupBox.ResumeLayout(false);
            this.Player3GroupBox.PerformLayout();
            this.Player3RBPanel.ResumeLayout(false);
            this.Player3RBPanel.PerformLayout();
            this.Player2GroupBox.ResumeLayout(false);
            this.Player2GroupBox.PerformLayout();
            this.Player2RBPanel.ResumeLayout(false);
            this.Player2RBPanel.PerformLayout();
            this.Player1GroupBox.ResumeLayout(false);
            this.Player1GroupBox.PerformLayout();
            this.Player1RBPanel.ResumeLayout(false);
            this.Player1RBPanel.PerformLayout();
            this.KeyControlsGroup.ResumeLayout(false);
            this.KeyControlsGroup.PerformLayout();
            this.KeyControlsPanel.ResumeLayout(false);
            this.KeyControlsPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.BSKPanel.ResumeLayout(false);
            this.BSKPanel.PerformLayout();
            this.CLeftDKPanel.ResumeLayout(false);
            this.CLeftDKPanel.PerformLayout();
            this.CDownDKPanel.ResumeLayout(false);
            this.CDownDKPanel.PerformLayout();
            this.CRightSKPanel.ResumeLayout(false);
            this.CRightSKPanel.PerformLayout();
            this.DLeftDKPanel.ResumeLayout(false);
            this.DLeftDKPanel.PerformLayout();
            this.DDownDKPanel.ResumeLayout(false);
            this.DDownDKPanel.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ADownDKPanel.ResumeLayout(false);
            this.ADownDKPanel.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BDelay)).EndInit();
            this.BDKPanel.ResumeLayout(false);
            this.BDKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDMin)).EndInit();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.RTriggerDKPanel.ResumeLayout(false);
            this.RTriggerDKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTriggerDelay)).EndInit();
            this.RTriggerSKPanel.ResumeLayout(false);
            this.RTriggerSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RTriggerSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTriggerSDMin)).EndInit();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADelay)).EndInit();
            this.ADKPanel.ResumeLayout(false);
            this.ADKPanel.PerformLayout();
            this.ASKPanel.ResumeLayout(false);
            this.ASKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ASDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ASDMin)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLeftDelay)).EndInit();
            this.CLeftSKPanel.ResumeLayout(false);
            this.CLeftSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CLeftSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CLeftSDMin)).EndInit();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartDelay)).EndInit();
            this.StartDKPanel.ResumeLayout(false);
            this.StartDKPanel.PerformLayout();
            this.StartSKPanel.ResumeLayout(false);
            this.StartSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartSDMin)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDownDelay)).EndInit();
            this.CDownSKPanel.ResumeLayout(false);
            this.CDownSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CDownSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CDownSDMin)).EndInit();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZTriggerDelay)).EndInit();
            this.ZTriggerDKPanel.ResumeLayout(false);
            this.ZTriggerDKPanel.PerformLayout();
            this.ZTriggerSKPanel.ResumeLayout(false);
            this.ZTriggerSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZTriggerSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTriggerSDMin)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CRightDelay)).EndInit();
            this.CRightDKPanel.ResumeLayout(false);
            this.CRightDKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CRightSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRightSDMin)).EndInit();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTriggerDelay)).EndInit();
            this.LTriggerDKPanel.ResumeLayout(false);
            this.LTriggerDKPanel.PerformLayout();
            this.LTriggerSKPanel.ResumeLayout(false);
            this.LTriggerSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LTriggerSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LTriggerSDMin)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUpDelay)).EndInit();
            this.CUpDKPanel.ResumeLayout(false);
            this.CUpDKPanel.PerformLayout();
            this.CUpSKPanel.ResumeLayout(false);
            this.CUpSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CUpSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CUpSDMin)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DLeftDelay)).EndInit();
            this.DLeftSKPanel.ResumeLayout(false);
            this.DLeftSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DLeftSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DLeftSDMin)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DDownDelay)).EndInit();
            this.DDownSKPanel.ResumeLayout(false);
            this.DDownSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DDownSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DDownSDMin)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DRightDelay)).EndInit();
            this.DRightDKPanel.ResumeLayout(false);
            this.DRightDKPanel.PerformLayout();
            this.DRightSKPanel.ResumeLayout(false);
            this.DRightSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DRightSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DRightSDMin)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DUpDelay)).EndInit();
            this.DUpDKPanel.ResumeLayout(false);
            this.DUpDKPanel.PerformLayout();
            this.DUpSKPanel.ResumeLayout(false);
            this.DUpSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DUpSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DUpSDMin)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALeftDelay)).EndInit();
            this.ALeftDKPanel.ResumeLayout(false);
            this.ALeftDKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ALeftSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ALeftSDMin)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADownDelay)).EndInit();
            this.ADownSKPanel.ResumeLayout(false);
            this.ADownSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADownSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ADownSDMin)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARightDelay)).EndInit();
            this.ARightDKPanel.ResumeLayout(false);
            this.ARightDKPanel.PerformLayout();
            this.ARightSKPanel.ResumeLayout(false);
            this.ARightSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ARightSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ARightSDMin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUpDelay)).EndInit();
            this.AUpDKPanel.ResumeLayout(false);
            this.AUpDKPanel.PerformLayout();
            this.AUpSKPanel.ResumeLayout(false);
            this.AUpSKPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AUpSDMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AUpSDMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker RetroBotIRCWorker;
        private System.ComponentModel.BackgroundWorker Player1ProcessorWorker;
        private System.ComponentModel.BackgroundWorker Player2ProcessorWorker;
        private System.ComponentModel.BackgroundWorker Player3ProcessorWorker;
        private System.ComponentModel.BackgroundWorker Player4ProcessorWorker;
        private System.Windows.Forms.ComboBox CurrentGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Player2InputLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Player3InputLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Player1InputLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Player4InputLabel;
        private System.Windows.Forms.ListBox CommandInfoWindow;
        private System.Windows.Forms.NumericUpDown MaxComboSetter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ControllerSettingsTab;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DefaultPlayerComboBox;
        private System.Windows.Forms.CheckBox RandomAssignmentCheckBox;
        private System.Windows.Forms.GroupBox Player4GroupBox;
        private System.Windows.Forms.Button SavePlayer4GuestListButton;
        private System.Windows.Forms.Button Player4PauseButton;
        private System.Windows.Forms.TextBox Player4GuestList;
        private System.Windows.Forms.Panel Player4RBPanel;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.GroupBox Player3GroupBox;
        private System.Windows.Forms.Button SavePlayer3GuestListButton;
        private System.Windows.Forms.Button Player3PauseButton;
        private System.Windows.Forms.TextBox Player3GuestList;
        private System.Windows.Forms.Panel Player3RBPanel;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.GroupBox Player2GroupBox;
        private System.Windows.Forms.Button SavePlayer2GuestListButton;
        private System.Windows.Forms.Button Player2PauseButton;
        private System.Windows.Forms.TextBox Player2GuestList;
        private System.Windows.Forms.Panel Player2RBPanel;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.Button PauseAllButton;
        private System.Windows.Forms.GroupBox Player1GroupBox;
        private System.Windows.Forms.Button SavePlayer1GuestListButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Player1PauseButton;
        private System.Windows.Forms.TextBox Player1GuestList;
        private System.Windows.Forms.Panel Player1RBPanel;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox KeyControlsGroup;
        private System.Windows.Forms.Panel KeyControlsPanel;
        private System.Windows.Forms.CheckBox BEnabled;
        private System.Windows.Forms.CheckBox AnalogLeftEnabled;
        private System.Windows.Forms.CheckBox StartEnabled;
        private System.Windows.Forms.CheckBox ZTriggerEnabled;
        private System.Windows.Forms.CheckBox LTriggerEnabled;
        private System.Windows.Forms.CheckBox RTriggerEnabled;
        private System.Windows.Forms.CheckBox CLeftEnabled;
        private System.Windows.Forms.CheckBox CDownEnabled;
        private System.Windows.Forms.CheckBox CRightEnabled;
        private System.Windows.Forms.CheckBox CUpEnabled;
        private System.Windows.Forms.CheckBox AEnabled;
        private System.Windows.Forms.CheckBox DPadLeftEnabled;
        private System.Windows.Forms.CheckBox DPadDownEnabled;
        private System.Windows.Forms.CheckBox DPadRightEnabled;
        private System.Windows.Forms.CheckBox DPadUpEnabled;
        private System.Windows.Forms.CheckBox AnalogDownEnabled;
        private System.Windows.Forms.CheckBox AnalogRightEnabled;
        private System.Windows.Forms.CheckBox AnalogUpEnabled;
        private System.Windows.Forms.CheckBox AllControlsEnabled;
        private System.Windows.Forms.ComboBox KeyControlTarget;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button KeyControlsSaveButton;
        private System.Windows.Forms.Button KeyControlsLoadButton;
        private System.Windows.Forms.OpenFileDialog LoadKPPFileDialog;
        private System.Windows.Forms.SaveFileDialog SaveKPPFileDialog;
        private System.Windows.Forms.Button SaveKPPFileButton;
        private System.Windows.Forms.Button SaveAsKPPFileButton;
        private System.Windows.Forms.Button LoadKPPFileButton;
        private System.Windows.Forms.ComboBox RecentKPPFiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox AUpSDECheckBox;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.NumericUpDown BSDMax;
        private System.Windows.Forms.NumericUpDown BSDMin;
        private System.Windows.Forms.CheckBox BSDECheckBox;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.NumericUpDown RTriggerSDMax;
        private System.Windows.Forms.NumericUpDown RTriggerSDMin;
        private System.Windows.Forms.CheckBox RTriggerSDECheckBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.NumericUpDown ASDMax;
        private System.Windows.Forms.NumericUpDown ASDMin;
        private System.Windows.Forms.CheckBox ASDECheckBox;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.NumericUpDown CLeftSDMax;
        private System.Windows.Forms.NumericUpDown CLeftSDMin;
        private System.Windows.Forms.CheckBox CLeftSDECheckBox;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.NumericUpDown StartSDMax;
        private System.Windows.Forms.NumericUpDown StartSDMin;
        private System.Windows.Forms.CheckBox StartSDECheckBox;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.NumericUpDown CDownSDMax;
        private System.Windows.Forms.NumericUpDown CDownSDMin;
        private System.Windows.Forms.CheckBox CDownSDECheckBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.NumericUpDown ZTriggerSDMax;
        private System.Windows.Forms.NumericUpDown ZTriggerSDMin;
        private System.Windows.Forms.CheckBox ZTriggerSDECheckBox;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown CRightSDMax;
        private System.Windows.Forms.NumericUpDown CRightSDMin;
        private System.Windows.Forms.CheckBox CRightSDECheckBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.NumericUpDown LTriggerSDMax;
        private System.Windows.Forms.NumericUpDown LTriggerSDMin;
        private System.Windows.Forms.CheckBox LTriggerSDECheckBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.NumericUpDown CUpSDMax;
        private System.Windows.Forms.NumericUpDown CUpSDMin;
        private System.Windows.Forms.CheckBox CUpSDECheckBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown DLeftSDMax;
        private System.Windows.Forms.NumericUpDown DLeftSDMin;
        private System.Windows.Forms.CheckBox DLeftSDECheckBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown DDownSDMax;
        private System.Windows.Forms.NumericUpDown DDownSDMin;
        private System.Windows.Forms.CheckBox DDownSDECheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown DRightSDMax;
        private System.Windows.Forms.NumericUpDown DRightSDMin;
        private System.Windows.Forms.CheckBox DRightSDECheckBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown DUpSDMax;
        private System.Windows.Forms.NumericUpDown DUpSDMin;
        private System.Windows.Forms.CheckBox DUpSDECheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown ALeftSDMax;
        private System.Windows.Forms.NumericUpDown ALeftSDMin;
        private System.Windows.Forms.CheckBox ALeftSDECheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown ADownSDMax;
        private System.Windows.Forms.NumericUpDown ADownSDMin;
        private System.Windows.Forms.CheckBox ADownSDECheckBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown ARightSDMax;
        private System.Windows.Forms.NumericUpDown ARightSDMin;
        private System.Windows.Forms.CheckBox ARightSDECheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown AUpSDMax;
        private System.Windows.Forms.NumericUpDown AUpSDMin;
        private System.Windows.Forms.Panel BSKPanel;
        private System.Windows.Forms.RadioButton BSKD;
        private System.Windows.Forms.RadioButton BSKC;
        private System.Windows.Forms.Panel CLeftDKPanel;
        private System.Windows.Forms.RadioButton CLeftDKD;
        private System.Windows.Forms.RadioButton CLeftDKC;
        private System.Windows.Forms.Panel CDownDKPanel;
        private System.Windows.Forms.RadioButton CDownDKD;
        private System.Windows.Forms.RadioButton CDownDKC;
        private System.Windows.Forms.Panel CRightSKPanel;
        private System.Windows.Forms.RadioButton CRightSKD;
        private System.Windows.Forms.RadioButton CRightSKC;
        private System.Windows.Forms.Panel DLeftDKPanel;
        private System.Windows.Forms.RadioButton DLeftDKD;
        private System.Windows.Forms.RadioButton DLeftDKC;
        private System.Windows.Forms.Panel DDownDKPanel;
        private System.Windows.Forms.RadioButton DDownDKD;
        private System.Windows.Forms.RadioButton DDownDKC;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.RadioButton ALeftDKD;
        private System.Windows.Forms.RadioButton ALeftDKC;
        private System.Windows.Forms.Panel ADownDKPanel;
        private System.Windows.Forms.RadioButton ADownDKD;
        private System.Windows.Forms.RadioButton ADownDKC;
        private System.Windows.Forms.Panel BDKPanel;
        private System.Windows.Forms.RadioButton BDKD;
        private System.Windows.Forms.RadioButton BDKC;
        private System.Windows.Forms.Panel RTriggerDKPanel;
        private System.Windows.Forms.RadioButton RTriggerDKD;
        private System.Windows.Forms.RadioButton RTriggerDKC;
        private System.Windows.Forms.Panel RTriggerSKPanel;
        private System.Windows.Forms.RadioButton RTriggerSKD;
        private System.Windows.Forms.RadioButton RTriggerSKC;
        private System.Windows.Forms.Panel ADKPanel;
        private System.Windows.Forms.RadioButton ADKD;
        private System.Windows.Forms.RadioButton ADKC;
        private System.Windows.Forms.Panel ASKPanel;
        private System.Windows.Forms.RadioButton ASKD;
        private System.Windows.Forms.RadioButton ASKC;
        private System.Windows.Forms.Panel CLeftSKPanel;
        private System.Windows.Forms.RadioButton CLeftSKD;
        private System.Windows.Forms.RadioButton CLeftSKC;
        private System.Windows.Forms.Panel StartDKPanel;
        private System.Windows.Forms.RadioButton StartDKD;
        private System.Windows.Forms.RadioButton StartDKC;
        private System.Windows.Forms.Panel StartSKPanel;
        private System.Windows.Forms.RadioButton StartSKD;
        private System.Windows.Forms.RadioButton StartSKC;
        private System.Windows.Forms.Panel CDownSKPanel;
        private System.Windows.Forms.RadioButton CDownSKD;
        private System.Windows.Forms.RadioButton CDownSKC;
        private System.Windows.Forms.Panel ZTriggerDKPanel;
        private System.Windows.Forms.RadioButton ZTriggerDKD;
        private System.Windows.Forms.RadioButton ZTriggerDKC;
        private System.Windows.Forms.Panel ZTriggerSKPanel;
        private System.Windows.Forms.RadioButton ZTriggerSKD;
        private System.Windows.Forms.RadioButton ZTriggerSKC;
        private System.Windows.Forms.Panel CRightDKPanel;
        private System.Windows.Forms.RadioButton CRightDKD;
        private System.Windows.Forms.RadioButton CRightDKC;
        private System.Windows.Forms.Panel LTriggerDKPanel;
        private System.Windows.Forms.RadioButton LTriggerDKD;
        private System.Windows.Forms.RadioButton LTriggerDKC;
        private System.Windows.Forms.Panel LTriggerSKPanel;
        private System.Windows.Forms.RadioButton LTriggerSKD;
        private System.Windows.Forms.RadioButton LTriggerSKC;
        private System.Windows.Forms.Panel CUpDKPanel;
        private System.Windows.Forms.RadioButton CUpDKD;
        private System.Windows.Forms.RadioButton CUpDKC;
        private System.Windows.Forms.Panel CUpSKPanel;
        private System.Windows.Forms.RadioButton CUpSKD;
        private System.Windows.Forms.RadioButton CUpSKC;
        private System.Windows.Forms.Panel DLeftSKPanel;
        private System.Windows.Forms.RadioButton DLeftSKD;
        private System.Windows.Forms.RadioButton DLeftSKC;
        private System.Windows.Forms.Panel DDownSKPanel;
        private System.Windows.Forms.RadioButton DDownSKD;
        private System.Windows.Forms.RadioButton DDownSKC;
        private System.Windows.Forms.Panel DRightDKPanel;
        private System.Windows.Forms.RadioButton DRightDKD;
        private System.Windows.Forms.RadioButton DRightDKC;
        private System.Windows.Forms.Panel DRightSKPanel;
        private System.Windows.Forms.RadioButton DRightSKD;
        private System.Windows.Forms.RadioButton DRightSKC;
        private System.Windows.Forms.Panel DUpDKPanel;
        private System.Windows.Forms.RadioButton DUpDKD;
        private System.Windows.Forms.RadioButton DupDKC;
        private System.Windows.Forms.Panel DUpSKPanel;
        private System.Windows.Forms.RadioButton DUpSKD;
        private System.Windows.Forms.RadioButton DUpSKC;
        private System.Windows.Forms.Panel ALeftDKPanel;
        private System.Windows.Forms.RadioButton ALeftSKD;
        private System.Windows.Forms.RadioButton ALeftSKC;
        private System.Windows.Forms.Panel ADownSKPanel;
        private System.Windows.Forms.RadioButton ADownSKD;
        private System.Windows.Forms.RadioButton ADownSKC;
        private System.Windows.Forms.Panel ARightDKPanel;
        private System.Windows.Forms.RadioButton ARightDKD;
        private System.Windows.Forms.RadioButton ARightDKC;
        private System.Windows.Forms.Panel ARightSKPanel;
        private System.Windows.Forms.RadioButton ARightSKD;
        private System.Windows.Forms.RadioButton ARightSKC;
        private System.Windows.Forms.Panel AUpDKPanel;
        private System.Windows.Forms.RadioButton AUpDKD;
        private System.Windows.Forms.RadioButton AUpDKC;
        private System.Windows.Forms.Panel AUpSKPanel;
        private System.Windows.Forms.RadioButton AUpSKD;
        private System.Windows.Forms.RadioButton AUpSKC;
        private System.Windows.Forms.NumericUpDown BDelay;
        private System.Windows.Forms.NumericUpDown RTriggerDelay;
        private System.Windows.Forms.NumericUpDown ADelay;
        private System.Windows.Forms.NumericUpDown CLeftDelay;
        private System.Windows.Forms.NumericUpDown StartDelay;
        private System.Windows.Forms.NumericUpDown CDownDelay;
        private System.Windows.Forms.NumericUpDown ZTriggerDelay;
        private System.Windows.Forms.NumericUpDown CRightDelay;
        private System.Windows.Forms.NumericUpDown LTriggerDelay;
        private System.Windows.Forms.NumericUpDown CUpDelay;
        private System.Windows.Forms.NumericUpDown DLeftDelay;
        private System.Windows.Forms.NumericUpDown DDownDelay;
        private System.Windows.Forms.NumericUpDown DRightDelay;
        private System.Windows.Forms.NumericUpDown DUpDelay;
        private System.Windows.Forms.NumericUpDown ALeftDelay;
        private System.Windows.Forms.NumericUpDown ADownDelay;
        private System.Windows.Forms.NumericUpDown ARightDelay;
        private System.Windows.Forms.NumericUpDown AUpDelay;
    }
}