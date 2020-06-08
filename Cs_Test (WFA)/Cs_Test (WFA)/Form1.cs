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
            int[] tt = new int[] { 1, 4, 6, 2, 8, 5 };
            foreach (int a in tt)
            {
                Console.WriteLine(a);
            }
        }
    }
}
