using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        private TCanvas canvas = null;
        private List<Circle> circles = new List<Circle>();
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(canvas == null) canvas = new TCanvas(picDraw, 0, 100, 0, 100);
        }

        private void DrawCircles()
        {
            // 화면지우기
            canvas.ClearDrawing(Color.White);

            // 모든 원 그리기
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].draw(canvas);
            }

            lblNCir.Text = "원의개수 : " + Convert.ToString(circles.Count);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i, j;
            if (!chkMove.Checked) return;

            for (i = 0; i < circles.Count; i++)
            {
                if (chkEmbCircle.Checked)
                {
                    for (j = 0; j < circles.Count; j++)
                    {
                        // 같은 원을 검사할 필요는 없기 때문에 인덱스가 같을 경우 패스
                        if (i == j) continue;
                        else if (circles[i].isembedded(circles[j]))
                        {
                            circles.Remove(circles[j]);
                            // remove를 하며 최대 크기가 감소하였으나 외부 루프를 돌지 않고 내부 루프를 도는 중이기 때문에
                            //i값이 이미 최대값이었을 경우 보정해주지 않으면 out of index exception 발생
                            if (i == circles.Count) i--;
                        }
                    }
                }
                circles[i].move(0, 100, 0, 100);
            }
            DrawCircles();
        }


        private void picDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (radAdd.Checked)
            {
                Circle cir = new Circle(canvas.xposD(e.X), canvas.yposD(e.Y));
                circles.Add(cir);
                DrawCircles();
            }
            else if (radDel.Checked)
            {
                List<Circle> cdel = new List<Circle>();
                for (int i = 0; i < circles.Count; i++)
                {
                    if (circles[i].isinside(canvas.xposD(e.X), canvas.yposD(e.Y))) cdel.Add(circles[i]);
                }

                for (int i = 0; i < cdel.Count; i++) circles.Remove(cdel[i]);
                DrawCircles();
            }
        }

        private void btnAdd100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                double xc = rnd.Next(100);
                double yc = rnd.Next(100);
                Circle cir = new Circle(xc, yc);
                circles.Add(cir);
            }

            DrawCircles();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            circles.Clear();
            DrawCircles();
        }
    }
}
