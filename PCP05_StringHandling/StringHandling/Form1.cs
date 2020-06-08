using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            lblTime.Text = t.ToString();
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN1.Text.Trim().Length.ToString();
            
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = txtIN1.Text.Substring(0, n);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = txtIN1.Text.Substring(txtIN1.Text.Length - n, n);
        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN1.Text.Substring(1, 3);
        }

        private void btnUpper_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN1.Text.ToUpper();
        }

        private void btnLower_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN1.Text.ToLower();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN1.Text.Equals(txtIN2.Text)? "같음":"다름";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            txtOUT.Text = txtIN1.Text.IndexOf(txtIN2.Text).ToString();
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = txtIN1.Text.PadLeft(n);
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtIN2.Text);
            txtOUT.Text = txtIN1.Text.PadRight(n);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            char[] delim = new char[] { ' ', '-', ',', ':', ';'};
            string[] words = lblTime.Text.Split(delim);

            txtOUT.Text = words[4] + "시입니다. 배고픕니다 ㅠㅠ";
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            txtOUT.Text = lblTime.Text.Replace(' ', '/');
        }
    }
}
