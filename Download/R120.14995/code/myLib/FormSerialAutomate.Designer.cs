namespace LogTerminal
{
    partial class FormSerialAutomate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialAutomate));
            this.gbScripting = new System.Windows.Forms.GroupBox();
            this.lblScriptInfo = new System.Windows.Forms.Label();
            this.cbScriptEnable = new System.Windows.Forms.CheckBox();
            this.dgvScripting = new System.Windows.Forms.DataGridView();
            this.cbScriptLoop = new System.Windows.Forms.CheckBox();
            this.gbAutoReply = new System.Windows.Forms.GroupBox();
            this.lblAutoReplyInfo = new System.Windows.Forms.Label();
            this.cbAutoReplyEnable = new System.Windows.Forms.CheckBox();
            this.dgvAutoReply = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TsBtnScriptOpenFile = new System.Windows.Forms.ToolStripButton();
            this.TsBtnScriptSaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TsBtnAutoReplyOpenFile = new System.Windows.Forms.ToolStripButton();
            this.TsBtnAutoReplySaveFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gbScripting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScripting)).BeginInit();
            this.gbAutoReply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoReply)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScripting
            // 
            this.gbScripting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbScripting.Controls.Add(this.lblScriptInfo);
            this.gbScripting.Controls.Add(this.cbScriptEnable);
            this.gbScripting.Controls.Add(this.dgvScripting);
            this.gbScripting.Controls.Add(this.cbScriptLoop);
            this.gbScripting.Location = new System.Drawing.Point(13, 82);
            this.gbScripting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbScripting.Name = "gbScripting";
            this.gbScripting.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbScripting.Size = new System.Drawing.Size(735, 267);
            this.gbScripting.TabIndex = 17;
            this.gbScripting.TabStop = false;
            this.gbScripting.Text = "Scripting";
            // 
            // lblScriptInfo
            // 
            this.lblScriptInfo.AutoSize = true;
            this.lblScriptInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScriptInfo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblScriptInfo.Location = new System.Drawing.Point(7, 19);
            this.lblScriptInfo.Name = "lblScriptInfo";
            this.lblScriptInfo.Size = new System.Drawing.Size(207, 20);
            this.lblScriptInfo.TabIndex = 27;
            this.lblScriptInfo.Text = "Send script out to serial port";
            // 
            // cbScriptEnable
            // 
            this.cbScriptEnable.AutoSize = true;
            this.cbScriptEnable.Font = new System.Drawing.Font("Calibri", 8F);
            this.cbScriptEnable.Location = new System.Drawing.Point(619, 15);
            this.cbScriptEnable.Name = "cbScriptEnable";
            this.cbScriptEnable.Size = new System.Drawing.Size(79, 23);
            this.cbScriptEnable.TabIndex = 22;
            this.cbScriptEnable.Text = "Enable";
            this.cbScriptEnable.UseVisualStyleBackColor = true;
            this.cbScriptEnable.CheckedChanged += new System.EventHandler(this.CbScriptEnable_CheckedChanged);
            // 
            // dgvScripting
            // 
            this.dgvScripting.AllowUserToResizeColumns = false;
            this.dgvScripting.AllowUserToResizeRows = false;
            this.dgvScripting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvScripting.ColumnHeadersHeight = 34;
            this.dgvScripting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScripting.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScripting.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvScripting.Location = new System.Drawing.Point(11, 45);
            this.dgvScripting.Name = "dgvScripting";
            this.dgvScripting.RowHeadersWidth = 62;
            this.dgvScripting.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvScripting.RowTemplate.Height = 18;
            this.dgvScripting.Size = new System.Drawing.Size(705, 214);
            this.dgvScripting.TabIndex = 21;
            // 
            // cbScriptLoop
            // 
            this.cbScriptLoop.AutoSize = true;
            this.cbScriptLoop.Font = new System.Drawing.Font("Calibri", 8F);
            this.cbScriptLoop.Location = new System.Drawing.Point(532, 15);
            this.cbScriptLoop.Name = "cbScriptLoop";
            this.cbScriptLoop.Size = new System.Drawing.Size(66, 23);
            this.cbScriptLoop.TabIndex = 20;
            this.cbScriptLoop.Text = "Loop";
            this.cbScriptLoop.UseVisualStyleBackColor = true;
            // 
            // gbAutoReply
            // 
            this.gbAutoReply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAutoReply.Controls.Add(this.lblAutoReplyInfo);
            this.gbAutoReply.Controls.Add(this.cbAutoReplyEnable);
            this.gbAutoReply.Controls.Add(this.dgvAutoReply);
            this.gbAutoReply.Location = new System.Drawing.Point(13, 359);
            this.gbAutoReply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAutoReply.Name = "gbAutoReply";
            this.gbAutoReply.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbAutoReply.Size = new System.Drawing.Size(735, 202);
            this.gbAutoReply.TabIndex = 16;
            this.gbAutoReply.TabStop = false;
            this.gbAutoReply.Text = "Auto Reply";
            // 
            // lblAutoReplyInfo
            // 
            this.lblAutoReplyInfo.AutoSize = true;
            this.lblAutoReplyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoReplyInfo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblAutoReplyInfo.Location = new System.Drawing.Point(7, 19);
            this.lblAutoReplyInfo.Name = "lblAutoReplyInfo";
            this.lblAutoReplyInfo.Size = new System.Drawing.Size(422, 20);
            this.lblAutoReplyInfo.TabIndex = 28;
            this.lblAutoReplyInfo.Text = "Wait for a specific incoming messages and send response.";
            // 
            // cbAutoReplyEnable
            // 
            this.cbAutoReplyEnable.AutoSize = true;
            this.cbAutoReplyEnable.Font = new System.Drawing.Font("Calibri", 8F);
            this.cbAutoReplyEnable.Location = new System.Drawing.Point(617, 15);
            this.cbAutoReplyEnable.Name = "cbAutoReplyEnable";
            this.cbAutoReplyEnable.Size = new System.Drawing.Size(79, 23);
            this.cbAutoReplyEnable.TabIndex = 23;
            this.cbAutoReplyEnable.Text = "Enable";
            this.cbAutoReplyEnable.UseVisualStyleBackColor = true;
            this.cbAutoReplyEnable.CheckedChanged += new System.EventHandler(this.CbAutoReplyEnable_CheckedChanged);
            // 
            // dgvAutoReply
            // 
            this.dgvAutoReply.AllowUserToResizeRows = false;
            this.dgvAutoReply.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutoReply.ColumnHeadersHeight = 34;
            this.dgvAutoReply.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutoReply.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutoReply.Location = new System.Drawing.Point(8, 45);
            this.dgvAutoReply.Name = "dgvAutoReply";
            this.dgvAutoReply.RowHeadersWidth = 62;
            this.dgvAutoReply.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAutoReply.RowTemplate.Height = 18;
            this.dgvAutoReply.Size = new System.Drawing.Size(708, 149);
            this.dgvAutoReply.TabIndex = 22;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TsBtnScriptOpenFile,
            this.TsBtnScriptSaveFile,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.TsBtnAutoReplyOpenFile,
            this.TsBtnAutoReplySaveFile,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(761, 52);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 47);
            this.toolStripLabel1.Text = "// Scripting >";
            // 
            // TsBtnScriptOpenFile
            // 
            this.TsBtnScriptOpenFile.Font = new System.Drawing.Font("Calibri", 8F);
            this.TsBtnScriptOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnScriptOpenFile.Image")));
            this.TsBtnScriptOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnScriptOpenFile.Name = "TsBtnScriptOpenFile";
            this.TsBtnScriptOpenFile.Size = new System.Drawing.Size(48, 47);
            this.TsBtnScriptOpenFile.Text = "Open";
            this.TsBtnScriptOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnScriptOpenFile.Click += new System.EventHandler(this.TsBtnScriptOpenFile_Click);
            // 
            // TsBtnScriptSaveFile
            // 
            this.TsBtnScriptSaveFile.Font = new System.Drawing.Font("Calibri", 8F);
            this.TsBtnScriptSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnScriptSaveFile.Image")));
            this.TsBtnScriptSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnScriptSaveFile.Name = "TsBtnScriptSaveFile";
            this.TsBtnScriptSaveFile.Size = new System.Drawing.Size(63, 47);
            this.TsBtnScriptSaveFile.Text = "Save As";
            this.TsBtnScriptSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnScriptSaveFile.Click += new System.EventHandler(this.TsBtnScriptSaveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(115, 47);
            this.toolStripLabel2.Text = "// Auto Reply >";
            // 
            // TsBtnAutoReplyOpenFile
            // 
            this.TsBtnAutoReplyOpenFile.Font = new System.Drawing.Font("Calibri", 8F);
            this.TsBtnAutoReplyOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnAutoReplyOpenFile.Image")));
            this.TsBtnAutoReplyOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnAutoReplyOpenFile.Name = "TsBtnAutoReplyOpenFile";
            this.TsBtnAutoReplyOpenFile.Size = new System.Drawing.Size(48, 47);
            this.TsBtnAutoReplyOpenFile.Text = "Open";
            this.TsBtnAutoReplyOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnAutoReplyOpenFile.Click += new System.EventHandler(this.TsBtnAutoReplyOpenFile_Click);
            // 
            // TsBtnAutoReplySaveFile
            // 
            this.TsBtnAutoReplySaveFile.Font = new System.Drawing.Font("Calibri", 8F);
            this.TsBtnAutoReplySaveFile.Image = ((System.Drawing.Image)(resources.GetObject("TsBtnAutoReplySaveFile.Image")));
            this.TsBtnAutoReplySaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnAutoReplySaveFile.Name = "TsBtnAutoReplySaveFile";
            this.TsBtnAutoReplySaveFile.Size = new System.Drawing.Size(63, 47);
            this.TsBtnAutoReplySaveFile.Text = "Save As";
            this.TsBtnAutoReplySaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnAutoReplySaveFile.Click += new System.EventHandler(this.TsBtnAutoReplySaveFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // FormSerialAutomate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 575);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbAutoReply);
            this.Controls.Add(this.gbScripting);
            this.Name = "FormSerialAutomate";
            this.Text = "Automate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSerialAutomate_FormClosing);
            this.gbScripting.ResumeLayout(false);
            this.gbScripting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScripting)).EndInit();
            this.gbAutoReply.ResumeLayout(false);
            this.gbAutoReply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoReply)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbScripting;
        private System.Windows.Forms.Label lblScriptInfo;
        private System.Windows.Forms.CheckBox cbScriptEnable;
        private System.Windows.Forms.DataGridView dgvScripting;
        private System.Windows.Forms.CheckBox cbScriptLoop;
        private System.Windows.Forms.GroupBox gbAutoReply;
        private System.Windows.Forms.Label lblAutoReplyInfo;
        private System.Windows.Forms.CheckBox cbAutoReplyEnable;
        private System.Windows.Forms.DataGridView dgvAutoReply;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton TsBtnScriptOpenFile;
        private System.Windows.Forms.ToolStripButton TsBtnScriptSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton TsBtnAutoReplyOpenFile;
        private System.Windows.Forms.ToolStripButton TsBtnAutoReplySaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}