using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TotalSec
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

        private void btn_toSec_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(txt_hour.Text);
            int minute = Convert.ToInt32(txt_minute.Text);
            int second = Convert.ToInt32(txt_second.Text);
            txt_totalSec.Text = Convert.ToString(hour * 3600 + minute * 60 + second);
        }

        private void btn_toHour_Click(object sender, EventArgs e)
        {
            int ttsec = Convert.ToInt32(txt_totalSec.Text);
            txt_hour.Text = Convert.ToString(ttsec / 3600);
            ttsec %= 3600;
            txt_minute.Text = Convert.ToString(ttsec / 60);
            txt_second.Text = Convert.ToString(ttsec % 60);
        }
    }
}
