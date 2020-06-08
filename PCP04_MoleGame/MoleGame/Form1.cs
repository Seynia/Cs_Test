using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoleGame
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        PictureBox[] pic = new PictureBox[5];
        bool[] isOpen = Enumerable.Repeat<bool>(false, 5).ToArray<bool>();
        public Form1()
        {
            InitializeComponent();
            pic[0] = pic_card00;
            pic[1] = pic_card01;
            pic[2] = pic_card02;
            pic[3] = pic_card03;
            pic[4] = pic_card04;
        }
        

        private void tim_open_Tick(object sender, EventArgs e)
        {
            int idx = rnd.Next(5);
            pic[idx].Image = Properties.Resources.pae0;
            isOpen[idx] = true;
            tim_open.Enabled = false;
            tim_closed.Enabled = true;
        }

        private void tim_closed_Tick(object sender, EventArgs e)
        {
            int idx;
            for (idx = 0; idx < 5; idx++)
            {
                pic[idx].Image = Properties.Resources.pae48;
                isOpen[idx] = false;
            }
            tim_open.Enabled = true;
            tim_closed.Enabled = false;

        }

        private void pic_card00_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pp = sender as PictureBox; // OOP의 다형성 polimorphism
            int ihit;
            for (ihit = 0; ihit < 5; ihit++) if (pp.Name == pic[ihit].Name)
                {
                    if (isOpen[ihit])
                    {
                        int score = Convert.ToInt32(lbl_point.Text);
                        lbl_point.Text = Convert.ToString(++score);
                        isOpen[ihit] = false;
                        break;
                    }
            }
        }
    }
}
