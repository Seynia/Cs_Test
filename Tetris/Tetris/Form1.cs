using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Web;

namespace Tetris
{
    public partial class Form1 : Form
    {
        int blocks, lines, speed = 500, score, combo, shape, nextshape;
        DateTime startTime;
        //Point startPt = new Point(17, 5);
        bool isblock = false;
        Point[] np = new Point[4] {new Point(0,0), new Point(0,0), new Point(0,0),new Point (0,0) }, oldnp, prepos, oldpre;

        private void timer2_Tick(object sender, EventArgs e)
        {
            draw();
        }

        int[,] ibox = new int[17, 10];

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int i, j;
            bool can = true;
            oldnp = (Point[])np.Clone();
            oldpre = (Point[])prepos.Clone();
            if(e.KeyCode == Keys.Down)
            {
                speed = 100;
                timer1.Interval = speed;
            }
            else if (e.KeyCode == Keys.Left)
            {
                for(i = 0; i <4; i++)
                {
                    if (np[i].Y - 1 < 0) can = false;
                }
                if (can)
                {
                    for (i = 0; i < 4; i++)
                    {
                        np[i].Y--;
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                for (i = 0; i < 4; i++)
                {
                    if (np[i].Y + 1 > 9) can = false;
                }
                if (can)
                {
                    for (i = 0; i < 4; i++)
                    {
                        np[i].Y++;
                    }
                }
            }
            else if (e.KeyCode == Keys.Up)
            {

            }
            draw();
            //timer1_Tick(sender, e);
        }

        PictureBox[,] pbox;
        PictureBox[,] pnext;
        Random rnd = new Random();

        private void draw()
        {
            int i, j;
            oldpre = (Point[])prepos.Clone();
            for(i = 0; i < 4; i++)
            {
                for(j = 0; j <3; j++)
                {
                    pnext[i, j].Image = Properties.Resources.white;
                }
            }
            for (j = np[0].X; j > -1; j--)
            {
                if (ibox[j, np[0].Y] != 0 && ibox[j, np[0].Y] != 2) break;
            }
            if (j < 0) j = 0;
            prepos = new Point[4] { new Point(j, np[0].Y), new Point(j + np[1].X - np[0].X, np[1].Y), new Point(j + np[2].X - np[0].X, np[2].Y), new Point(j + np[3].X - np[0].X, np[3].Y) };

            switch (nextshape)
            {// 0=I, 1=J, 2=L, 3=O, 4=S, 5=T
                case 0:
                    pnext[0, 1].Image = pnext[1, 1].Image = pnext[2, 1].Image = pnext[3, 1].Image = Properties.Resources.black;
                    break;
                case 1:
                    pnext[2,0].Image = pnext[2, 1].Image = pnext[1, 1].Image = pnext[0, 1].Image = Properties.Resources.black;
                    break;
                case 2:
                    pnext[0, 1].Image = pnext[0, 2].Image = pnext[1, 1].Image = pnext[2, 1].Image = Properties.Resources.black;
                    break;
                case 3:
                    pnext[1, 0].Image = pnext[1, 1].Image = pnext[2, 0].Image = pnext[2, 1].Image = Properties.Resources.black;
                    break;
                case 4:
                    pnext[1, 0].Image = pnext[1, 1].Image = pnext[2, 1].Image = pnext[2, 2].Image = Properties.Resources.black;
                    break;
                case 5:
                    pnext[2, 0].Image = pnext[2, 1].Image = pnext[2, 2].Image = pnext[1, 1].Image = Properties.Resources.black;
                    break;
            }
            for (i = 0; i < 4; i++)
            {
                ibox[oldnp[i].X, oldnp[i].Y] = 0;
                ibox[oldpre[i].X, oldpre[i].Y] = 0;
            }
            for(i = 0; i <4; i++)
            {
                ibox[prepos[i].X, prepos[i].Y] = 2;
            }
            for (i = 0; i < 4; i++)
            {
                ibox[np[i].X, np[i].Y] = 1;
            }

            for (i = 0; i < 17; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    switch(ibox[i, j])
                    {
                        case 0:
                            pbox[i, j].Image = Properties.Resources.white;
                            break;
                        case 1:
                            pbox[i, j].Image = Properties.Resources.orange;
                            break;
                        case 2:
                            pbox[i, j].Image = Properties.Resources.porange;
                            break;
                        case 3:
                            pbox[i, j].Image = Properties.Resources.black;
                            break;
                    }
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            prepos = (Point[])np.Clone();
            oldnp = (Point[])np.Clone();
            oldpre = (Point[])np.Clone();
            nextshape = rnd.Next(6);

            pbox = new PictureBox[17, 10] { { pic_block0, pic_block1, pic_block2, pic_block3, pic_block4, pic_block5, pic_block6, pic_block7, pic_block8, pic_block9 },
            {pic_block10, pic_block11, pic_block12, pic_block13, pic_block14, pic_block15, pic_block16, pic_block17, pic_block18, pic_block19 },
            {pic_block20, pic_block21, pic_block22, pic_block23, pic_block24, pic_block25, pic_block26, pic_block27, pic_block28, pic_block29 },
            {pic_block30, pic_block31, pic_block32, pic_block33, pic_block34, pic_block35, pic_block36, pic_block37, pic_block38, pic_block39 },
            {pic_block40, pic_block41, pic_block42, pic_block43, pic_block44, pic_block45, pic_block46, pic_block47, pic_block48, pic_block49 },
            {pic_block50, pic_block51, pic_block52, pic_block53, pic_block54, pic_block55, pic_block56, pic_block57, pic_block58, pic_block59 },
            {pic_block60, pic_block61, pic_block62, pic_block63, pic_block64, pic_block65, pic_block66, pic_block67, pic_block68, pic_block69 },
            {pic_block70, pic_block71, pic_block72, pic_block73, pic_block74, pic_block75, pic_block76, pic_block77, pic_block78, pic_block79 },
            {pic_block80, pic_block81, pic_block82, pic_block83, pic_block84, pic_block85, pic_block86, pic_block87, pic_block88, pic_block89 },
            {pic_block90, pic_block91, pic_block92, pic_block93, pic_block94, pic_block95, pic_block96, pic_block97, pic_block98, pic_block99 },
            {pic_block100, pic_block101, pic_block102, pic_block103, pic_block104, pic_block105, pic_block106, pic_block107, pic_block108, pic_block109 },
            {pic_block110, pic_block111, pic_block112, pic_block113, pic_block114, pic_block115, pic_block116, pic_block117, pic_block118, pic_block119 },
            {pic_block120, pic_block121, pic_block122, pic_block123, pic_block124, pic_block125, pic_block126, pic_block127, pic_block128, pic_block129 },
            {pic_block130, pic_block131, pic_block132, pic_block133, pic_block134, pic_block135, pic_block136, pic_block137, pic_block138, pic_block139 },
            {pic_block140, pic_block141, pic_block142, pic_block143, pic_block144, pic_block145, pic_block146, pic_block147, pic_block148, pic_block149 },
            {pic_block150, pic_block151, pic_block152, pic_block153, pic_block154, pic_block155, pic_block156, pic_block157, pic_block158, pic_block159 },
            {pic_block160, pic_block161, pic_block162, pic_block163, pic_block164, pic_block165, pic_block166, pic_block167, pic_block168, pic_block169 }, };
            
            pnext = new PictureBox[4, 3] { { pic_next0, pic_next1, pic_next2 },
            { pic_next3, pic_next4, pic_next5 },
            { pic_next6, pic_next7, pic_next8 },
            { pic_next9, pic_next10, pic_next11 }};

            for (int i = 0; i < 17; i++)
                for (int j = 0; j < 10; j++)
                    pbox[i, j].Image = Properties.Resources.white;
            timer1.Interval = speed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i, j;
            oldnp = (Point[])np.Clone();
            oldpre = (Point[])prepos.Clone();
            lbl_time.Text = DateTime.Now.Subtract(startTime).Minutes.ToString() + " : " + DateTime.Now.Subtract(startTime).Seconds.ToString();

            if(!isblock)
            {
                // 0=I, 1=J, 2=L, 3=O, 4=S, 5=T
                shape = nextshape;
                nextshape = rnd.Next(6);
                isblock = true;
                switch (shape)
                {
                    case 0:
                        np = new Point[4] { new Point(13, 5), new Point(14,5), new Point(15,5), new Point(16,5) };
                        break;
                    case 1:
                        np = new Point[4] { new Point(14, 4), new Point(14, 5), new Point(15, 5), new Point(16, 5) };
                        break;
                    case 2:
                        np = new Point[4] { new Point(14, 5), new Point(14, 4), new Point(15, 4), new Point(16, 4) };
                        break;
                    case 3:
                        np = new Point[4] { new Point(15, 5), new Point(15, 4), new Point(16, 5), new Point(16, 4) };
                        break;
                    case 4:
                        np = new Point[4] { new Point(15, 4), new Point(15, 5), new Point(16, 5), new Point(16, 6) };
                        break;
                    case 5:
                        np = new Point[4] { new Point(15, 5), new Point(16, 6), new Point(16, 5), new Point(16, 4) };
                        break;
                }
            }
            else
            {
                for(i = 0; i < 4; i++)
                {
                    if (np[i].X == 0) break;
                    np[i].X--;
                }
            }
            if(np[0].X == 0)
            {
                for(i = 0; i < 4; i++)
                {
                    ibox[np[i].X, np[i].Y] = 3;
                    draw();
                    isblock = false;
                }
            }
            draw();
        }
    }
}
