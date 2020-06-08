using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MonteTri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isInside(Point[] p, Point now)
        {
            // Point in Polygon Algorithm (반직선을 그어 검증하는 알고리즘)
            int a, b = 0, cnt = 0;
            double node;
            for (a = 0; a < p.Length; a++)
            {
                // p1-p2, p2-p3, p3-p1... 순서로 검증하기 위해 b인덱스를 따로 처리
                b = (a + 1) % p.Length;
                if (now.Y > p[a].Y ^ now.Y > p[b].Y)
                {
                    // 선분 L1(A,B), 점 C가 있다고 할 때
                    // 점 C의 오른쪽 반직선과 선분 L1의 교점 D는
                    // D = (C.Y - A.Y) * (B.X - A.X) / (B.Y - A.Y) + A.X
                    // == (C.Y - A.Y) * dx/dy + A.X 이므로 교점의 변수 node는

                    node = (now.Y - p[a].Y) * (p[b].X - p[a].X)  / (p[b].Y - p[a].Y) + p[a].X;
                    if (now.X < node) cnt++;
                }
            }
            // 다각형을 통과하는 교점의 개수가 홀수이면 내부에 있는 것이므로
            return cnt % 2 == 1;
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            // Real Ratio
            int wd = picArea.ClientSize.Width, ht = picArea.ClientSize.Height;
            int i, nPoint = 20000, nOut = 0, area = wd * ht;
            double nIn = 0;
            // 삼각형의 세 꼭지점을 담은 포인트 구조체 배열 선언 및 초기화
            Point now;
            Point[] p = new Point[3] { new Point(160, 70) , new Point(50, 410), new Point(340, 290) };
            Random rnd = new Random();
            Graphics grp = picArea.CreateGraphics();
            Color col;

            grp.Clear(Color.White);

            for (i = 0; i < nPoint; i++)
            {
                now = new Point(rnd.Next(wd), rnd.Next(ht));
                if (isInside(p, now))
                {
                    nIn++;
                    col = Color.Black;
                }
                else
                {
                    nOut++;
                    col = Color.Silver;
                }
                lbl_cnt.Text = (i + 1).ToString();
                if (i / 10 % 10 == 0) Application.DoEvents();
                grp.DrawEllipse(new Pen(col), now.X, now.Y, 1, 1);
            }
            //벡터 계산을 통한 삼각형의 면적 계산
            double triArea = Math.Abs(p[0].X * p[1].Y + p[1].X * p[2].Y + p[2].X * p[0].Y - p[0].X * p[2].Y - p[2].X * p[1].Y - p[1].X * p[0].Y) / 2.0;
            double ratio_real = triArea / area;
            double ratio_monte = nIn / nPoint;

            lbl_ratio.Text = "Ratio of Real:        " + string.Format("{0:0.00000}", ratio_real);
            lbl_inPts.Text = "In Points counts:   " + nIn.ToString();
            lbl_outPts.Text = "Out Points counts: " + nOut.ToString();
            lbl_ratioMonte.Text = "Ratio of Monte:      " + string.Format("{0:0.00000}", ratio_monte);
        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
