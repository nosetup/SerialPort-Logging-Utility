namespace LogTerminal
{
  partial class FrmTerminal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTerminal));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timerScript = new System.Windows.Forms.Timer(this.components);
            this.timerAutoReply = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MenuStripTerminal = new System.Windows.Forms.MenuStrip();
            this.TsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ethernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslConnectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnTVControls = new System.Windows.Forms.ToolStripButton();
            this.tsbtnRSLKRobot = new System.Windows.Forms.ToolStripButton();
            this.TsbtnClearConsole = new System.Windows.Forms.ToolStripButton();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BtnSideLogWindow = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSideCapture = new System.Windows.Forms.Button();
            this.BtnTestHide = new System.Windows.Forms.Button();
            this.BtnSideInfo = new System.Windows.Forms.Button();
            this.BtnSideUtilities = new System.Windows.Forms.Button();
            this.BtnSideTesting = new System.Windows.Forms.Button();
            this.BtnSideAutomate = new System.Windows.Forms.Button();
            this.BtnSideSettings = new System.Windows.Forms.Button();
            this.MenuStripTerminal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.ToolStripButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerScript
            // 
            this.timerScript.Interval = 1000;
            this.timerScript.Tick += new System.EventHandler(this.TimerScript_Tick);
            // 
            // timerAutoReply
            // 
            this.timerAutoReply.Interval = 1000;
            // 
            // MenuStripTerminal
            // 
            this.MenuStripTerminal.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MenuStripTerminal.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStripTerminal.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStripTerminal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiFile,
            this.TsmiHelp});
            this.MenuStripTerminal.Location = new System.Drawing.Point(0, 0);
            this.MenuStripTerminal.Name = "MenuStripTerminal";
            this.MenuStripTerminal.Size = new System.Drawing.Size(952, 33);
            this.MenuStripTerminal.TabIndex = 22;
            this.MenuStripTerminal.Text = "menuStripTerminal";
            // 
            // TsmiFile
            // 
            this.TsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.TsmiFileExit});
            this.TsmiFile.Name = "TsmiFile";
            this.TsmiFile.Size = new System.Drawing.Size(54, 29);
            this.TsmiFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // TsmiFileExit
            // 
            this.TsmiFileExit.Name = "TsmiFileExit";
            this.TsmiFileExit.Size = new System.Drawing.Size(141, 34);
            this.TsmiFileExit.Text = "Exit";
            this.TsmiFileExit.Click += new System.EventHandler(this.TsmiFileExit_Click);
            // 
            // TsmiHelp
            // 
            this.TsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiHelpAbout});
            this.TsmiHelp.Name = "TsmiHelp";
            this.TsmiHelp.Size = new System.Drawing.Size(65, 29);
            this.TsmiHelp.Text = "Help";
            // 
            // TsmiHelpAbout
            // 
            this.TsmiHelpAbout.Name = "TsmiHelpAbout";
            this.TsmiHelpAbout.Size = new System.Drawing.Size(164, 34);
            this.TsmiHelpAbout.Text = "About";
            this.TsmiHelpAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.connectToolStripMenuItem1,
            this.disconnectToolStripMenuItem1});
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.connectToolStripMenuItem1.Text = "Connect";
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(201, 34);
            this.disconnectToolStripMenuItem1.Text = "Disconnect";
            // 
            // ethernetToolStripMenuItem
            // 
            this.ethernetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.ethernetToolStripMenuItem.Name = "ethernetToolStripMenuItem";
            this.ethernetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ethernetToolStripMenuItem.Text = "Ethernet";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.connectToolStripMenuItem.Text = "Connect";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslInfo,
            this.tsslConnectionStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 572);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(952, 26);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsslInfo
            // 
            this.TsslInfo.Font = new System.Drawing.Font("Calibri", 8F);
            this.TsslInfo.Name = "TsslInfo";
            this.TsslInfo.Size = new System.Drawing.Size(130, 19);
            this.TsslInfo.Text = "Connection Status:";
            // 
            // tsslConnectionStatus
            // 
            this.tsslConnectionStatus.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslConnectionStatus.Name = "tsslConnectionStatus";
            this.tsslConnectionStatus.Size = new System.Drawing.Size(97, 19);
            this.tsslConnectionStatus.Text = "Disconnected";
            // 
            // ToolStripButtons
            // 
            this.ToolStripButtons.BackColor = System.Drawing.Color.AliceBlue;
            this.ToolStripButtons.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripLabel1,
            this.tsbtnConnect,
            this.tsbtnDisconnect,
            this.toolStripSeparator7,
            this.toolStripLabel2,
            this.tsbtnTVControls,
            this.tsbtnRSLKRobot,
            this.TsbtnClearConsole});
            this.ToolStripButtons.Location = new System.Drawing.Point(0, 33);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStripButtons.Size = new System.Drawing.Size(952, 33);
            this.ToolStripButtons.TabIndex = 25;
            this.ToolStripButtons.Text = "toolStrip1";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 28);
            this.toolStripLabel1.Text = "Serial Port";
            // 
            // tsbtnConnect
            // 
            this.tsbtnConnect.BackColor = System.Drawing.SystemColors.Control;
            this.tsbtnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnConnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnConnect.Image")));
            this.tsbtnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConnect.Name = "tsbtnConnect";
            this.tsbtnConnect.Size = new System.Drawing.Size(34, 28);
            this.tsbtnConnect.Text = "Connect";
            this.tsbtnConnect.Click += new System.EventHandler(this.TsbtnConnect_Click);
            // 
            // tsbtnDisconnect
            // 
            this.tsbtnDisconnect.BackColor = System.Drawing.SystemColors.Control;
            this.tsbtnDisconnect.Checked = true;
            this.tsbtnDisconnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbtnDisconnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDisconnect.Image")));
            this.tsbtnDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDisconnect.Name = "tsbtnDisconnect";
            this.tsbtnDisconnect.Size = new System.Drawing.Size(34, 28);
            this.tsbtnDisconnect.Text = "Disconnect";
            this.tsbtnDisconnect.Click += new System.EventHandler(this.TsbtnDisconnect_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(128, 28);
            this.toolStripLabel2.Text = "Show Controls";
            // 
            // tsbtnTVControls
            // 
            this.tsbtnTVControls.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnTVControls.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTVControls.Image")));
            this.tsbtnTVControls.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTVControls.Name = "tsbtnTVControls";
            this.tsbtnTVControls.Size = new System.Drawing.Size(34, 28);
            this.tsbtnTVControls.Text = "Show TV Controls";
            this.tsbtnTVControls.Click += new System.EventHandler(this.TsbtnTVControls_Click);
            // 
            // tsbtnRSLKRobot
            // 
            this.tsbtnRSLKRobot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRSLKRobot.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRSLKRobot.Image")));
            this.tsbtnRSLKRobot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRSLKRobot.Name = "tsbtnRSLKRobot";
            this.tsbtnRSLKRobot.Size = new System.Drawing.Size(34, 28);
            this.tsbtnRSLKRobot.Text = "RSLK Robot";
            // 
            // TsbtnClearConsole
            // 
            this.TsbtnClearConsole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsbtnClearConsole.Image = ((System.Drawing.Image)(resources.GetObject("TsbtnClearConsole.Image")));
            this.TsbtnClearConsole.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbtnClearConsole.Name = "TsbtnClearConsole";
            this.TsbtnClearConsole.Size = new System.Drawing.Size(34, 28);
            this.TsbtnClearConsole.Text = "Add space to Trace Output";
            this.TsbtnClearConsole.Click += new System.EventHandler(this.TsbtnClearConsole_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BtnSideLogWindow
            // 
            this.BtnSideLogWindow.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BtnSideLogWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideLogWindow.BackgroundImage")));
            this.BtnSideLogWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideLogWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideLogWindow.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideLogWindow.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideLogWindow.Location = new System.Drawing.Point(0, 70);
            this.BtnSideLogWindow.Name = "BtnSideLogWindow";
            this.BtnSideLogWindow.Size = new System.Drawing.Size(180, 58);
            this.BtnSideLogWindow.TabIndex = 0;
            this.BtnSideLogWindow.Text = "Log Window";
            this.BtnSideLogWindow.UseVisualStyleBackColor = false;
            this.BtnSideLogWindow.Click += new System.EventHandler(this.BtnLogWindow_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.BtnSideCapture);
            this.panel1.Controls.Add(this.BtnTestHide);
            this.panel1.Controls.Add(this.BtnSideInfo);
            this.panel1.Controls.Add(this.BtnSideUtilities);
            this.panel1.Controls.Add(this.BtnSideTesting);
            this.panel1.Controls.Add(this.BtnSideAutomate);
            this.panel1.Controls.Add(this.BtnSideSettings);
            this.panel1.Controls.Add(this.BtnSideLogWindow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 506);
            this.panel1.TabIndex = 31;
            // 
            // BtnSideCapture
            // 
            this.BtnSideCapture.BackColor = System.Drawing.Color.DarkMagenta;
            this.BtnSideCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideCapture.BackgroundImage")));
            this.BtnSideCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideCapture.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideCapture.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideCapture.Location = new System.Drawing.Point(0, 244);
            this.BtnSideCapture.Name = "BtnSideCapture";
            this.BtnSideCapture.Size = new System.Drawing.Size(180, 58);
            this.BtnSideCapture.TabIndex = 7;
            this.BtnSideCapture.Text = "Capture";
            this.BtnSideCapture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSideCapture.UseVisualStyleBackColor = false;
            // 
            // BtnTestHide
            // 
            this.BtnTestHide.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnTestHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnTestHide.BackgroundImage")));
            this.BtnTestHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnTestHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTestHide.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTestHide.ForeColor = System.Drawing.Color.Transparent;
            this.BtnTestHide.Location = new System.Drawing.Point(0, 443);
            this.BtnTestHide.Name = "BtnTestHide";
            this.BtnTestHide.Size = new System.Drawing.Size(180, 58);
            this.BtnTestHide.TabIndex = 6;
            this.BtnTestHide.Text = "Hide";
            this.BtnTestHide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnTestHide.UseVisualStyleBackColor = false;
            this.BtnTestHide.Click += new System.EventHandler(this.BtnTestHide_Click);
            // 
            // BtnSideInfo
            // 
            this.BtnSideInfo.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnSideInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideInfo.BackgroundImage")));
            this.BtnSideInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideInfo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideInfo.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideInfo.Location = new System.Drawing.Point(0, 385);
            this.BtnSideInfo.Name = "BtnSideInfo";
            this.BtnSideInfo.Size = new System.Drawing.Size(180, 58);
            this.BtnSideInfo.TabIndex = 5;
            this.BtnSideInfo.Text = "Info";
            this.BtnSideInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSideInfo.UseVisualStyleBackColor = false;
            this.BtnSideInfo.Click += new System.EventHandler(this.BtnSideInfo_Click);
            // 
            // BtnSideUtilities
            // 
            this.BtnSideUtilities.BackColor = System.Drawing.Color.DarkKhaki;
            this.BtnSideUtilities.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideUtilities.BackgroundImage")));
            this.BtnSideUtilities.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideUtilities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideUtilities.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideUtilities.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideUtilities.Location = new System.Drawing.Point(0, 302);
            this.BtnSideUtilities.Name = "BtnSideUtilities";
            this.BtnSideUtilities.Size = new System.Drawing.Size(180, 58);
            this.BtnSideUtilities.TabIndex = 4;
            this.BtnSideUtilities.Text = "Utilities";
            this.BtnSideUtilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSideUtilities.UseVisualStyleBackColor = false;
            this.BtnSideUtilities.Click += new System.EventHandler(this.BtnSideUtilities_Click);
            // 
            // BtnSideTesting
            // 
            this.BtnSideTesting.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSideTesting.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideTesting.BackgroundImage")));
            this.BtnSideTesting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideTesting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideTesting.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideTesting.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideTesting.Location = new System.Drawing.Point(0, 186);
            this.BtnSideTesting.Name = "BtnSideTesting";
            this.BtnSideTesting.Size = new System.Drawing.Size(180, 58);
            this.BtnSideTesting.TabIndex = 3;
            this.BtnSideTesting.Text = "Testing";
            this.BtnSideTesting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSideTesting.UseVisualStyleBackColor = false;
            this.BtnSideTesting.Click += new System.EventHandler(this.BtnSideTesting_Click);
            // 
            // BtnSideAutomate
            // 
            this.BtnSideAutomate.BackColor = System.Drawing.Color.Peru;
            this.BtnSideAutomate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideAutomate.BackgroundImage")));
            this.BtnSideAutomate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideAutomate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideAutomate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideAutomate.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideAutomate.Location = new System.Drawing.Point(0, 128);
            this.BtnSideAutomate.Name = "BtnSideAutomate";
            this.BtnSideAutomate.Size = new System.Drawing.Size(180, 58);
            this.BtnSideAutomate.TabIndex = 2;
            this.BtnSideAutomate.Text = "Automate";
            this.BtnSideAutomate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSideAutomate.UseVisualStyleBackColor = false;
            this.BtnSideAutomate.Click += new System.EventHandler(this.BtnSideAutomate_Click);
            // 
            // BtnSideSettings
            // 
            this.BtnSideSettings.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BtnSideSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSideSettings.BackgroundImage")));
            this.BtnSideSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnSideSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSideSettings.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSideSettings.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSideSettings.Location = new System.Drawing.Point(0, 12);
            this.BtnSideSettings.Name = "BtnSideSettings";
            this.BtnSideSettings.Size = new System.Drawing.Size(180, 58);
            this.BtnSideSettings.TabIndex = 1;
            this.BtnSideSettings.Text = "Settings";
            this.BtnSideSettings.UseVisualStyleBackColor = false;
            this.BtnSideSettings.Click += new System.EventHandler(this.BtnSideSettings_Click);
            // 
            // FrmTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(952, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolStripButtons);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStripTerminal);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStripTerminal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(974, 593);
            this.Name = "FrmTerminal";
            this.Text = "SerialPort Logging Utility";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTerminal_FormClosing);
            this.Load += new System.EventHandler(this.FrmTerminal_Load);
            this.Shown += new System.EventHandler(this.FrmTerminal_Shown);
            this.MenuStripTerminal.ResumeLayout(false);
            this.MenuStripTerminal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timerScript;
        private System.Windows.Forms.Timer timerAutoReply;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip MenuStripTerminal;
        private System.Windows.Forms.ToolStripMenuItem TsmiFile;
        private System.Windows.Forms.ToolStripMenuItem TsmiFileExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem TsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem TsmiHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip ToolStripButtons;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnConnect;
        private System.Windows.Forms.ToolStripButton tsbtnDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton tsbtnTVControls;
        private System.Windows.Forms.ToolStripButton tsbtnRSLKRobot;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ethernetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton TsbtnClearConsole;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button BtnSideLogWindow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSideInfo;
        private System.Windows.Forms.Button BtnSideUtilities;
        private System.Windows.Forms.Button BtnSideTesting;
        private System.Windows.Forms.Button BtnSideAutomate;
        private System.Windows.Forms.Button BtnSideSettings;
        private System.Windows.Forms.Button BtnTestHide;
        private System.Windows.Forms.ToolStripStatusLabel TsslInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslConnectionStatus;
        private System.Windows.Forms.Button BtnSideCapture;
    }
}

