using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace tClient
{
    public partial class Form1 : Form
    {
        private TClient clientChat; //채팅용
        private TClient clientCopy; //원위치복사용
        private TClient clientCopyS; //원위치복사용(Server측)
        private TClient clientComm; //비트통신용
        private bool power = false; // 직접 close를 누른 시에는 재시도 하지 않도록 함
        private string rbuffcir = "";   // 원위치송신메시지 저장버퍼

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string hostname = TSocket.HostName();
            IPAddress[] addrs = TSocket.HostAddresses();

            string st = hostname + "\r\n";
            for (int i = 0; i < addrs.Length; i++)
            {
                st = st + addrs[i].ToString() + "\r\n";
            }

            lblComInfo.Text = st;
        }

        private void timConnStatus_Tick(object sender, EventArgs e)
        {
            if (clientChat == null) { lblConnChat.Text = "Chat : " + "NULL"; }
            else
            {
                csConnStatus conn = clientChat.ClientStatus();
                lblConnChat.Text = "Chat : " + conn.ToString();
            }

            if (clientCopy == null) { lblConnCopy.Text = "Copy : " + "NULL"; }
            else
            {
                csConnStatus conn = clientCopy.ClientStatus();
                lblConnCopy.Text = "Copy : " + conn.ToString();
            }

            if (clientComm == null) { lblConnComm.Text = "Comm : " + "NULL"; }
            else
            {
                csConnStatus conn = clientComm.ClientStatus();
                lblConnComm.Text = "Comm : " + conn.ToString();
            }
            //==================================추가===========================================
            if (power && clientChat != null)
            {
                string serverIP = txtServerIP.Text;
                string clientIP = TSocket.HostAddresses()[1].ToString();

                if (clientChat.ClientStatus() == csConnStatus.Closed)
                    clientChat.ClientBeginConnect(serverIP, 5000, clientIP);
                if (clientCopy.ClientStatus() == csConnStatus.Closed) 
                    clientCopy.ClientBeginConnect(serverIP, 5001, clientIP);
                if (clientComm.ClientStatus() == csConnStatus.Closed)
                    clientComm.ClientBeginConnect(serverIP, 5002, clientIP);
                if (clientCopyS.ClientStatus() == csConnStatus.Closed)
                    clientCopyS.ClientBeginConnect(serverIP, 5003, clientIP);
            }
            //=================================================================================
        }

        private void btnServerLoopBack_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = "127.0.0.1";
        }

        private void btnServerMe_Click(object sender, EventArgs e)
        {
            txtServerIP.Text = TSocket.HostAddresses()[1].ToString();//XP는 [0]
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            power = true;
            string serverIP = txtServerIP.Text;
            string clientIP = TSocket.HostAddresses()[1].ToString(); //XP는 [0]

            if (clientChat == null) clientChat = new TClient();
            clientChat.ClientBeginConnect(serverIP, 5000, clientIP);   // 1024~65535 추천

            if (clientCopy == null) clientCopy = new TClient();
            clientCopy.ClientBeginConnect(serverIP, 5001, clientIP);   // 1024~65535 추천

            if (clientComm == null) clientComm = new TClient();
            clientComm.ClientBeginConnect(serverIP, 5002, clientIP);   // 1024~65535 추천
            //==================================추가===========================================
            if (clientCopyS == null) clientCopyS = new TClient(CirclePosDataArrived);
            clientCopyS.ClientBeginConnect(serverIP, 5003, clientIP);
            //=================================================================================
        }
        //==================================추가===========================================
        private void CirclePosDataArrived()
        {
            while (true)
            {
                rbuffcir += clientCopyS.GetRcvMsg();
                int idx1 = rbuffcir.IndexOf(TSocket.sSTX());
                if (idx1 < 0) break;
                int idx2 = rbuffcir.IndexOf(TSocket.sETX(), idx1);

                if (idx1 >= 0 && idx2 > idx1)
                {
                    string xypos = rbuffcir.Substring(idx1 + 1, idx2 - idx1 - 1);
                    char[] sep = new char[] { ',' };
                    string[] xy = xypos.Split(sep);
                    lblO.Left = Convert.ToInt32(xy[0]);
                    lblO.Top = Convert.ToInt32(xy[1]);
                    rbuffcir = rbuffcir.Substring(idx2 + 1);
                }
                else
                    break;
            }
        }
        //=================================================================================
        private void btnClose_Click(object sender, EventArgs e)
        {
            power = false;
            if (clientChat != null) clientChat.ClientClose();
            if (clientCopy != null) clientCopy.ClientClose();
            if (clientComm != null) clientComm.ClientClose();
            //==================================추가===========================================
            if (clientCopyS != null) clientCopy.ClientClose();
            //=================================================================================
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (clientChat == null) return;

            string st = txtSend.Text.Trim();
            if (st.Length <= 0) return;

            clientChat.ClientSend(st + "\r\n");
            txtDialog.Text += "[Me] " + st + "\r\n";
            txtSend.Text = "";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') btnSend.PerformClick();
        }

        private void timGetRcvMsg_Tick(object sender, EventArgs e)
        {
            if (clientChat == null) return;
            string st = clientChat.GetRcvMsg();
            if (st.Length > 0) txtDialog.Text += st;
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            lblO.Left = e.X;
            lblO.Top = e.Y;

            string st = TSocket.sSTX() + Convert.ToString(e.X) +
                        "," + Convert.ToString(e.Y) + TSocket.sETX();
            clientCopy.ClientSend(st);
        }

        private void btnReadBits_Click(object sender, EventArgs e)
        {
            if (clientComm == null) return;
            if (clientComm.ClientStatus() != csConnStatus.Connected) return;

            bool[] bits = new bool[8];
            bool success = TComm.AskDigitalInput(clientComm, bits);
            if (success)
            {
                chkDI0.Checked = bits[0];
                chkDI1.Checked = bits[1];
                chkDI2.Checked = bits[2];
                chkDI3.Checked = bits[3];
                chkDI4.Checked = bits[4];
                chkDI5.Checked = bits[5];
                chkDI6.Checked = bits[6];
                chkDI7.Checked = bits[7];
                lblCommOK.Text =
                     Convert.ToString(Convert.ToInt32(lblCommOK.Text) + 1);
            }
            else
            {
                lblCommNG.Text =
                     Convert.ToString(Convert.ToInt32(lblCommNG.Text) + 1);
            }
        }

        private void timAskBits_Tick(object sender, EventArgs e)
        {
            btnReadBits.PerformClick();
        }
    }
}
