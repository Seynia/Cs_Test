using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DllMain
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

        private void btnInCSharp_Click(object sender, EventArgs e)
        {
            lblNPrime.Text = "...";
            lblTime.Text = "...";
            Application.DoEvents();

            int nMax = Convert.ToInt32(txtNMax.Text);
            int nprime;

            DateTime stime = DateTime.Now;
            PrimeCSharp.FindNumberOfPrimeNumber(nMax, out nprime);
            double dtime = Util.TimeInSeconds(stime);

            lblNPrime.Text = Convert.ToString(nprime);
            lblTime.Text = string.Format("{0:0.00}", dtime);
        }

        private void btnInCPP_Click(object sender, EventArgs e)
        {
            lblNPrime.Text = "...";
            lblTime.Text = "...";
            Application.DoEvents();

            int nMax = Convert.ToInt32(txtNMax.Text);
            int nprime = 0;

            DateTime stime = DateTime.Now;
            dllPrime.dllFindNumberOfPrimeNumber(nMax, ref nprime);
            double dtime = Util.TimeInSeconds(stime);

            lblNPrime.Text = Convert.ToString(nprime);
            lblTime.Text = string.Format("{0:0.00}", dtime);
        }
    }
}
