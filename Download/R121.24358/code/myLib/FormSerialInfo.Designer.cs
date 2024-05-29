namespace LogTerminal
{
    partial class FormSerialInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialInfo));
            this.rtbSerialPortInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbSerialPortInfo
            // 
            this.rtbSerialPortInfo.Location = new System.Drawing.Point(12, 12);
            this.rtbSerialPortInfo.Name = "rtbSerialPortInfo";
            this.rtbSerialPortInfo.ReadOnly = true;
            this.rtbSerialPortInfo.Size = new System.Drawing.Size(424, 227);
            this.rtbSerialPortInfo.TabIndex = 6;
            this.rtbSerialPortInfo.Text = resources.GetString("rtbSerialPortInfo.Text");
            // 
            // FormSerialHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSerialPortInfo);
            this.Name = "FormSerialHelp";
            this.Text = "Info";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSerialPortInfo;
    }
}