using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCPP_DC_Graph_Client_
{
    public partial class Form1 : Form
    {
        private Color
            red = Color.FromArgb(255, 128, 128),
            yellow = Color.FromArgb(255, 255, 128),
            green = Color.FromArgb(128, 255, 128);
        Color[] col;
        private const int max = 30000000;
        private bool power = true, complete1 = false, complete2 = false;
        private StringBuilder pi = new StringBuilder(), zeta = new StringBuilder();
        private string[] pis, zetas;
        string myIP = TSocket.HostAddresses()[1].ToString(); //XP는 [0]
        private TClient client1, client2;

        double xmin = 2, xmax = 800;

        double ymin = 0, ymax = 2000000;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            col = new Color[4] { red, yellow, yellow, green };
            lbl_IP1.Text = "Server1 :: IPv4" + myIP;
            lbl_IP2.Text = "Server2 :: IPv4" + myIP;
        }

        private void tim_GetRecMsg1_Tick(object sender, EventArgs e)
        {
            if (client1 == null || complete1) return;
            string st = client1.GetRcvMsg();
            if (st.Length > 0)
            {
                if (st.EndsWith(TSocket.sETX().ToString()))
                {
                    lbl_Server1T.Text = "Recieving...";
                    lbl_Server1T.BackColor = yellow;
                    pi.Append(st.Substring(0, st.Length - 2));
                    pis = pi.ToString().Split(',');
                    lbl_Server1T.Text = "Complete";
                    lbl_Server1T.BackColor = green;
                    complete1 = true;
                }
                else pi.Append(st);
            }
        }

        private void tim_GetRecMsg2_Tick(object sender, EventArgs e)
        {
            if (client2 == null || complete2) return;
            string st = client2.GetRcvMsg();
            if (st.Length > 0)
            {
                if (st.EndsWith(TSocket.sETX().ToString()))
                {
                    lbl_Server2T.Text = "Recieving...";
                    lbl_Server2T.BackColor = yellow;
                    Application.DoEvents();
                    zeta.Append(st.Substring(0, st.Length - 2));
                    zetas = zeta.ToString().Split(';');
                    lbl_Server2T.Text = "Complete";
                    lbl_Server2T.BackColor = green;
                    complete2 = true;
                }
                else zeta.Append(st);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (client1 == null || client2 == null) return;
            client1.ClientSend(TSocket.sSTX().ToString());
            client2.ClientSend(TSocket.sSTX().ToString());
            Application.DoEvents();
        }
        private void tim_ComStatus_Tick(object sender, EventArgs e)
        {
            // client1 label setting
            if (client1 == null) client1 = new TClient();
            else if(client1 != null)
            {
                lbl_Server1.BackColor = col[Convert.ToInt32(client1.ClientStatus())];
                lbl_Server1.Text = client1.ClientStatus().ToString();
            }
            if (client1.ClientStatus() == csConnStatus.Closed)
                if (power) client1.ClientBeginConnect(myIP, 6060, myIP);

            // client2 label setting
            if (client2 == null) client2 = new TClient();
            else if(client2 != null)
            {
                lbl_Server2.BackColor = col[Convert.ToInt32(client2.ClientStatus())];
                lbl_Server2.Text = client2.ClientStatus().ToString();
            }
            if (client2.ClientStatus() == csConnStatus.Closed)
                if (power) client2.ClientBeginConnect(myIP, 7070, myIP);

            if(complete1 && complete2 && power)
            {
                Graphics grp = pic_Graph.CreateGraphics();
                grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(ymax), ypixel(0));
                grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));
                Pen piPen = new Pen(Color.Blue);
                Pen zetaPen = new Pen(Color.Red);

                double[] dPis = Array.ConvertAll(pis, x => Convert.ToDouble(x));
                double[] dZetas = Array.ConvertAll(zetas, x => Convert.ToDouble(x));
                float y1, y2;
                for (int i = 0; i < zetas.Length - 1; i++)
                {
                    y1 = ypixel(dZetas[i]);
                    y2 = ypixel(dZetas[i + 1]);
                    grp.DrawLine(zetaPen, (float)i, y1, (float)(i + 1), y2);
                    y1 = ypixel(dPis[i]);
                    y2 = ypixel(dPis[i + 1]);
                    grp.DrawLine(piPen, (float)i, y1, (float)(i + 1), y2);
                }
                power = false;
            }
        }

        // convert pixel coordinate
        private float xpixel(double xw)
        {
            return (float)(pic_Graph.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(pic_Graph.ClientSize.Height * (1 - (yw - ymin) / (ymax - ymin)));
        }
    }
}
