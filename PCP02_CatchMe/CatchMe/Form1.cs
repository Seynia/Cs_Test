using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class Form1 : Form
    {
        byte t1 = 10;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1--;
            label3.Text = Convert.ToString(t1) + "seconds is left";
            if (t1 < 1)
            {
                label3.Text = "It was a joke";
                timer1.Enabled = false;
            }
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancel.Left = rnd.Next(this.ClientSize.Width - btnCancel.Width);
            btnCancel.Top = rnd.Next(this.ClientSize.Height - btnCancel.Height);
        }
    }
}
