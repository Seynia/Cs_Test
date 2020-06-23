using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

//Distribution Computing Pi (Server)
namespace PCPP_DC_RZ_Server
{
    public partial class Form1 : Form
    {
        private Color
            red = Color.FromArgb(255, 128, 128),
            yellow = Color.FromArgb(255, 255, 128),
            green = Color.FromArgb(128, 255, 128);
        Color[] col;
        private const int max = 30000000;
        private bool power = true, calculate = false;
        private StringBuilder buff = new StringBuilder(), result = new StringBuilder();
        private TServer server;
        string myIP = TSocket.HostAddresses()[1].ToString(); //XP는 [0]

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            col = new Color[4] { red, yellow, yellow, green };
            lbl_IP.Text = "myIPv4: " + myIP;
        }

        public bool isPrime(int n)
        {
            int i, num = (int)Math.Sqrt(n) + 1;
            if (n < 2) return false;
            if (n == 2) return true;
            for (i = 2; i < num; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Calculate Pi in Sieve of Eratosthenes
        public void EPI()
        {
            while (server.GetRcvMsg() != TSocket.sSTX().ToString());
            DateTime start = DateTime.Now;
            bool[] prime = new bool[max + 1];
            lbl_Cal.Text = "Calculating...";
            lbl_Cal.BackColor = yellow;
            int i, j, pcnt = 0;
            for (i = 2; i <= max; i++)
            {
                if (prime[i] == false)
                {
                    pcnt++;
                    for (j = i * 2; j <= max; j += i)
                    {
                        prime[j] = true;
                    }
                }
                //StreamWriter sw = new StreamWriter("C:\\Users\\d2_h10s\\Desktop\\PI.txt", true);
                //sw.WriteLine(i.ToString("D8") + "  :  " + pcnt.ToString());
                //sw.Close();
                result.Append(pcnt).Append(";");
            }
            lbl_pcnt.Text = pcnt.ToString();
            lbl_Cal.Text = "Complete";
            lbl_Cal.BackColor = green;
            lbl_Time.Text = DateTime.Now.Subtract(start).Milliseconds.ToString() + "ms";
            calculate = true;
        }


        private void tim_ConStatus_Tick(object sender, EventArgs e)
        {
            if (server == null) server = new TServer(EPI);
            else if (server != null)
            {
                lbl_CommReady.Text = server.ServerStatus().ToString();
                lbl_CommReady.BackColor = col[Convert.ToInt32(server.ServerStatus())];
            }
            
            if (server.ServerStatus() == csConnStatus.Closed)
            {
                if (power) server.ServerStartListen(myIP, 6060);
            }
            else if(server.ServerStatus() == csConnStatus.Connected)
            {
                if (calculate && power)
                {
                    lbl_Trans.Text = "Sending...";
                    lbl_Trans.BackColor = yellow;
                    Application.DoEvents();
                    int step = 37500;
                    for (int i = 0; i < result.Length; i += step)
                    {
                        buff.Append(result[i]).Append(',');
                    }
                    server.ServerSend(buff.ToString() + TSocket.sETX());
                    lbl_Trans.Text = "Complete";
                    lbl_Trans.BackColor = green;
                    power = false;
                }
            }
        }
    }
}
