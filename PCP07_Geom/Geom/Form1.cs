using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geom
{
    public partial class Form1 : Form
    {
        List<Geom> geoms = new List<Geom>();  // 컨테이너 클래스 List !!
        Random rnd = new Random((int)DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            geoms.Clear();
            Circle.num = 0;
            Diamond.num = 0;
            Triangle.num = 0;
            Rectangle.num = 0;
            RedrawAll();
        }

        private void btnDraw3_Click(object sender, EventArgs e)
        {
            Geom geom;
            Color col;

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Circle(150, 220, 10, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Diamond(200, 300, 20, 20, col);
            geoms.Add(geom);

            col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
            geom = new Diamond(250, 130, 20, 20, col);
            geoms.Add(geom);

            RedrawAll();
        }

        private void btnDraw100_Click(object sender, EventArgs e)
        {
            Color col;
            int ngeom = 100;
            for (int i = 0; i < ngeom; i++)
            {
                //##################################수정한 부분##################################
                col = Color.FromArgb(rnd.Next(200), rnd.Next(200), rnd.Next(200));
                switch (rnd.Next(4))
                {
                    case 0:
                        Circle cir = new Circle(rnd.Next(500), rnd.Next(500),
                                                rnd.Next(30), col);
                        geoms.Add(cir);
                        break;
                    case 1:
                        Diamond dia = new Diamond(rnd.Next(500), rnd.Next(500),
                                                  rnd.Next(30), rnd.Next(30), col);
                        geoms.Add(dia);
                        break;
                    case 2:
                        int x = rnd.Next(500), y = rnd.Next(500);
                        Triangle tri = new Triangle(new Point[] {new Point(x,y),
                                                                 new Point(x + rnd.Next(-15, 15), y + rnd.Next(-15,15)),
                                                                 new Point(x + rnd.Next(-15, 15), y + rnd.Next(-15,15)) }, col);
                        geoms.Add(tri);
                        break;
                    case 3:
                        Rectangle rect = new Rectangle(rnd.Next(500), rnd.Next(500),
                                                       rnd.Next(30), rnd.Next(30), col);
                        geoms.Add(rect);
                        break;
                }
                //##################################수정한 부분END ##################################
            }

            RedrawAll();
        }

        //=======================================
        //===      모두 지우고 다시 그리기      ===
        //=======================================
        private void RedrawAll()
        {
            Graphics grp = picDraw.CreateGraphics();
            grp.Clear(Color.White);
            for (int i = 0; i < geoms.Count; i++)
            {
                geoms[i].Draw(picDraw);  // 다형적 호출
            }

            this.lblNCir.Text = Circle.num.ToString();  // static 멤버의 access
            this.lblNDia.Text = Diamond.num.ToString();
            this.lblNRect.Text = Rectangle.num.ToString();
            this.lblNTri.Text = Triangle.num.ToString();
            this.lblNTotal.Text = geoms.Count.ToString();
            
        }
    }
}
