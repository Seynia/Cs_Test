using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteRect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            // Real Ratio
            int wd = picArea.ClientSize.Width, ht = picArea.ClientSize.Height;
            int i, nPoint = 50000, nIn = 0, nOut = 0, xp, yp, area = wd * ht;
            double ratio_real = 100 * 100.0 / area, ratio_monte;
            Random rnd = new Random();
            Graphics grp = picArea.CreateGraphics();
            Color col;
            lbl_ratio.Text = string.Format("{0:0.00000}", ratio_real);
            grp.Clear(Color.White);


            for (i = 0; i< nPoint; i++)
            {
                xp = rnd.Next(wd);
                yp = rnd.Next(ht);
                if(xp >= 100 && xp <= 200 && yp >= 100 && yp <= 200)
                {
                    nIn++;
                    col = Color.Black;
                }
                else
                {
                    nOut++;
                    col = Color.Silver;
                }
                grp.DrawEllipse(new Pen(col), xp, yp, 1, 1);
            }
            ratio_monte = (double)nIn / nPoint;
            lbl_inPts.Text = nIn.ToString();
            lbl_outPts.Text = nOut.ToString();
            lbl_ratioMonte.Text = string.Format("{0:0.00000}", ratio_monte);
        }
    }
}
