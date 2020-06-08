using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNum.Text = "0";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(lblNum.Text);
            cnt++;
            lblNum.Text = Convert.ToString(cnt);
        }
    }
}
