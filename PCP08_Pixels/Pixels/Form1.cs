using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixels
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            picTrg.Image = null;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Bitmap bmapOrg = picOrg.Image as Bitmap;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    bmapTrg.SetPixel(i, j, Color.FromArgb(col.R, col.G, col.B));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            int red, green, blue;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    red = 255 - col.R;
                    green = 255 - col.G;
                    blue = 255 - col.B;
                    bmapTrg.SetPixel(i, j, Color.FromArgb(red, green, blue));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnMirrorLR_Click(object sender, EventArgs e)
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(bmapOrg.Width - i - 1, j);
                    bmapTrg.SetPixel(i, j, Color.FromArgb(col.R, col.G, col.B));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnMirrorUD_Click(object sender, EventArgs e)
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, bmapOrg.Height - j - 1);
                    bmapTrg.SetPixel(i, j, Color.FromArgb(col.R, col.G, col.B));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            Bitmap bmapOrg = (Bitmap)picOrg.Image;
            Bitmap bmapTrg = new Bitmap(bmapOrg.Width, bmapOrg.Height);

            Color col;
            for (int i = 0; i < bmapOrg.Width; i++)
            {
                for (int j = 0; j < bmapOrg.Height; j++)
                {
                    col = bmapOrg.GetPixel(i, j);
                    int avr = (int)(0.299 * col.R + 0.587 * col.G + 0.114 * col.B);  //NTSC에서
                    //avr = (red + green + blue) / 3;     // 쉬운방법
                    bmapTrg.SetPixel(i, j, Color.FromArgb(avr, avr, avr));
                }
            }
            picTrg.Image = bmapTrg;
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            if (picTrg.Image == null) return;

            int threshold = hScrollBar1.Value;

            Bitmap bmapTrg = (Bitmap)picTrg.Image;
            Bitmap bmapBin = new Bitmap(bmapTrg.Width, bmapTrg.Height);

            Color col;
            for (int i = 0; i < bmapTrg.Width; i++)
            {
                for (int j = 0; j < bmapTrg.Height; j++)
                {
                    col = bmapTrg.GetPixel(i, j);
                    int avr = (col.R + col.G + col.B) / 3;
                    col = avr >= threshold ? Color.White : Color.Black;
                    bmapBin.SetPixel(i, j, col);

                }
            }
            picBin.Image = bmapBin;
        }


        private void btnReadFile_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                string fname = openFileDialog1.FileName;
                picOrg.Load(fname);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (picBin.Image != null)
            {
                DialogResult res = saveFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    picBin.Image.Save(saveFileDialog1.FileName);
                }
            }
        }

        private void picOrg_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bitmap = picOrg.Image as Bitmap;
            Color col = bitmap.GetPixel(e.X, e.Y);
            picColor.BackColor = col;
            lblRed.Text = "Red : " + Convert.ToString(col.R);
            lblGreen.Text = "Green : " + Convert.ToString(col.G);
            lblBlue.Text = "Blue : " + Convert.ToString(col.B);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            lblScroll.Text = Convert.ToString(hScrollBar1.Value);
            //btnBin.PerformClick();
        }
    }
}
