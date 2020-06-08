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
        double xmin = -2, xmax = 7;
        double ymin = -5, ymax = 70;

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

        private double det(double[,] A, int size) // determinant를 계산하기 위한 함수
        {
            int i, j, k;
            double[] e = new double[4];
            double deter = 0, sign;
            for(i = 0; i < size; i++)
            {
                int m = 0;
                // cofactor를 먼저 구하여 sign 변수에 저장
                if ((i + 1) % 2 == 0) sign = -A[0, i];
                else sign = A[0, i];

                for (j = 1; j < size; j++)
                {
                    for (k = 0; k < size; k++)
                    {
                        // continue를 통해 minor matrix 작성
                        if (k == i) continue;
                        // minor determinant 계산을 위한 minor matrix의 element를 저장
                        e[m] = A[j, k];
                        m++;
                    }
                }
                //minor determinant 와 cofactor를 곱하여 determinant를 계산
                deter += sign* (e[0] * e[3] - e[1] * e[2]);
            }
            return deter;
        }

        private double[] crammer(double[,] A, double[] Y, int size) // Crammer's Rule
        {
            int i, j;
            double deter = det(A, size); // 분모에 들어갈 A 행렬의 행렬식
            double[] result = new double[size];
            double[,] Aj = new double[3, 3];
            for (i = 0; i < size; i++)
            {
                Aj = (double[,]) A.Clone(); // A 행렬을 복사
                for(j = 0; j < size; j++)
                {
                    Aj[j, i] = Y[j]; // A 행렬에서 j열을 Y행렬로 바꿔치기한 Aj행렬을 생성
                }
                result[i] = det(Aj, size) / deter; // 크래머의 공식을 적용하여 해를 도출하여 저장
            }
            return result;
        }
        
        private void btn_draw_Click(object sender, EventArgs e)
        {
            //Data initialize
            const int ndat = 6;
            int i, j;
            double sx = 0, sy = 0, sxy = 0, sx2 = 0, sx3 = 0, sx4 = 0, sx2y = 0, Sr = 0, St = 0, R, R2;
            double[] xw = new double[ndat] { 1, 2, 3, 4, 5, 6};
            double[] yw = new double[ndat] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1};

            //Graphics initialize
            Graphics grp = pic_draw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0), xpixel(ymax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin), xpixel(0), ypixel(ymax));
            grp.DrawEllipse(new Pen(Color.Black), xpixel(-0.3), ypixel(-1), 7, 14);

            //Draw Point
            for(i = 0; i <ndat; i++)
            {
                grp.DrawEllipse(new Pen(Color.Blue), xpixel(xw[i]), ypixel(yw[i]), 5, 5);
            }

            //Least-Square Solution

            for(i = 0; i < ndat; i++) // Least Square Method를 실시하기 위한 각종 변수들을 계산
            {
                sx += xw[i];
                sy += yw[i];
                sxy += xw[i] * yw[i];
                sx2 += xw[i] * xw[i];
                sx3 += xw[i] * xw[i] * xw[i];
                sx4 += xw[i] * xw[i] * xw[i] * xw[i];
                sx2y += xw[i] * xw[i] * yw[i];
            }

                // Initialize Matrix
            double[,] Z = new double[3, 3] { { ndat, sx, sx2 }, { sx, sx2, sx3 }, { sx2, sx3, sx4 } };
            double[] Y = new double[3] { sy, sxy, sx2y };

            // Find Soultion
            double[] a = crammer(Z, Y, 3);

            for (i = 0; i < ndat; i++)
            {
                St += (yw[i] - sy / ndat) * (yw[i] - sy / ndat);
                Sr += (yw[i] - a[2] * xw[i] * xw[i] - a[1] * xw[i] - a[0]) * (yw[i] - a[2] * xw[i] * xw[i] - a[1] * xw[i] - a[0]);
            }
                //Fitting이 잘 되었는지 확인하기 위한 결정계수와 상관계수 계산
            R = Math.Sqrt((St - Sr) / St);
            R2 = (St - Sr) / St;

            lbl_Sr.Text = "Sr = " + Convert.ToString(Math.Round(Sr, 6));
            lbl_St.Text = "St = " +Convert.ToString(Math.Round(St, 6));
            lbl_R.Text  = "R  = " +Convert.ToString(Math.Round(R, 6));
            lbl_R2.Text = "R2 = " +Convert.ToString(Math.Round(R2, 6));
            lbl_a0.Text = Convert.ToString(Math.Round(a[0], 6));
            lbl_a1.Text = Convert.ToString(Math.Round(a[1], 6));
            lbl_a2.Text = Convert.ToString(Math.Round(a[2], 6));
            lbl_fx.Text = "fx = (" + lbl_a2.Text + ") * x^2 + (" + lbl_a1.Text + ") * x + (" + lbl_a0.Text + ")";
            //Draw Solution Line

            PointF[] points = new PointF[(int)(xmax-xmin + 1)];
            // while문을 통해 DrawEllipse 함수로 그래프를 작성하려면 많은 컴퓨팅 자원이 소모됨
            // 따라서 적절한 중간점들을 몇개만 계산한 다음에 DrawCurve 함수로 작성
            // DrawCurve의 Argument로 PoinF[]가 사용되기 때문에 점 갯수만큼 PointF 배열 선언

            j = 0;
            for (i = (int)xmin; i <= xmax; i++)
            {
                // 적절한 수의 xpixel 좌표와, ypixel 좌표값을 계산하여 PointF 형식으로 배열에 할당
                points[j++] = new PointF(xpixel(i), ypixel(a[0] + a[1] * i + a[2] * i * i));
            }
            grp.DrawCurve(new Pen(Color.Red), points); //2차 곡선 작성
        }

    }
}