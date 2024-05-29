namespace LogTerminal
{
    partial class TVRemote
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
            this.gbTVController = new System.Windows.Forms.GroupBox();
            this.gbVolCtrl = new System.Windows.Forms.GroupBox();
            this.btnMute = new System.Windows.Forms.Button();
            this.btnVolDn = new System.Windows.Forms.Button();
            this.btnVolUp = new System.Windows.Forms.Button();
            this.gbSourceSel = new System.Windows.Forms.GroupBox();
            this.btnSelAnalog = new System.Windows.Forms.Button();
            this.btnSelHDMI3 = new System.Windows.Forms.Button();
            this.btnSelHDMI2 = new System.Windows.Forms.Button();
            this.btnSelHDMI1 = new System.Windows.Forms.Button();
            this.btnPwrOff = new System.Windows.Forms.Button();
            this.btnPwrOn = new System.Windows.Forms.Button();
            this.gbTVMfg = new System.Windows.Forms.GroupBox();
            this.rbMfgLG = new System.Windows.Forms.RadioButton();
            this.rbMfgSamsung = new System.Windows.Forms.RadioButton();
            this.gbRunMode = new System.Windows.Forms.GroupBox();
            this.rbModeEmulator = new System.Windows.Forms.RadioButton();
            this.rbModeController = new System.Windows.Forms.RadioButton();
            this.gbTVController.SuspendLayout();
            this.gbVolCtrl.SuspendLayout();
            this.gbSourceSel.SuspendLayout();
            this.gbTVMfg.SuspendLayout();
            this.gbRunMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTVController
            // 
            this.gbTVController.Controls.Add(this.gbVolCtrl);
            this.gbTVController.Controls.Add(this.gbSourceSel);
            this.gbTVController.Controls.Add(this.btnPwrOff);
            this.gbTVController.Controls.Add(this.btnPwrOn);
            this.gbTVController.Location = new System.Drawing.Point(16, 115);
            this.gbTVController.Name = "gbTVController";
            this.gbTVController.Size = new System.Drawing.Size(447, 149);
            this.gbTVController.TabIndex = 13;
            this.gbTVController.TabStop = false;
            this.gbTVController.Text = "Controller";
            // 
            // gbVolCtrl
            // 
            this.gbVolCtrl.Controls.Add(this.btnMute);
            this.gbVolCtrl.Controls.Add(this.btnVolDn);
            this.gbVolCtrl.Controls.Add(this.btnVolUp);
            this.gbVolCtrl.Location = new System.Drawing.Point(8, 77);
            this.gbVolCtrl.Name = "gbVolCtrl";
            this.gbVolCtrl.Size = new System.Drawing.Size(160, 63);
            this.gbVolCtrl.TabIndex = 4;
            this.gbVolCtrl.TabStop = false;
            this.gbVolCtrl.Text = "Vol";
            // 
            // btnMute
            // 
            this.btnMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMute.Location = new System.Drawing.Point(88, 25);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(38, 32);
            this.btnMute.TabIndex = 8;
            this.btnMute.Text = "X";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.BtnMute_Click);
            // 
            // btnVolDn
            // 
            this.btnVolDn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolDn.Location = new System.Drawing.Point(45, 25);
            this.btnVolDn.Name = "btnVolDn";
            this.btnVolDn.Size = new System.Drawing.Size(38, 32);
            this.btnVolDn.TabIndex = 7;
            this.btnVolDn.Text = "-";
            this.btnVolDn.UseVisualStyleBackColor = true;
            this.btnVolDn.Click += new System.EventHandler(this.BtnVolDn_Click);
            // 
            // btnVolUp
            // 
            this.btnVolUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolUp.Location = new System.Drawing.Point(6, 25);
            this.btnVolUp.Name = "btnVolUp";
            this.btnVolUp.Size = new System.Drawing.Size(38, 32);
            this.btnVolUp.TabIndex = 6;
            this.btnVolUp.Text = "+";
            this.btnVolUp.UseVisualStyleBackColor = true;
            this.btnVolUp.Click += new System.EventHandler(this.BtnVolUp_Click);
            // 
            // gbSourceSel
            // 
            this.gbSourceSel.Controls.Add(this.btnSelAnalog);
            this.gbSourceSel.Controls.Add(this.btnSelHDMI3);
            this.gbSourceSel.Controls.Add(this.btnSelHDMI2);
            this.gbSourceSel.Controls.Add(this.btnSelHDMI1);
            this.gbSourceSel.Location = new System.Drawing.Point(224, 14);
            this.gbSourceSel.Name = "gbSourceSel";
            this.gbSourceSel.Size = new System.Drawing.Size(214, 120);
            this.gbSourceSel.TabIndex = 3;
            this.gbSourceSel.TabStop = false;
            this.gbSourceSel.Text = "Source";
            // 
            // btnSelAnalog
            // 
            this.btnSelAnalog.Location = new System.Drawing.Point(110, 82);
            this.btnSelAnalog.Name = "btnSelAnalog";
            this.btnSelAnalog.Size = new System.Drawing.Size(98, 32);
            this.btnSelAnalog.TabIndex = 5;
            this.btnSelAnalog.Text = "ANALOG";
            this.btnSelAnalog.UseVisualStyleBackColor = true;
            this.btnSelAnalog.Click += new System.EventHandler(this.BtnSelAnalog_Click);
            // 
            // btnSelHDMI3
            // 
            this.btnSelHDMI3.Location = new System.Drawing.Point(6, 82);
            this.btnSelHDMI3.Name = "btnSelHDMI3";
            this.btnSelHDMI3.Size = new System.Drawing.Size(98, 32);
            this.btnSelHDMI3.TabIndex = 4;
            this.btnSelHDMI3.Text = "HDMI 3";
            this.btnSelHDMI3.UseVisualStyleBackColor = true;
            this.btnSelHDMI3.Click += new System.EventHandler(this.BtnSelHDMI3_Click);
            // 
            // btnSelHDMI2
            // 
            this.btnSelHDMI2.Location = new System.Drawing.Point(108, 25);
            this.btnSelHDMI2.Name = "btnSelHDMI2";
            this.btnSelHDMI2.Size = new System.Drawing.Size(98, 32);
            this.btnSelHDMI2.TabIndex = 3;
            this.btnSelHDMI2.Text = "HDMI 2";
            this.btnSelHDMI2.UseVisualStyleBackColor = true;
            this.btnSelHDMI2.Click += new System.EventHandler(this.BtnSelHDMI2_Click);
            // 
            // btnSelHDMI1
            // 
            this.btnSelHDMI1.Location = new System.Drawing.Point(4, 25);
            this.btnSelHDMI1.Name = "btnSelHDMI1";
            this.btnSelHDMI1.Size = new System.Drawing.Size(98, 32);
            this.btnSelHDMI1.TabIndex = 2;
            this.btnSelHDMI1.Text = "HDMI 1";
            this.btnSelHDMI1.UseVisualStyleBackColor = true;
            this.btnSelHDMI1.Click += new System.EventHandler(this.BtnSelHDMI1_Click);
            // 
            // btnPwrOff
            // 
            this.btnPwrOff.Location = new System.Drawing.Point(117, 38);
            this.btnPwrOff.Name = "btnPwrOff";
            this.btnPwrOff.Size = new System.Drawing.Size(98, 32);
            this.btnPwrOff.TabIndex = 1;
            this.btnPwrOff.Text = "Power Off";
            this.btnPwrOff.UseVisualStyleBackColor = true;
            this.btnPwrOff.Click += new System.EventHandler(this.BtnPwrOff_Click);
            // 
            // btnPwrOn
            // 
            this.btnPwrOn.Location = new System.Drawing.Point(6, 38);
            this.btnPwrOn.Name = "btnPwrOn";
            this.btnPwrOn.Size = new System.Drawing.Size(98, 32);
            this.btnPwrOn.TabIndex = 0;
            this.btnPwrOn.Text = "Power On";
            this.btnPwrOn.UseVisualStyleBackColor = true;
            this.btnPwrOn.Click += new System.EventHandler(this.BtnPwrOn_Click);
            // 
            // gbTVMfg
            // 
            this.gbTVMfg.Controls.Add(this.rbMfgLG);
            this.gbTVMfg.Controls.Add(this.rbMfgSamsung);
            this.gbTVMfg.Location = new System.Drawing.Point(240, 9);
            this.gbTVMfg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTVMfg.Name = "gbTVMfg";
            this.gbTVMfg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTVMfg.Size = new System.Drawing.Size(224, 98);
            this.gbTVMfg.TabIndex = 14;
            this.gbTVMfg.TabStop = false;
            this.gbTVMfg.Text = "Mfg";
            // 
            // rbMfgLG
            // 
            this.rbMfgLG.AutoSize = true;
            this.rbMfgLG.Checked = true;
            this.rbMfgLG.Location = new System.Drawing.Point(8, 57);
            this.rbMfgLG.Name = "rbMfgLG";
            this.rbMfgLG.Size = new System.Drawing.Size(80, 24);
            this.rbMfgLG.TabIndex = 3;
            this.rbMfgLG.TabStop = true;
            this.rbMfgLG.Text = "LG TV";
            this.rbMfgLG.UseVisualStyleBackColor = true;
            // 
            // rbMfgSamsung
            // 
            this.rbMfgSamsung.AutoSize = true;
            this.rbMfgSamsung.Location = new System.Drawing.Point(8, 25);
            this.rbMfgSamsung.Name = "rbMfgSamsung";
            this.rbMfgSamsung.Size = new System.Drawing.Size(126, 24);
            this.rbMfgSamsung.TabIndex = 2;
            this.rbMfgSamsung.Text = "Samsung TV";
            this.rbMfgSamsung.UseVisualStyleBackColor = true;
            // 
            // gbRunMode
            // 
            this.gbRunMode.Controls.Add(this.rbModeEmulator);
            this.gbRunMode.Controls.Add(this.rbModeController);
            this.gbRunMode.Location = new System.Drawing.Point(16, 9);
            this.gbRunMode.Name = "gbRunMode";
            this.gbRunMode.Size = new System.Drawing.Size(214, 98);
            this.gbRunMode.TabIndex = 12;
            this.gbRunMode.TabStop = false;
            this.gbRunMode.Text = "Mode";
            // 
            // rbModeEmulator
            // 
            this.rbModeEmulator.AutoSize = true;
            this.rbModeEmulator.Location = new System.Drawing.Point(8, 57);
            this.rbModeEmulator.Name = "rbModeEmulator";
            this.rbModeEmulator.Size = new System.Drawing.Size(98, 24);
            this.rbModeEmulator.TabIndex = 1;
            this.rbModeEmulator.Text = "Emulator";
            this.rbModeEmulator.UseVisualStyleBackColor = true;
            // 
            // rbModeController
            // 
            this.rbModeController.AutoSize = true;
            this.rbModeController.Checked = true;
            this.rbModeController.Location = new System.Drawing.Point(8, 25);
            this.rbModeController.Name = "rbModeController";
            this.rbModeController.Size = new System.Drawing.Size(102, 24);
            this.rbModeController.TabIndex = 0;
            this.rbModeController.TabStop = true;
            this.rbModeController.Text = "Controller";
            this.rbModeController.UseVisualStyleBackColor = true;
            // 
            // TVRemote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(468, 274);
            this.Controls.Add(this.gbTVController);
            this.Controls.Add(this.gbTVMfg);
            this.Controls.Add(this.gbRunMode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(490, 330);
            this.Name = "TVRemote";
            this.Text = "TV Remote";
            this.gbTVController.ResumeLayout(false);
            this.gbVolCtrl.ResumeLayout(false);
            this.gbSourceSel.ResumeLayout(false);
            this.gbTVMfg.ResumeLayout(false);
            this.gbTVMfg.PerformLayout();
            this.gbRunMode.ResumeLayout(false);
            this.gbRunMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTVController;
        private System.Windows.Forms.GroupBox gbVolCtrl;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.Button btnVolDn;
        private System.Windows.Forms.Button btnVolUp;
        private System.Windows.Forms.GroupBox gbSourceSel;
        private System.Windows.Forms.Button btnSelAnalog;
        private System.Windows.Forms.Button btnSelHDMI3;
        private System.Windows.Forms.Button btnSelHDMI2;
        private System.Windows.Forms.Button btnSelHDMI1;
        private System.Windows.Forms.Button btnPwrOff;
        private System.Windows.Forms.Button btnPwrOn;
        private System.Windows.Forms.GroupBox gbTVMfg;
        private System.Windows.Forms.RadioButton rbMfgLG;
        private System.Windows.Forms.RadioButton rbMfgSamsung;
        private System.Windows.Forms.GroupBox gbRunMode;
        private System.Windows.Forms.RadioButton rbModeEmulator;
        private System.Windows.Forms.RadioButton rbModeController;
    }
}