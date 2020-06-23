using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_Test__WFA_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] st = new string[5];
            st[0] = "33";
            st[1] = "22";
            st[2] = "24";
            st[3] = "25";
            st[4] = "66";
            double sum = 0;
            double[] dd = Array.ConvertAll(st, double.Parse);
            for (int i = 0; i < 5; i++) sum += dd[i];
            Console.WriteLine(sum);
        }
    }
}
