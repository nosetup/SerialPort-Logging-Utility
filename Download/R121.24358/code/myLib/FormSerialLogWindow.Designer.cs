namespace LogTerminal
{
    partial class FormSerialLogWindow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialLogWindow));
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cbConvertAscii = new System.Windows.Forms.CheckBox();
            this.btnDelSelRow = new System.Windows.Forms.Button();
            this.btnTermClearAll = new System.Windows.Forms.Button();
            this.cbTermPauseRX = new System.Windows.Forms.CheckBox();
            this.btnTermReset = new System.Windows.Forms.Button();
            this.cbTermAutoScroll = new System.Windows.Forms.CheckBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAnalyzeHexDataShowAll = new System.Windows.Forms.Button();
            this.TbAnalyzeHexData = new System.Windows.Forms.TextBox();
            this.BtnAnalyzeHexDataSearch = new System.Windows.Forms.Button();
            this.dgvLogWindow = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendAscii = new System.Windows.Forms.Button();
            this.btnSendHex = new System.Windows.Forms.Button();
            this.lblSend = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSendAscii = new System.Windows.Forms.TextBox();
            this.TbSendHex = new System.Windows.Forms.TextBox();
            this.ToolStripButtons = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbtnLogOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLogSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.lblLogWindowInfo = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogWindow)).BeginInit();
            this.ToolStripButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(6, 423);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1084, 151);
            this.tabControl2.TabIndex = 38;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cbConvertAscii);
            this.tabPage5.Controls.Add(this.btnDelSelRow);
            this.tabPage5.Controls.Add(this.btnTermClearAll);
            this.tabPage5.Controls.Add(this.cbTermPauseRX);
            this.tabPage5.Controls.Add(this.btnTermReset);
            this.tabPage5.Controls.Add(this.cbTermAutoScroll);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1076, 118);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Log Window";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cbConvertAscii
            // 
            this.cbConvertAscii.AutoSize = true;
            this.cbConvertAscii.Font = new System.Drawing.Font("Calibri", 8F);
            this.cbConvertAscii.Location = new System.Drawing.Point(669, 20);
            this.cbConvertAscii.Name = "cbConvertAscii";
            this.cbConvertAscii.Size = new System.Drawing.Size(86, 23);
            this.cbConvertAscii.TabIndex = 21;
            this.cbConvertAscii.Text = "Ascii Rx";
            this.cbConvertAscii.UseVisualStyleBackColor = true;
            // 
            // btnDelSelRow
            // 
            this.btnDelSelRow.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnDelSelRow.Location = new System.Drawing.Point(18, 17);
            this.btnDelSelRow.Name = "btnDelSelRow";
            this.btnDelSelRow.Size = new System.Drawing.Size(165, 28);
            this.btnDelSelRow.TabIndex = 18;
            this.btnDelSelRow.Text = "Clear Selected";
            this.btnDelSelRow.Click += new System.EventHandler(this.BtnDelSelRow_Click);
            // 
            // btnTermClearAll
            // 
            this.btnTermClearAll.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnTermClearAll.Location = new System.Drawing.Point(190, 18);
            this.btnTermClearAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTermClearAll.Name = "btnTermClearAll";
            this.btnTermClearAll.Size = new System.Drawing.Size(112, 28);
            this.btnTermClearAll.TabIndex = 7;
            this.btnTermClearAll.Text = "Clear All";
            this.btnTermClearAll.Click += new System.EventHandler(this.BtnTermClearAll_Click);
            // 
            // cbTermPauseRX
            // 
            this.cbTermPauseRX.AutoSize = true;
            this.cbTermPauseRX.Font = new System.Drawing.Font("Calibri", 8F);
            this.cbTermPauseRX.Location = new System.Drawing.Point(435, 20);
            this.cbTermPauseRX.Name = "cbTermPauseRX";
            this.cbTermPauseRX.Size = new System.Drawing.Size(94, 23);
            this.cbTermPauseRX.TabIndex = 10;
            this.cbTermPauseRX.Text = "Pause Rx";
            this.cbTermPauseRX.UseVisualStyleBackColor = true;
            // 
            // btnTermReset
            // 
            this.btnTermReset.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnTermReset.Location = new System.Drawing.Point(310, 18);
            this.btnTermReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTermReset.Name = "btnTermReset";
            this.btnTermReset.Size = new System.Drawing.Size(112, 28);
            this.btnTermReset.TabIndex = 19;
            this.btnTermReset.Text = "Reset";
            this.btnTermReset.Click += new System.EventHandler(this.BtnTermReset_Click);
            // 
            // cbTermAutoScroll
            // 
            this.cbTermAutoScroll.AutoSize = true;
            this.cbTermAutoScroll.Checked = true;
            this.cbTermAutoScroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTermAutoScroll.Font = new System.Drawing.Font("Calibri", 8F);
            this.cbTermAutoScroll.Location = new System.Drawing.Point(553, 20);
            this.cbTermAutoScroll.Name = "cbTermAutoScroll";
            this.cbTermAutoScroll.Size = new System.Drawing.Size(100, 23);
            this.cbTermAutoScroll.TabIndex = 19;
            this.cbTermAutoScroll.Text = "AutoScroll";
            this.cbTermAutoScroll.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.BtnAnalyzeHexDataShowAll);
            this.tabPage6.Controls.Add(this.TbAnalyzeHexData);
            this.tabPage6.Controls.Add(this.BtnAnalyzeHexDataSearch);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1076, 118);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Search Data";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search for keyword in data column.";
            // 
            // BtnAnalyzeHexDataShowAll
            // 
            this.BtnAnalyzeHexDataShowAll.Font = new System.Drawing.Font("Calibri", 8F);
            this.BtnAnalyzeHexDataShowAll.Location = new System.Drawing.Point(437, 33);
            this.BtnAnalyzeHexDataShowAll.Name = "BtnAnalyzeHexDataShowAll";
            this.BtnAnalyzeHexDataShowAll.Size = new System.Drawing.Size(98, 32);
            this.BtnAnalyzeHexDataShowAll.TabIndex = 18;
            this.BtnAnalyzeHexDataShowAll.Text = "Show All";
            this.BtnAnalyzeHexDataShowAll.UseVisualStyleBackColor = true;
            this.BtnAnalyzeHexDataShowAll.Click += new System.EventHandler(this.BtnAnalyzeHexDataShowAll_Click);
            // 
            // TbAnalyzeHexData
            // 
            this.TbAnalyzeHexData.Location = new System.Drawing.Point(11, 37);
            this.TbAnalyzeHexData.MaxLength = 10;
            this.TbAnalyzeHexData.Name = "TbAnalyzeHexData";
            this.TbAnalyzeHexData.Size = new System.Drawing.Size(308, 26);
            this.TbAnalyzeHexData.TabIndex = 15;
            this.TbAnalyzeHexData.Text = "Keyword";
            // 
            // BtnAnalyzeHexDataSearch
            // 
            this.BtnAnalyzeHexDataSearch.Font = new System.Drawing.Font("Calibri", 8F);
            this.BtnAnalyzeHexDataSearch.Location = new System.Drawing.Point(333, 33);
            this.BtnAnalyzeHexDataSearch.Name = "BtnAnalyzeHexDataSearch";
            this.BtnAnalyzeHexDataSearch.Size = new System.Drawing.Size(98, 32);
            this.BtnAnalyzeHexDataSearch.TabIndex = 7;
            this.BtnAnalyzeHexDataSearch.Text = "Search";
            this.BtnAnalyzeHexDataSearch.UseVisualStyleBackColor = true;
            this.BtnAnalyzeHexDataSearch.Click += new System.EventHandler(this.BtnAnalyzeHexDataSearch_Click);
            // 
            // dgvLogWindow
            // 
            this.dgvLogWindow.AllowUserToAddRows = false;
            this.dgvLogWindow.AllowUserToDeleteRows = false;
            this.dgvLogWindow.AllowUserToResizeRows = false;
            this.dgvLogWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogWindow.ColumnHeadersHeight = 34;
            this.dgvLogWindow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLogWindow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLogWindow.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLogWindow.Location = new System.Drawing.Point(6, 185);
            this.dgvLogWindow.MinimumSize = new System.Drawing.Size(1000, 100);
            this.dgvLogWindow.Name = "dgvLogWindow";
            this.dgvLogWindow.RowHeadersWidth = 62;
            this.dgvLogWindow.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLogWindow.RowTemplate.Height = 18;
            this.dgvLogWindow.RowTemplate.ReadOnly = true;
            this.dgvLogWindow.Size = new System.Drawing.Size(1080, 232);
            this.dgvLogWindow.TabIndex = 34;
            // 
            // Column1
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "HH:MM:SS";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "<->";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Data";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Message";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // btnSendAscii
            // 
            this.btnSendAscii.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnSendAscii.Location = new System.Drawing.Point(875, 116);
            this.btnSendAscii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendAscii.Name = "btnSendAscii";
            this.btnSendAscii.Size = new System.Drawing.Size(82, 35);
            this.btnSendAscii.TabIndex = 37;
            this.btnSendAscii.Text = "Send";
            this.btnSendAscii.Click += new System.EventHandler(this.BtnSendAscii_Click);
            // 
            // btnSendHex
            // 
            this.btnSendHex.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnSendHex.Location = new System.Drawing.Point(393, 116);
            this.btnSendHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendHex.Name = "btnSendHex";
            this.btnSendHex.Size = new System.Drawing.Size(82, 35);
            this.btnSendHex.TabIndex = 33;
            this.btnSendHex.Text = "Send";
            this.btnSendHex.Click += new System.EventHandler(this.BtnSendHex_Click);
            // 
            // lblSend
            // 
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(13, 122);
            this.lblSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(83, 20);
            this.lblSend.TabIndex = 31;
            this.lblSend.Text = "Send Hex:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Send Text:";
            // 
            // TbSendAscii
            // 
            this.TbSendAscii.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSendAscii.Location = new System.Drawing.Point(585, 122);
            this.TbSendAscii.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbSendAscii.MaxLength = 30;
            this.TbSendAscii.Name = "TbSendAscii";
            this.TbSendAscii.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TbSendAscii.Size = new System.Drawing.Size(282, 26);
            this.TbSendAscii.TabIndex = 36;
            this.toolTip1.SetToolTip(this.TbSendAscii, "example :\"Hello World\"");
            // 
            // TbSendHex
            // 
            this.TbSendHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbSendHex.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbSendHex.Location = new System.Drawing.Point(104, 122);
            this.TbSendHex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbSendHex.MaxLength = 30;
            this.TbSendHex.Name = "TbSendHex";
            this.TbSendHex.Size = new System.Drawing.Size(282, 26);
            this.TbSendHex.TabIndex = 32;
            this.toolTip1.SetToolTip(this.TbSendHex, "example :\"48 65 6C 6C 6F 20 57 6F 72 6C 64\"");
            // 
            // ToolStripButtons
            // 
            this.ToolStripButtons.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStripButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tsbtnLogOpen,
            this.tsbtnLogSaveAs,
            this.toolStripSeparator7});
            this.ToolStripButtons.Location = new System.Drawing.Point(0, 0);
            this.ToolStripButtons.Name = "ToolStripButtons";
            this.ToolStripButtons.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ToolStripButtons.Size = new System.Drawing.Size(1101, 52);
            this.ToolStripButtons.TabIndex = 39;
            this.ToolStripButtons.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(69, 47);
            this.toolStripLabel3.Text = "// Logs >";
            // 
            // tsbtnLogOpen
            // 
            this.tsbtnLogOpen.Font = new System.Drawing.Font("Calibri", 8F);
            this.tsbtnLogOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogOpen.Image")));
            this.tsbtnLogOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogOpen.Name = "tsbtnLogOpen";
            this.tsbtnLogOpen.Size = new System.Drawing.Size(48, 47);
            this.tsbtnLogOpen.Text = "Open";
            this.tsbtnLogOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnLogOpen.Click += new System.EventHandler(this.TsbtnLogOpen_Click);
            // 
            // tsbtnLogSaveAs
            // 
            this.tsbtnLogSaveAs.Font = new System.Drawing.Font("Calibri", 8F);
            this.tsbtnLogSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogSaveAs.Image")));
            this.tsbtnLogSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogSaveAs.Name = "tsbtnLogSaveAs";
            this.tsbtnLogSaveAs.Size = new System.Drawing.Size(63, 47);
            this.tsbtnLogSaveAs.Text = "Save As";
            this.tsbtnLogSaveAs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnLogSaveAs.Click += new System.EventHandler(this.TsbtnLogSaveAs_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 52);
            // 
            // lblLogWindowInfo
            // 
            this.lblLogWindowInfo.AutoSize = true;
            this.lblLogWindowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogWindowInfo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLogWindowInfo.Location = new System.Drawing.Point(13, 73);
            this.lblLogWindowInfo.Name = "lblLogWindowInfo";
            this.lblLogWindowInfo.Size = new System.Drawing.Size(538, 40);
            this.lblLogWindowInfo.TabIndex = 40;
            this.lblLogWindowInfo.Text = "Transmit Serial Data:\r\nformat : HEX = \"48 65 6C 6C 6F 20 57 6F 72 6C 64\" or Text " +
    "= \"Hello World\"";
            // 
            // FormSerialLogWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 576);
            this.Controls.Add(this.lblLogWindowInfo);
            this.Controls.Add(this.ToolStripButtons);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.dgvLogWindow);
            this.Controls.Add(this.btnSendAscii);
            this.Controls.Add(this.btnSendHex);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbSendAscii);
            this.Controls.Add(this.TbSendHex);
            this.Name = "FormSerialLogWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Log Window";
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogWindow)).EndInit();
            this.ToolStripButtons.ResumeLayout(false);
            this.ToolStripButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox cbConvertAscii;
        private System.Windows.Forms.Button btnDelSelRow;
        private System.Windows.Forms.Button btnTermClearAll;
        private System.Windows.Forms.CheckBox cbTermPauseRX;
        private System.Windows.Forms.Button btnTermReset;
        private System.Windows.Forms.CheckBox cbTermAutoScroll;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAnalyzeHexDataShowAll;
        private System.Windows.Forms.TextBox TbAnalyzeHexData;
        private System.Windows.Forms.Button BtnAnalyzeHexDataSearch;
        private System.Windows.Forms.DataGridView dgvLogWindow;
        private System.Windows.Forms.Button btnSendAscii;
        private System.Windows.Forms.Button btnSendHex;
        private System.Windows.Forms.Label lblSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSendAscii;
        private System.Windows.Forms.TextBox TbSendHex;
        private System.Windows.Forms.ToolStrip ToolStripButtons;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbtnLogOpen;
        private System.Windows.Forms.ToolStripButton tsbtnLogSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.Label lblLogWindowInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
