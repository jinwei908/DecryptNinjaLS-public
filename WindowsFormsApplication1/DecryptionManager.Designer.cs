namespace NinjaLSDecryptionManager
{
    partial class DecryptionManager
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
            this.selButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.Label();
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.selectedFolderText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder for Encrypted Logs";
            // 
            // selButton
            // 
            this.selButton.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selButton.Location = new System.Drawing.Point(121, 126);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(165, 23);
            this.selButton.TabIndex = 2;
            this.selButton.Text = "Select Folder";
            this.selButton.UseVisualStyleBackColor = true;
            this.selButton.Click += new System.EventHandler(this.selButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(90, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(308, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Progress:";
            // 
            // debugText
            // 
            this.debugText.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.debugText.Location = new System.Drawing.Point(12, 103);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(386, 18);
            this.debugText.TabIndex = 5;
            this.debugText.Text = "Please select a folder...";
            this.debugText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // browseFolder
            // 
            this.browseFolder.HelpRequest += new System.EventHandler(this.browseFolder_HelpRequest);
            // 
            // selectedFolderText
            // 
            this.selectedFolderText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFolderText.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFolderText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectedFolderText.Location = new System.Drawing.Point(13, 35);
            this.selectedFolderText.Name = "selectedFolderText";
            this.selectedFolderText.Size = new System.Drawing.Size(386, 30);
            this.selectedFolderText.TabIndex = 6;
            this.selectedFolderText.Text = "label3";
            this.selectedFolderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DecryptionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 155);
            this.Controls.Add(this.selectedFolderText);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.selButton);
            this.Controls.Add(this.label1);
            this.Name = "DecryptionManager";
            this.Text = "NinjaLS - Decryption Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing_event);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selButton;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label debugText;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.Label selectedFolderText;
    }
}

