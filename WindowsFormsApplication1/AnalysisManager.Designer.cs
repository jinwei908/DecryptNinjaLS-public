namespace NinjaLSDecryptionManager
{
    partial class AnalysisManager
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
            this.browseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.analysisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.computerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateAnalysed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateGenerated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.analysisType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseFolder
            // 
            this.browseFolder.HelpRequest += new System.EventHandler(this.browseFolder_HelpRequest);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Past Analysis";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.analysisID,
            this.computerName,
            this.userName,
            this.dateAnalysed,
            this.dateGenerated,
            this.analysisType});
            this.listView1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 33);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(653, 368);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // analysisID
            // 
            this.analysisID.Text = "ID";
            this.analysisID.Width = 40;
            // 
            // computerName
            // 
            this.computerName.Text = "Computer Name";
            this.computerName.Width = 150;
            // 
            // userName
            // 
            this.userName.Text = "User Name";
            this.userName.Width = 120;
            // 
            // dateAnalysed
            // 
            this.dateAnalysed.Text = "Date Analyzed";
            this.dateAnalysed.Width = 150;
            // 
            // dateGenerated
            // 
            this.dateGenerated.Text = "Log File Date";
            this.dateGenerated.Width = 150;
            // 
            // analysisType
            // 
            this.analysisType.Text = "Type";
            this.analysisType.Width = 50;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(12, 425);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(665, 38);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Create New Analysis";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // AnalysisManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(689, 469);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnalysisManager";
            this.Text = "Ninja LS - Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing_close);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader analysisID;
        private System.Windows.Forms.ColumnHeader computerName;
        private System.Windows.Forms.ColumnHeader userName;
        private System.Windows.Forms.ColumnHeader dateAnalysed;
        private System.Windows.Forms.ColumnHeader dateGenerated;
        private System.Windows.Forms.ColumnHeader analysisType;
        private System.Windows.Forms.Button createBtn;
    }
}

