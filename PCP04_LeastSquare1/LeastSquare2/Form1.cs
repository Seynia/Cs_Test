using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquare2
{
    public partial class Form1 : Form
    {
        double xmin = -5, xmax = 20;
        double ymin = -5, ymax = 20;

        public Form1()
        {
            InitializeComponent();
        }

        private float xpixel(double xw)
        {
            return (float)(pic_draw.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }

        private float ypixel(double yw)
        {
            return (float)(pic_draw.ClientSize.Height * (1 - (yw - ymin) / (ymax - ymin)));
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            //Data initialize
            const int ndat = 10;
            int i, j;
            double a0, a1, sx = 0, sy = 0, sxy = 0, sxx = 0;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] yw = new double[ndat] { 1.3, 3.5, 4.2, 5.0, 7.0, 8.8, 10.1, 12.5, 13.0, 15.6 };

            //Graphics initialize
            Graphics grp = pic_draw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(ymax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));
            grp.DrawEllipse(new Pen(Color.Black), xpixel(-0.8), ypixel(-0.5), 7, 14);

            //Draw Point
            for(i = 0; i <ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Blue), xpixel(xw[i]), ypixel(yw[i]), 2, 2);
            }

            //Least-Square Solution

            for(i = 0; i < ndat; i++)
            {
                sxy += xw[i] * yw[i];
                sx += xw[i];
                sy += yw[i];
                sxx += xw[i] * xw[i];
            }

            a0 = (ndat * sxy - sx * sy) / (ndat * sxx - sx * sx);
            a1 = (sy - a0 * sx) / ndat;

            //Draw Solution Line
            grp.DrawLine(new Pen(Color.Red), xpixel(xmin), ypixel(a0 * xmin + a1),
                                              xpixel(xmax), ypixel(a0 * xmax + a1));

        }

    }
}
