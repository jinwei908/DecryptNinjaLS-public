namespace NinjaLSDecryptionManager
{
    partial class AnalysisWindow
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
            this.totalData = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.headerText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tagCountLW = new System.Windows.Forms.ListView();
            this.tagName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tagCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clickCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewPanelGB = new System.Windows.Forms.GroupBox();
            this.viewPanelRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.individualInstancesLW = new System.Windows.Forms.ListView();
            this.instanceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instanceTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clicks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Keystroke = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.filterCB = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.viewPanelGB.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // browseFolder
            // 
            this.browseFolder.HelpRequest += new System.EventHandler(this.browseFolder_HelpRequest);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalData);
            this.groupBox1.Controls.Add(this.debugText);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 73);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Past Analysis";
            // 
            // totalData
            // 
            this.totalData.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalData.Location = new System.Drawing.Point(714, 0);
            this.totalData.Name = "totalData";
            this.totalData.Size = new System.Drawing.Size(176, 20);
            this.totalData.TabIndex = 3;
            this.totalData.Text = "Total Data Instances: 0";
            this.totalData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // debugText
            // 
            this.debugText.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debugText.Location = new System.Drawing.Point(9, 51);
            this.debugText.Name = "debugText";
            this.debugText.Size = new System.Drawing.Size(881, 19);
            this.debugText.TabIndex = 2;
            this.debugText.Text = "Converting Log File: to DataInstances";
            this.debugText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 23);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(881, 23);
            this.progressBar.TabIndex = 1;
            // 
            // headerText
            // 
            this.headerText.Font = new System.Drawing.Font("Source Sans Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.Location = new System.Drawing.Point(12, 9);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(896, 23);
            this.headerText.TabIndex = 1;
            this.headerText.Text = "Analysing Log File: ";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tagCountLW);
            this.groupBox2.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 238);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tags Present in Logs";
            // 
            // tagCountLW
            // 
            this.tagCountLW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tagName,
            this.tagCount,
            this.clickCount});
            this.tagCountLW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tagCountLW.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagCountLW.FullRowSelect = true;
            this.tagCountLW.GridLines = true;
            this.tagCountLW.Location = new System.Drawing.Point(12, 27);
            this.tagCountLW.MultiSelect = false;
            this.tagCountLW.Name = "tagCountLW";
            this.tagCountLW.Size = new System.Drawing.Size(361, 205);
            this.tagCountLW.TabIndex = 1;
            this.tagCountLW.UseCompatibleStateImageBehavior = false;
            this.tagCountLW.View = System.Windows.Forms.View.Details;
            this.tagCountLW.SelectedIndexChanged += new System.EventHandler(this.tagsPresent_change);
            // 
            // tagName
            // 
            this.tagName.Text = "Tag Name";
            this.tagName.Width = 180;
            // 
            // tagCount
            // 
            this.tagCount.Text = "Tag Count";
            this.tagCount.Width = 80;
            // 
            // clickCount
            // 
            this.clickCount.Text = "Clicks Count";
            this.clickCount.Width = 95;
            // 
            // viewPanelGB
            // 
            this.viewPanelGB.Controls.Add(this.filterLabel);
            this.viewPanelGB.Controls.Add(this.filterCB);
            this.viewPanelGB.Controls.Add(this.viewPanelRTB);
            this.viewPanelGB.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewPanelGB.Location = new System.Drawing.Point(12, 358);
            this.viewPanelGB.Name = "viewPanelGB";
            this.viewPanelGB.Size = new System.Drawing.Size(896, 320);
            this.viewPanelGB.TabIndex = 4;
            this.viewPanelGB.TabStop = false;
            this.viewPanelGB.Text = "View Panel: Individual Instance";
            // 
            // viewPanelRTB
            // 
            this.viewPanelRTB.Location = new System.Drawing.Point(8, 35);
            this.viewPanelRTB.Name = "viewPanelRTB";
            this.viewPanelRTB.ReadOnly = true;
            this.viewPanelRTB.Size = new System.Drawing.Size(881, 279);
            this.viewPanelRTB.TabIndex = 0;
            this.viewPanelRTB.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.individualInstancesLW);
            this.groupBox4.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(399, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(509, 238);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Individual Instances";
            // 
            // individualInstancesLW
            // 
            this.individualInstancesLW.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.instanceID,
            this.instanceTags,
            this.dateTime,
            this.Clicks,
            this.Keystroke});
            this.individualInstancesLW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.individualInstancesLW.Font = new System.Drawing.Font("Source Sans Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualInstancesLW.FullRowSelect = true;
            this.individualInstancesLW.GridLines = true;
            this.individualInstancesLW.Location = new System.Drawing.Point(12, 27);
            this.individualInstancesLW.MultiSelect = false;
            this.individualInstancesLW.Name = "individualInstancesLW";
            this.individualInstancesLW.Size = new System.Drawing.Size(491, 205);
            this.individualInstancesLW.TabIndex = 1;
            this.individualInstancesLW.UseCompatibleStateImageBehavior = false;
            this.individualInstancesLW.View = System.Windows.Forms.View.Details;
            this.individualInstancesLW.SelectedIndexChanged += new System.EventHandler(this.individualInstance_change);
            // 
            // instanceID
            // 
            this.instanceID.Text = "ID";
            this.instanceID.Width = 40;
            // 
            // instanceTags
            // 
            this.instanceTags.Text = "Tags";
            this.instanceTags.Width = 190;
            // 
            // dateTime
            // 
            this.dateTime.Text = "Instance Time";
            this.dateTime.Width = 145;
            // 
            // Clicks
            // 
            this.Clicks.Text = "Clicks";
            this.Clicks.Width = 55;
            // 
            // Keystroke
            // 
            this.Keystroke.Text = "Keystrokes";
            // 
            // filterCB
            // 
            this.filterCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterCB.Font = new System.Drawing.Font("Source Sans Pro", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterCB.FormattingEnabled = true;
            this.filterCB.Items.AddRange(new object[] {
            "All",
            "Only Keystrokes > 5",
            "Only Click Counts > 5"});
            this.filterCB.Location = new System.Drawing.Point(697, 2);
            this.filterCB.Name = "filterCB";
            this.filterCB.Size = new System.Drawing.Size(187, 24);
            this.filterCB.TabIndex = 1;
            this.filterCB.SelectedIndexChanged += new System.EventHandler(this.filterCB_SelectedIndexChanged);
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(643, 6);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(51, 20);
            this.filterLabel.TabIndex = 2;
            this.filterLabel.Text = "Filter:";
            // 
            // AnalysisWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(920, 682);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.viewPanelGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.headerText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AnalysisWindow";
            this.Text = "Ninja LS - Console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing_close);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.viewPanelGB.ResumeLayout(false);
            this.viewPanelGB.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog browseFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalData;
        private System.Windows.Forms.Label debugText;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox viewPanelGB;
        private System.Windows.Forms.ListView tagCountLW;
        private System.Windows.Forms.ColumnHeader tagName;
        private System.Windows.Forms.ColumnHeader tagCount;
        private System.Windows.Forms.ColumnHeader clickCount;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView individualInstancesLW;
        private System.Windows.Forms.ColumnHeader instanceID;
        private System.Windows.Forms.ColumnHeader instanceTags;
        private System.Windows.Forms.ColumnHeader dateTime;
        private System.Windows.Forms.ColumnHeader Clicks;
        private System.Windows.Forms.ColumnHeader Keystroke;
        private System.Windows.Forms.RichTextBox viewPanelRTB;
        private System.Windows.Forms.ComboBox filterCB;
        private System.Windows.Forms.Label filterLabel;
    }
}

