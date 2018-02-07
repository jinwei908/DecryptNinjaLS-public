namespace NinjaLSDecryptionManager
{
    partial class AnalysisSelector
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
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.selectedFolderText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedFile = new System.Windows.Forms.Label();
            this.fileBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Folder or File for Analysis";
            // 
            // selButton
            // 
            this.selButton.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selButton.Location = new System.Drawing.Point(338, 36);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(64, 23);
            this.selButton.TabIndex = 2;
            this.selButton.Text = "Select";
            this.selButton.UseVisualStyleBackColor = true;
            this.selButton.Click += new System.EventHandler(this.selButton_Click);
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
            this.selectedFolderText.Location = new System.Drawing.Point(57, 35);
            this.selectedFolderText.Name = "selectedFolderText";
            this.selectedFolderText.Size = new System.Drawing.Size(275, 24);
            this.selectedFolderText.TabIndex = 6;
            this.selectedFolderText.Text = "label3";
            this.selectedFolderText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Folder:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "File:";
            // 
            // selectedFile
            // 
            this.selectedFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedFile.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectedFile.Location = new System.Drawing.Point(57, 65);
            this.selectedFile.Name = "selectedFile";
            this.selectedFile.Size = new System.Drawing.Size(275, 24);
            this.selectedFile.TabIndex = 9;
            this.selectedFile.Text = "label3";
            this.selectedFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileBtn
            // 
            this.fileBtn.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileBtn.Location = new System.Drawing.Point(338, 66);
            this.fileBtn.Name = "fileBtn";
            this.fileBtn.Size = new System.Drawing.Size(64, 23);
            this.fileBtn.TabIndex = 8;
            this.fileBtn.Text = "Select";
            this.fileBtn.UseVisualStyleBackColor = true;
            this.fileBtn.Click += new System.EventHandler(this.fileBtn_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "Text files (*.txt)|*.txt";
            // 
            // AnalysisSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(410, 103);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectedFile);
            this.Controls.Add(this.fileBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedFolderText);
            this.Controls.Add(this.selButton);
            this.Controls.Add(this.label1);
            this.Name = "AnalysisSelector";
            this.Text = "NinjaLS - Decryption Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selButton;
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.Label selectedFolderText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedFile;
        private System.Windows.Forms.Button fileBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

