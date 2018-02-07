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
    public partial class NinjaLSHome : Form
    {
        private string currentFolder;
        private List<FileInfo> allFiles;
        private List<DecryptedInstance> allDecryptedInstances;

        private const string SALT1 = "LM:TB:BB:WRU:+fwePO%&^*4$(";
        private const string SALT2 = "_:/_77$1857(S%*(&0SeEW";
        private const string SALT3 = "line=wowC++=pwned";

        private const string BASE64_CODES = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"; //all base64 values

        public NinjaLSHome()
        {
            InitializeComponent();

        }

        private void browseFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        

        private void decrypt_Click(object sender, EventArgs e)
        {
            DecryptionManager dm = new DecryptionManager();
            dm.CacheHome(this);
            dm.Show();
            this.Hide();
        }

        private void analyzeBtn_Click(object sender, EventArgs e)
        {
            AnalysisManager am = new AnalysisManager();
            am.CacheHome(this);
            am.Show();
            this.Hide();
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            ServerChecker sc = new ServerChecker();
            sc.Show();
            this.Hide();
            sc.SetCache(this);
            sc.InitServerChecker();
            
        }
    }
}
