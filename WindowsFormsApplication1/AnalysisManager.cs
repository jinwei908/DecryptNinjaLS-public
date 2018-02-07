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
    public partial class AnalysisManager : Form
    {
        private string currentFolder;
        private List<FileInfo> allFiles;
        private NinjaLSHome homeWindow;
        private List<DecryptedInstance> allDecryptedInstances;

        private const string SALT1 = "LM:TB:BB:WRU:+fwePO%&^*4$(";
        private const string SALT2 = "_:/_77$1857(S%*(&0SeEW";
        private const string SALT3 = "line=wowC++=pwned";

        private const string BASE64_CODES = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"; //all base64 values

        public AnalysisManager()
        {
            InitializeComponent();

        }

        private void browseFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        public void CacheHome(NinjaLSHome nlh)
        {
            homeWindow = nlh;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            AnalysisSelector aSel = new AnalysisSelector();
            aSel.CacheManager(this);
            aSel.Show();
            this.Hide();
        }

        private void closing_close(object sender, FormClosingEventArgs e)
        {
            homeWindow.Show();
        }
    }
}
