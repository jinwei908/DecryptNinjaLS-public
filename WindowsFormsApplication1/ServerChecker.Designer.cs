namespace NinjaLSDecryptionManager
{
    partial class ServerChecker
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
            this.label1 = new System.Windows.Forms.Label();
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.statusText = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.debugText = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checking Server Status:";
            // 
            // browseFolder
            // 
            this.browseFolder.HelpRequest += new System.EventHandler(this.browseFolder_HelpRequest);
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.Yellow;
            this.statusText.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusText.Location = new System.Drawing.Point(12, 44);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(447, 26);
            this.statusText.TabIndex = 2;
            this.statusText.Text = "LIVE";
            this.statusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBtn.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBtn.ForeColor = System.Drawing.Color.White;
            this.checkBtn.Location = new System.Drawing.Point(12, 265);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(447, 38);
            this.checkBtn.TabIndex = 4;
            this.checkBtn.Text = "Force Check";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // debugText
            // 
            this.debugText.Location = new System.Drawing.Point(12, 102);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(447, 14);
            this.debugText.TabIndex = 5;
            this.debugText.Text = "Pinging Server in... 30 seconds";
            this.debugText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 75);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(447, 23);
            this.progressBar.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outputText);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 140);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Box";
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(7, 23);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(434, 111);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "";
            // 
            // ServerChecker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(471, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ServerChecker";
            this.Text = "Ninja LS - Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.check_close);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label debugText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox outputText;
    }
}

