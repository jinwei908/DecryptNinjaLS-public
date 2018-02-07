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
    public partial class DecryptionManager : Form
    {
        private string currentFolder;
        private List<FileInfo> allFiles;
        private List<DecryptedInstance> allDecryptedInstances;

        private NinjaLSHome homeWindow;

        private const string SALT1 = "LM:TB:BB:WRU:+fwePO%&^*4$(";
        private const string SALT2 = "_:/_77$1857(S%*(&0SeEW";
        private const string SALT3 = "line=wowC++=pwned";

        private const string BASE64_CODES = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"; //all base64 values

        public DecryptionManager()
        {
            InitializeComponent();
        }

        private void InitializeDecryptionProcess()
        {

        }

        private void browseFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        public void CacheHome(NinjaLSHome hWindow)
        {
            homeWindow = hWindow;
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
                FileInfo[] Files = d.GetFiles("*.log"); //Getting Text files
                allFiles = new List<FileInfo>();
                foreach (FileInfo file in Files)
                {
                    allFiles.Add(file);
                }

                if (allFiles.Count == 0)
                {
                    MessageBox.Show("Error, cannot find any .log files in specified folder");
                    return;
                }

                //do a dialog
                if (MessageBox.Show("There are a total of " + allFiles.Count.ToString() + " log files to be decrypted, are you sure? Pressing yes will start the decryption process.", "Log Decryption", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StartDecryptionProcess();
                }
                   //writing out some comments
            }
        }
        private void StartDecryptionProcess()
        {
            allDecryptedInstances = new List<DecryptedInstance>();
            progressBar1.Maximum = allFiles.Count * 2 + 1;
            ChangeDebugText("Starting Decryption Process...");
            //take string from file
            for (int i = 0; i < allFiles.Count; i++)
            {
                
                //DecryptedInstance di = new DecryptedInstance();
                string fileName = allFiles[i].Name.Remove(allFiles[i].Name.Length-4, 4);
                ChangeDebugText("Decrypting " + (i + 1).ToString() + " out of " + allFiles.Count.ToString() + " files... " + fileName);
                string content = File.ReadAllText(allFiles[i].FullName);
                string decryptedContent = DecryptB64(content);

                DecryptedInstance di = new DecryptedInstance(decryptedContent, fileName + "_decrypted");
                allDecryptedInstances.Add(di);
                ProgressBarIncrement();
            }

            OutputDecryptionProcess();
        }

        private void OutputDecryptionProcess()
        {
            //create directory
            ChangeDebugText("Creating output directory...");
            Directory.CreateDirectory(currentFolder + "\\Decrypted Files");
            ProgressBarIncrement();
            //output files to new directory
            for (int i=0; i<allDecryptedInstances.Count; i++)
            {
                ChangeDebugText("Writing Decrypted Files to Disk... " + (i+1).ToString() + " out of " + allDecryptedInstances.Count);
                File.WriteAllText(currentFolder + "\\Decrypted Files\\" + allDecryptedInstances[i].fileName + ".txt", allDecryptedInstances[i].fileContent);
                ProgressBarIncrement();
            }
            string display = "Decryption Completed! Files Output to: " + currentFolder + "\\Decrypted Files";
            ChangeDebugText(display);
        }

        private string base64_decode(string s)
        {
            byte[] data = Convert.FromBase64String(s);
            string decodedString = Encoding.UTF8.GetString(data);
            return decodedString;
        }

        private string DecryptB64(string s)
        {
            string cacheString = s;
            cacheString = cacheString.Remove(7, 1);
            cacheString = cacheString.Remove(1, 1);
            cacheString = base64_decode(cacheString);
            cacheString = cacheString.Substring(0, cacheString.Length - (SALT2.Length + SALT3.Length + SALT1.Length));
            cacheString = base64_decode(cacheString);
            cacheString = cacheString.Substring(0, cacheString.Length - (SALT1.Length));
            cacheString = cacheString.Remove(7, SALT3.Length);
            cacheString = base64_decode(cacheString);
            cacheString = cacheString.Substring(SALT1.Length); //cut away first salt1 length
            cacheString = cacheString.Substring(0, cacheString.Length - SALT2.Length - SALT3.Length);
            cacheString = cacheString.Replace("[ENTER]", "\r\n");
            cacheString = cacheString.Replace("[Enter]", "\r\n");
            cacheString = cacheString.Replace("[ENT]", "\r\n");
            return cacheString;
        }

        private void ChangeDebugText(string text)
        {
            debugText.Text = text;
        }

        private void ProgressBarIncrement()
        {
            progressBar1.PerformStep();
        }

        private void closing_event(object sender, FormClosingEventArgs e)
        {
            homeWindow.Show();
        }
    }

    public struct DecryptedInstance
    {
        public string fileContent;
        public string fileName;

        public DecryptedInstance(string content, string fName)
        {
            fileContent = content;
            fileName = fName;
        }
    }
}
