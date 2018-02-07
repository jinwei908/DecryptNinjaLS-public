namespace NinjaLSDecryptionManager
{
    partial class NinjaLSHome
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
            this.statusButton = new System.Windows.Forms.Button();
            this.analyzeBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Ninja LS Tool Console";
            // 
            // browseFolder
            // 
            this.browseFolder.HelpRequest += new System.EventHandler(this.browseFolder_HelpRequest);
            // 
            // statusButton
            // 
            this.statusButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusButton.BackgroundImage = global::NinjaLSDecryptionManager.Properties.Resources.Status_icon;
            this.statusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.statusButton.FlatAppearance.BorderSize = 0;
            this.statusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusButton.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusButton.Location = new System.Drawing.Point(323, 45);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(130, 130);
            this.statusButton.TabIndex = 3;
            this.statusButton.UseVisualStyleBackColor = false;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // analyzeBtn
            // 
            this.analyzeBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.analyzeBtn.BackgroundImage = global::NinjaLSDecryptionManager.Properties.Resources.Analyze_icon;
            this.analyzeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.analyzeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analyzeBtn.FlatAppearance.BorderSize = 0;
            this.analyzeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analyzeBtn.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analyzeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.analyzeBtn.Location = new System.Drawing.Point(171, 45);
            this.analyzeBtn.Name = "analyzeBtn";
            this.analyzeBtn.Size = new System.Drawing.Size(130, 130);
            this.analyzeBtn.TabIndex = 2;
            this.analyzeBtn.UseVisualStyleBackColor = false;
            this.analyzeBtn.Click += new System.EventHandler(this.analyzeBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.decryptBtn.BackgroundImage = global::NinjaLSDecryptionManager.Properties.Resources.Decrypt_icon;
            this.decryptBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.decryptBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.decryptBtn.FlatAppearance.BorderSize = 0;
            this.decryptBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decryptBtn.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decryptBtn.Location = new System.Drawing.Point(19, 45);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(130, 130);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // NinjaLSHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(471, 184);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.analyzeBtn);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NinjaLSHome";
            this.Text = "Ninja LS - Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button analyzeBtn;
        private System.Windows.Forms.Button statusButton;
    }
}

