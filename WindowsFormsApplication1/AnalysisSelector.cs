using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NinjaLSDecryptionManager
{
    public partial class AnalysisSelector : Form
    {
        private string currentFolder;
        private string currentFile;
        private FileInfo currentFileInfo;
        private List<FileInfo> allFiles;
        private List<DecryptedInstance> allDecryptedInstances;

        private AnalysisManager amWindow;

        private const string SALT1 = "LM:TB:BB:WRU:+fwePO%&^*4$(";
        private const string SALT2 = "_:/_77$1857(S%*(&0SeEW";
        private const string SALT3 = "line=wowC++=pwned";

        private const string BASE64_CODES = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"; //all base64 values

        public AnalysisSelector()
        {
            InitializeComponent();
        }

        private void InitializeDecryptionProcess()
        {

        }

        private void browseFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        public void CacheManager(AnalysisManager am)
        {
            amWindow = am;
        }

        private void selButton_Click(object sender, EventArgs e)
        {
            DialogResult result = browseFolder.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentFolder = browseFolder.SelectedPath;
                selectedFolderText.Text = currentFolder;

                //get all files
                DirectoryInfo d = new DirectoryInfo(currentFolder);//Assuming Test is your Folder
                FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
                allFiles = new List<FileInfo>();
                foreach (FileInfo file in Files)
                {
                    allFiles.Add(file);
                }

                if(allFiles.Count == 0)
                {
                    MessageBox.Show("Error, cannot find any .txt files in specified folder");
                    return;
                }

                //do a dialog
                if (MessageBox.Show("There are a total of " + allFiles.Count.ToString() + " log files to be decrypted, are you sure? Pressing yes will start the Analysis process.", "Log Analysis", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AnalysisWindow aw = new AnalysisWindow();
                    this.Hide();
                    aw.Show();
                    aw.CacheSelector(this);
                    aw.InitializeAnalysis(allFiles.ToArray(), currentFolder);
                    
                    
                    
                }
                   //writing out some comments
            }
        }

        private void closing_event(object sender, FormClosingEventArgs e)
        {
            amWindow.Show();
        }

        private void fileBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                currentFile = openFileDialog.FileName;
                selectedFile.Text = currentFile;
                currentFileInfo = new FileInfo(currentFile);
                if (MessageBox.Show("Are you sure you want to analyse this file: " + currentFile + ". Pressing yes will start the Analysis process.", "Log Analysis", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AnalysisWindow aw = new AnalysisWindow();
                    aw.InitializeAnalysis(currentFileInfo, currentFile);
                    aw.CacheSelector(this);
                    aw.Show();
                    this.Hide();
                }
            }
        }
    }


}
