using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        bool isPrime(int n)
        {
            if (n == 1) return false;
            else if(n == 2) return true;
            for (int i = 2; i < Math.Sqrt(n) + 1; i++)
                if (n % i == 0) return false;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_input.Text)) lbl_out.Text = "값을 입력해주세요";
            else lbl_out.Text = isPrime(Convert.ToInt32(txt_input.Text)) ? "소수입니다." : "소수가 아닙니다.";
        }

        private void txt_input_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) button1_Click(0, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, cnt = 0;
            for (i = 1; i <= 10000; i++)
                if (isPrime(i)) cnt++;
            lbl_out.Text = "10,000까지 " + Convert.ToString(cnt) + " 개의\n 소수가 존재합니다.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int i = 0, cnt = 0;
            int icheck = 2, nfount = 0;
            while (true)
            {
                if (isPrime(icheck)) nfount++;
                if (nfount == 10000) break;
                icheck++;
            }
            //while (cnt != 10000) if (isPrime(++i)) cnt++;
            lbl_out.Text = "10,000번 째 소수는\n" + Convert.ToString(icheck) + " 입니다.";
        }
    }
}
