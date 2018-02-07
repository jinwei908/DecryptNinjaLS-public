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
using System.Net.NetworkInformation;
using System.Net.Sockets;

//using System.Windows.Forms;


namespace NinjaLSDecryptionManager
{
    public partial class ServerChecker : Form
    {

        private bool serverUp = true;

        private const int PING_INTERVAL = 30;
        private const int ECHO_INSTANCES = 5;
        private const string HOST_IP = "0.0.0.0";
        private const string PORT_NUMBER = "0000";
        private const int TIME_OUT = 1500;

        System.Media.SoundPlayer sPlayer;
        System.Windows.Forms.Timer pingTimer =  new Timer();

        private int lastPing;

        private NinjaLSHome homeCache;

        public ServerChecker()
        {
            InitializeComponent();
            
        }

        public void InitServerChecker()
        {

            serverUp = true;
            lastPing = -2;
            progressBar.Maximum = PING_INTERVAL;
            progressBar.Increment(PING_INTERVAL - 2);
            pingTimer = new Timer();
            pingTimer.Tick += new EventHandler(TimerEventProcessor);
            pingTimer.Interval = 1000;
            pingTimer.Start();
        }

        public void SetCache(NinjaLSHome nlh)
        {
            homeCache = nlh;
        }

        private void TimerEventProcessor(Object myObject,
                                           EventArgs myEventArgs)
        {

            // Restarts the timer and increments the counter.
            lastPing += 1;
            pingTimer.Enabled = true;

            progressBar.Increment(1);
            if (serverUp) { 
                debugText.Text = "Pinging " + HOST_IP + ":" + PORT_NUMBER + "... in " + Math.Abs(lastPing).ToString() + " seconds";
            }

            if (lastPing >= 0)
            {
                progressBar.Value = 0;
                PingServer();
                lastPing = -PING_INTERVAL;
            }
        }

        private void PingServer()
        {

            long totalTime = 0;
            bool successPing = false;
            Ping pingSender = new Ping();

            pingTimer.Enabled = false;

            debugText.Text = "Currently Pinging " + HOST_IP + ":" + PORT_NUMBER + "...";

            /*for (int i = 0; i < ECHO_INSTANCES; i++)
            {
                PingReply reply = pingSender.Send(HOST_IP + ":" + PORT_NUMBER, TIME_OUT);
                if (reply.Status == IPStatus.Success)
                {
                    totalTime += reply.RoundtripTime;
                    successPing = true;
                }
            }*/

            TcpClient tcpClient = new TcpClient();
            try
            {
                tcpClient.SendTimeout = 3000;
                tcpClient.ReceiveTimeout = 3000;
                Console.WriteLine(tcpClient.SendTimeout);
                tcpClient.Connect(HOST_IP, int.Parse(PORT_NUMBER));
                successPing = true;
            }
            catch (Exception)
            {
                successPing = false;
                Console.WriteLine("Port closed");
            }

            tcpClient.Close();

            pingTimer.Enabled = true;
            if (!successPing)
            {
                serverUp = false;
                outputText.AppendText("***** SERVER / PORT FORWARDING ERROR - " + DateTime.Now.ToString() + " *****\n");
                SoundTheAlarm();
            }
            else
            {
                //log it in
                serverUp = true;
                statusText.Text = "LIVE";
                statusText.BackColor = Color.Yellow;
                statusText.ForeColor = Color.Black;
                outputText.AppendText("* SERVER UP / PORT FORWARDING WORKS - " + DateTime.Now.ToString() + " *\n");
            }

            

        }


        private void SoundTheAlarm()
        {
            statusText.Text = "SERVER IS UNREACHABLE";
            statusText.BackColor = Color.Red;
            statusText.ForeColor = Color.White;
            sPlayer = new System.Media.SoundPlayer(@"C:\Users\User\Desktop\Assets\Annoying_Alarm.wav");
            sPlayer.PlayLooping();

            debugText.Text = "HOST: " + HOST_IP + ":" + PORT_NUMBER + " IS UNREACHABLE, PLEASE CHECK PORT FORWARDING AND RESTART KALI ASAP";
        }

        private void StopSoundAlarm()
        {
            sPlayer.Stop();
        }

        private void browseFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        

        private void decrypt_Click(object sender, EventArgs e)
        {
            
        }

        private void analyzeBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void statusButton_Click(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            StopSoundAlarm();
            progressBar.Value = 0;
            PingServer();
            lastPing = -PING_INTERVAL;
        }

        private void check_close(object sender, FormClosingEventArgs e)
        {
            pingTimer.Stop();
            homeCache.Show();
        }
    }
}
