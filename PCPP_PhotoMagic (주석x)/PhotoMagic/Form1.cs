using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PhotoMagic
{
    public partial class Form1 : Form
    {
        Bitmap[] Ebmap = new Bitmap[3];
        PictureBox[] PBdMap = new PictureBox[13];
        
        
        public Form1()
        {
            InitializeComponent();

            width = picEncoded1.Image.Width;
            height = picEncoded1.Image.Height;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebmap[0] = picEncoded1.Image as Bitmap;
            Ebmap[1] = picEncoded2.Image as Bitmap;
            Ebmap[2] = picEncoded3.Image as Bitmap;
            PBdMap[4] = picDecodeTap0;
            PBdMap[5] = picDecodeTap1;
            PBdMap[6] = picDecodeTap2;
            PBdMap[7] = picDecodeTap3;
            PBdMap[8] = picDecodeTap4;
            PBdMap[9] = picDecodeTap5;
            PBdMap[10] = picDecodeTap6;
            PBdMap[11] = picDecodeTap7;
            PBdMap[12] = picDecodeTap8;
        }

        private void Decode(int idx)
        {
            int i, j, k, R, G, B;
            DateTime StartT = DateTime.Now;
            Color col;
            
            for (i = 4; i <= 12; i++)
            {
                LFSR lfsr = new LFSR(txtInitialSeed.Text, i);
                Bitmap Dmap = new Bitmap(width, height);

                for (j = 0; j < width; j++)
                {
                    for (k = 0; k < height; k++)
                    {
                        col = Ebmap[idx].GetPixel(j, k);
                        R = col.R ^ lfsr.generate(8);
                        G = col.G ^ lfsr.generate(8);
                        B = col.B ^ lfsr.generate(8);
                        Dmap.SetPixel(j, k, Color.FromArgb(R, G, B));
                    }
                }
                PBdMap[i].Image = Dmap;
            }
            lbl_ETime.Text = "Elapsed Time is " + DateTime.Now.Subtract(StartT).Milliseconds.ToString() + "ms";
        }

        private void btnDecodeImg1_Click(object sender, EventArgs e)
        {
            Decode(0);
        }

        private void btnDecodeImg2_Click(object sender, EventArgs e)
        {
            Decode(1);
        }

        private void btnDecodeImg3_Click(object sender, EventArgs e)
        {
            Decode(2);
        }

        private readonly int width, height;
    }
}