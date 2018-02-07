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
    public partial class AnalysisWindow : Form
    {
        private string currentFolderPath;
        private string currentFilePath;
        private FileInfo currentFile;
        private List<FileInfo> allFilesList;
        private AnalysisSelector selectorWindow;
        private InstanceHeader currentHeader;
        private AnalysisInstance[] allAnalysisInstances;
        private Dictionary<string, List<int>> tagCountData;
        private int convertedFilesCount;
        private bool isFile;

        private string currentTag;
        private Dictionary<string, List<int>> tagsAnalysisInstances;

        //individual controllers
        private int currentSelectedIndex;
        private bool showingIndividual;
        private string currFilter;

        public AnalysisWindow()
        {
            InitializeComponent();
            currentTag = "";
            tagsAnalysisInstances = new Dictionary<string, List<int>>();
            currentHeader = new InstanceHeader("", "", DateTime.Now);
            currentSelectedIndex = -1;
            showingIndividual = false;
            filterLabel.Visible = false;
            filterCB.Visible = false;
        }

        public void InitializeAnalysis(FileInfo fileInfo, string file)
        {
            
            isFile = true;
            currentFilePath = file;
            convertedFilesCount = 0;
            currentFile = fileInfo;
            tagCountData = new Dictionary<string, List<int>>();
            allAnalysisInstances = new AnalysisInstance[0];
            StartAnalysingFile();
        }

        public void InitializeAnalysis(FileInfo[] allFileInfo, string folderPath)
        {
            isFile = false;
            convertedFilesCount = 0;
            currentFolderPath = folderPath;
            tagCountData = new Dictionary<string, List<int>>();
            allAnalysisInstances = new AnalysisInstance[0];
            StartAnalysingFolder();
        }

        private void StartAnalysingFile()
        {
            string toAnalyze = File.ReadAllText(currentFile.FullName);
            //start read
            string[] rawInstances = ConvertTextToRawInstances(toAnalyze);
            progressBar.Maximum = rawInstances.Length;
            allAnalysisInstances = ConvertRawInstancesToAnalysisInstances(rawInstances);
            AnalyzeTagCountData();
            DisplayTagCountData();
            DisplayIndividualInstances();
        }

        private void StartAnalysingFolder()
        {
            //get all files
            DirectoryInfo d = new DirectoryInfo(currentFolderPath);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            allFilesList = new List<FileInfo>();
            foreach (FileInfo file in Files)
            {
                allFilesList.Add(file);
            }

            if (allFilesList.Count == 0)
            {
                MessageBox.Show("Error, cannot find any .log files in specified folder");
                return;
            }

            List<string> rawInstanceList = new List<string>();
            for(int i=0; i<allFilesList.Count; i++)
            {
                string toAnalyze = File.ReadAllText(allFilesList[i].FullName);
                //start read
                string[] rawInstances = ConvertTextToRawInstances(toAnalyze);
                if(i > 0)
                {
                    List<string> rawInstanceMiniList = new List<string>(rawInstances);
                    rawInstanceMiniList.RemoveAt(0); //remove header instance
                    rawInstanceList.AddRange(rawInstanceMiniList);
                } else
                {
                    rawInstanceList.AddRange(rawInstances);
                }
                
                
            }
            progressBar.Maximum = rawInstanceList.Count;
            allAnalysisInstances = ConvertRawInstancesToAnalysisInstances(rawInstanceList.ToArray());
            AnalyzeTagCountData();
            DisplayTagCountData();
            DisplayIndividualInstances();
        }

        private void AnalyzeTagCountData()
        {
            for (int i = 0; i<allAnalysisInstances.Length; i++)
            {
                foreach (string tag in allAnalysisInstances[i].allTags)
                {
                    if (tagCountData.ContainsKey(tag))
                    {
                        tagCountData[tag][0] = tagCountData[tag][0] + 1;
                        tagCountData[tag][1] = tagCountData[tag][1] + allAnalysisInstances[i].clickCounts;
                    }
                    else
                    {
                        List<int> data = new List<int>();
                        data.Add(1);
                        data.Add(allAnalysisInstances[i].clickCounts);
                        tagCountData.Add(tag, data);
                    }
                }
            }
        }

        private void DisplayTagCountData()
        {
            tagCountLW.Items.Clear();
            //sort by number
            foreach(string key in tagCountData.Keys)
            {
                tagCountLW.Items.Add(new ListViewItem(new string[] { key, tagCountData[key][0].ToString(), tagCountData[key][1].ToString() }));
            }
            
        }

        private void DisplayIndividualInstances()
        {
            individualInstancesLW.Items.Clear();
            //sort by number
            for(int i=0; i<allAnalysisInstances.Length; i++)
            {
                string tagString = "";
                foreach(string tag in allAnalysisInstances[i].allTags)
                {
                    tagString += tag + ",";
                }
                tagString = tagString.TrimEnd(',');
                individualInstancesLW.Items.Add(new ListViewItem(new string[] { (i+1).ToString(), tagString, allAnalysisInstances[i].instanceTime.ToString(), allAnalysisInstances[i].clickCounts.ToString(), allAnalysisInstances[i].instanceContent.Length.ToString() }));
            }

        }

        private string[] ConvertTextToRawInstances(string stringA)
        {
            debugText.Text = "Converting File: " + currentFilePath + " to Raw Instances";
            string[] rawInstances = stringA.Split(new string[] { "(--------)" }, StringSplitOptions.None);
            return rawInstances;
        }


        private AnalysisInstance[] ConvertRawInstancesToAnalysisInstances(string[] rawInstances)
        {
            List<AnalysisInstance> allInstances = new List<AnalysisInstance>();
            //split entire data
            
            progressBar.Increment(1);
            //if currentHeader == null, get header from first packet
            if(currentHeader.fromComputer == "")
            {
                string workingString = rawInstances[0];
                int pFrom = workingString.IndexOf("[") + 1;
                int pTo = workingString.IndexOf("]", 2);
                string time = workingString.Substring(pFrom, pTo - pFrom);
                //MessageBox.Show(time);

                pFrom = workingString.IndexOf("FROM: ") + 6;
                pTo = workingString.IndexOf(" | ");
                string computer = workingString.Substring(pFrom, pTo - pFrom);
                //MessageBox.Show(computer);

                pFrom = workingString.IndexOf("User: ") + 6;
                pTo = workingString.IndexOf("\n");
                string user = workingString.Substring(pFrom, pTo - pFrom);
                //MessageBox.Show(user);

                currentHeader = new InstanceHeader(computer, user, DateTime.Parse(time));
            }

            for(int i=1; i< rawInstances.Length; i++)
            {
                try { 
                    debugText.Text = "Converting Raw Instances to Analysis Instances ( " + (convertedFilesCount + 1).ToString() + " out of " + (rawInstances.Length-1).ToString() + " )";
                    progressBar.Increment(1);
                    int currentIndex = 0;

                    string workingString = rawInstances[i];
                    int pFrom = workingString.IndexOf("---*[") + 5;
                    int pTo = workingString.IndexOf("]*---");
                    string allTags = workingString.Substring(pFrom, pTo - pFrom);
                    string[] tagsArray = allTags.Split(new string[] { ", " }, StringSplitOptions.None);
                    currentIndex = pFrom + allTags.Length + 5 + 2;

                    pFrom = workingString.IndexOf("TIME=", currentIndex) + 5;
                    pTo = workingString.IndexOf("\r\n", currentIndex);
                    string time = workingString.Substring(pFrom, pTo - pFrom);
                    DateTime dTime = DateTime.Parse(time);
                
                    currentIndex += time.Length + 5 + 2;

                    pFrom = workingString.IndexOf("[LMB]Current Window: ", currentIndex) + 21;
                    pTo = workingString.IndexOf("\r\n", currentIndex);
                    string currentWindow = workingString.Substring(pFrom, pTo - pFrom);
                    currentIndex += currentWindow.Length + 5 + 2 + 16;

                    pFrom = currentIndex;
                    pTo = workingString.IndexOf("Click Count Detected", currentIndex);
                    string currentContent = workingString.Substring(pFrom, pTo - pFrom);
                    currentIndex += currentContent.Length-2;

                    pFrom = workingString.IndexOf("Click Count Detected: ", currentIndex) + 22;
                    pTo = workingString.IndexOf("\r\n", pFrom);
                    string clickCount = "";
                   // MessageBox.Show(pTo.ToString() + " " +pFrom.ToString());
                    if (pTo != -1)
                    {
                        clickCount = workingString.Substring(pFrom, pTo - pFrom);
                    } else
                    {
                        clickCount = workingString.Substring(pFrom);
                    }
                    int clickCountInt = int.Parse(clickCount);

                    allInstances.Add(new AnalysisInstance(tagsArray, dTime, currentWindow, currentContent, clickCountInt));

                    convertedFilesCount++;
                    totalData.Text = "Total Data Instance: " + (allAnalysisInstances.Length + allInstances.Count).ToString();
                } catch (Exception ex)
                {
                    MessageBox.Show("Error Errored at Index: " + i.ToString() + " : " + rawInstances[i] + " " + ex.Message);
                }
               // MessageBox.Show("New Instance:\nTagCount: " + allInstances[i-1].allTags.Length.ToString() + "\nTime: " + allInstances[i - 1].instanceTime.ToString() + "\nCurrent Window: " + allInstances[i - 1].currentWindow + "\nCurrent Content: " + allInstances[i - 1].instanceContent + "\nClick Count: " + allInstances[i - 1].clickCounts.ToString());
            }

            //MessageBox.Show("Header:\nTime: " + currentHeader.sentDateTime.ToString() + " \nComputer: " + currentHeader.fromComputer + "\nUser: " + currentHeader.fromUser);
            //analyze these datas

            return allInstances.ToArray();
        }

        private void browseFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        public void CacheSelector(AnalysisSelector sw)
        {
            selectorWindow = sw;
        }


        private void closing_close(object sender, FormClosingEventArgs e)
        {
            selectorWindow.Close();
        }

        private void tagsPresent_change(object sender, EventArgs e)
        {
            //iterate through all packets, with same tag, and group them
            if (tagCountLW.SelectedIndices.Count <= 0)
            {
                return;
            }
            else
            {
                showingIndividual = false;
                currentTag = tagCountLW.Items[tagCountLW.SelectedIndices[0]].SubItems[0].Text.ToString();
                filterLabel.Visible = true;
                filterCB.Visible = true;
                filterCB.SelectedIndex = 0;
                currFilter = "All";
                ShowTagPackets(currFilter);
            }
        }

        private void individualInstance_change(object sender, EventArgs e)
        {
            //iterate individual package and put together the information in a easy to view format
            if(individualInstancesLW.SelectedIndices.Count <= 0)
            {
                return;
            }
            else
            {
                showingIndividual = true;
                filterLabel.Visible = false;
                filterCB.Visible = false;
                currentSelectedIndex = individualInstancesLW.SelectedIndices[0];
                ShowIndividualPacket();
            }

        }

        

        private void ShowIndividualPacket()
        {
            if(currentSelectedIndex < 0)
            {
                return;
            }
            viewPanelRTB.Text = "";
            viewPanelGB.Text = "View Panel: Individual Instance";
            string tagString = "";
            foreach (string tag in allAnalysisInstances[currentSelectedIndex].allTags)
            {
                tagString += tag + ",";
            }
            tagString = tagString.TrimEnd(',');

            AppendBox.AppendText(viewPanelRTB, "Current Window:", Color.Black, new Font("Source Sans Pro", 16.0f, FontStyle.Bold));
            AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[currentSelectedIndex].currentWindow + "\n", Color.Black, new Font("Source Sans Pro", 16.0f, FontStyle.Regular));
            AppendBox.AppendText(viewPanelRTB, "Time Recorded:", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
            AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[currentSelectedIndex].instanceTime.ToString() + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
            AppendBox.AppendText(viewPanelRTB, "Tags:", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
            AppendBox.AppendText(viewPanelRTB, tagString + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
            AppendBox.AppendText(viewPanelRTB, "Click Count:", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
            AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[currentSelectedIndex].clickCounts.ToString() + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
            AppendBox.AppendText(viewPanelRTB, "Keystroke Content:\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
            AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[currentSelectedIndex].instanceContent + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));

        }

        private void ShowTagPackets(string currentFilter)
        {
            if (currentTag == "")
            {
                return;
            }
            viewPanelRTB.Text = "";
            viewPanelGB.Text = "View Panel: Instances with Tag - " + currentTag;
            string tagString = "";
            //check if the tag dictionary has the tag
            //MessageBox.Show(tagsAnalysisInstances.ContainsKey(currentTag).ToString() + " " + tagsAnalysisInstances.Count.ToString());
            if (!tagsAnalysisInstances.ContainsKey(currentTag))
            {
                List<int> listOfAnalysis = new List<int>();
                for(int i=0; i<allAnalysisInstances.Length; i++)
                {
                    if (CheckStringArrayContains(allAnalysisInstances[i].allTags,currentTag))
                    {
                        listOfAnalysis.Add(i);
                    }
                }
                tagsAnalysisInstances.Add(currentTag, listOfAnalysis);
            }

            
            AppendBox.AppendText(viewPanelRTB, "Displaying all instances with tag: " + currentTag + "\n", Color.Black, new Font("Source Sans Pro", 20.0f, FontStyle.Bold));

            List<int> analysisList = tagsAnalysisInstances[currentTag];
            progressBar.Value = 0;
            progressBar.Maximum = analysisList.Count;
            for (int i=0; i<allAnalysisInstances.Length; i++)
            {
                if (analysisList.Contains(i))
                {
                    progressBar.Increment(1);
                    debugText.Text = "Sifting through the packets to get packets with tag: " + currentTag;
                    switch (currentFilter) {
                        case "Only Keystrokes > 5":
                            if (allAnalysisInstances[i].instanceContent.Length <= 5)
                            {
                                continue;
                            }
                            break;

                        case "Only Click Counts > 5":
                            if (allAnalysisInstances[i].clickCounts <= 5)
                            {
                                continue;
                            }
                            break;
                    }


                    tagString = "";
                    foreach (string tag in allAnalysisInstances[i].allTags)
                    {
                        tagString += tag + ",";
                    }
                    tagString = tagString.TrimEnd(',');
                    //then do
                    AppendBox.AppendText(viewPanelRTB, "Current Window:", Color.Black, new Font("Source Sans Pro", 16.0f, FontStyle.Bold));
                    AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[i].currentWindow + "\n", Color.Black, new Font("Source Sans Pro", 16.0f, FontStyle.Regular));
                    AppendBox.AppendText(viewPanelRTB, "Time Recorded:", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
                    AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[i].instanceTime.ToString() + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
                    AppendBox.AppendText(viewPanelRTB, "Tags:", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
                    AppendBox.AppendText(viewPanelRTB, tagString + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
                    AppendBox.AppendText(viewPanelRTB, "Click Count:", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
                    AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[i].clickCounts.ToString() + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
                    AppendBox.AppendText(viewPanelRTB, "Keystroke Content:\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Bold));
                    AppendBox.AppendText(viewPanelRTB, allAnalysisInstances[i].instanceContent + "\n", Color.Black, new Font("Source Sans Pro", 14.0f, FontStyle.Regular));
                }
            }
            //double loop

            

        }

        private bool CheckStringArrayContains(string[] tags, string tag)
        {
            foreach(string st in tags)
            {
                if(st == tag)
                {
                    return true;
                }
            }
            return false;
        }

        private void htmlTextbox1_Load(object sender, EventArgs e)
        {

        }

        private void html_textChanged(object sender, EventArgs e)
        {
            
        }

        private void htmlTextBox_Focus(object sender, EventArgs e)
        {
            //headerText.Focus();
        }

        private void filterCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!showingIndividual)
            {
                if (filterCB.Items[filterCB.SelectedIndex].ToString() != currFilter)
                {
                    //then change
                    currFilter = filterCB.Items[filterCB.SelectedIndex].ToString();
                    ShowTagPackets(currFilter);
                }
            }
        }
    }

    public static class AppendBox
    {
        public static void AppendText(this RichTextBox box, string text, Color color, Font font)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.SelectionFont = font;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

    public struct AnalysisHeader
    {

    }

    public struct InstanceHeader
    {
        public string fromComputer;
        public string fromUser;
        public DateTime sentDateTime;

        public InstanceHeader (string fComputer, string fUser, DateTime sDT)
        {
            fromComputer = fComputer;
            fromUser = fUser;
            sentDateTime = sDT;
        }
    }

    public struct AnalysisInstance
    {
        public string[] allTags;
        public DateTime instanceTime;
        public string currentWindow;
        public string instanceContent;
        public int clickCounts;

        public AnalysisInstance (string[] aT, DateTime iTime, string cWindow, string content, int cCounts)
        {
            allTags = aT;
            instanceTime = iTime;
            currentWindow = cWindow;
            instanceContent = content;
            clickCounts = cCounts;
        }
    }

}
