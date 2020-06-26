using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//Distributed Computing Pi2 (Server)
namespace PCPP_DC_RZ_Server
{
    public partial class Form1 : Form
    {
        private Color
            red = Color.FromArgb(255, 128, 128),
            yellow = Color.FromArgb(255, 255, 128),
            green = Color.FromArgb(128, 255, 128);

        Color[] col;

        private StringBuilder
            Send_Buff = new StringBuilder(),
            Recv_Buff = new StringBuilder();

        string
            myIP = TSocket.HostAddresses()[1].ToString(), //XP는 [0]
            cIP = TSocket.HostAddresses()[1].ToString();

        private TServer server;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            col = new Color[4] { red, yellow, yellow, green };

            txt_IP.Text = cIP;
        }

        private void btn_me_Click(object sender, EventArgs e)
        {
            txt_IP.Text = cIP = myIP;
            server.ServerClose();
        }

        private void btn_IP_Click(object sender, EventArgs e)
        {
            cIP = txt_IP.Text;
            server.ServerClose();
        }

        private void tim_GetRevMsg_Tick(object sender, EventArgs e)
        {
            if (server == null) return;
            string st = server.GetRcvMsg();
            if (st.Length > 0)
            {
                Recv_Buff.Append(st);
                bool isSTX = Recv_Buff.ToString().StartsWith(TSocket.sSTX());
                bool isETX = st.EndsWith(TSocket.sETX());
                if (!isSTX) Recv_Buff.Clear();
                else if (isSTX && isETX)
                {
                    st = Recv_Buff.ToString().Substring(1, Recv_Buff.Length - 2);
                    string[] Range = st.Split(',');
                    if (Range.Length != 2)
                    {
                        Recv_Buff.Clear();
                        Send_Buff.Clear();
                        return;
                    }
                    txt_Range.Text = Range[0] + " ~ " + Range[1];
                    int start = Convert.ToInt32(Range[0]);
                    int end = Convert.ToInt32(Range[1]);
                    calculate_PI(start, end);
                    Recv_Buff.Clear();
                    Send_Buff.Clear();
                }
            }
        }

        // Calculate π(x)
        private void calculate_PI(int start, int end)
        {
            DateTime ss = DateTime.Now;
            lbl_Cal.Text = "Calculating...";
            lbl_Cal.BackColor = yellow;
            Application.DoEvents();
            
            int[] result = new int[end + 1];
            int step = 37500, i;

            Util.Cal_PI(start, end, ref result);

            lbl_pcnt.Text = result[result.Length - 1].ToString();
            lbl_Cal.Text = "Complete";
            lbl_Cal.BackColor = green;
            string EndTime = Util.Tsec(ss).ToString("F2");
            lbl_Time.Text = EndTime + "sec";

            lbl_Trans.Text = "Sending...";
            lbl_Trans.BackColor = yellow;
            Application.DoEvents();

            Send_Buff.Append(TSocket.sSTX());
            for (i = start; i <= end; i += step)
            {
                Send_Buff.Append(i).Append(':').Append(result[i]).Append(',');
            }
            if (i - step != end) Send_Buff.Append(end).Append(':').Append(result[end]).Append(',');
            Send_Buff.Append(EndTime);
            string CS = lbl_CS.Text = Util.CheckSum(Send_Buff.ToString());
            string st = Send_Buff.Append(CS).Append(TSocket.sETX()).ToString();
            server.ServerSend(st);

            lbl_Trans.Text = "Complete";
            lbl_Trans.BackColor = green;
        }

        
        private void tim_ConStatus_Tick(object sender, EventArgs e)
        {
            if (server == null) server = new TServer();
            else if (server != null)
            {
                lbl_CommReady.Text = server.ServerStatus().ToString();
                lbl_CommReady.BackColor = col[Convert.ToInt32(server.ServerStatus())];
            }

            if (server.ServerStatus() == csConnStatus.Closed)
            {
                try
                {
                    if (cIP.Length - cIP.Replace(".", "").Length != 3)
                    {
                        throw new ArgumentException("e");
                    }
                    server.ServerStartListen(cIP, 7070);
                }
                catch
                {
                    lbl_CommReady.Text = "Wrong IP Adress";
                }
            }
        }
    }
}