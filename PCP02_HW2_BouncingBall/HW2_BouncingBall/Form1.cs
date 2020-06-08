using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace HW2_BouncingBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int dx = 1, dy = 1;
 
        private void timer1_Tick(object sender, EventArgs e)
        {
            //그라데이션으로 색변경
            //int dist_Max = (int)(Math.Sqrt(Math.Pow(ClientSize.Width / 2, 2)
            // + Math.Pow(ClientSize.Height / 2, 2)));
            //int dist = (int)(Math.Sqrt(Math.Pow(ClientSize.Width / 2 - Ball.Left, 2) +
            //Math.Pow(ClientSize.Height / 2 - Ball.Top, 2)) * 255 / dist_Max);
            //Ball.BackColor = Color.FromArgb(255 - dist, 0, dist);
 
            //임계값을 이용한 토글식 색 변경
            if (Ball.Right > ClientSize.Width / 4 && Ball.Right < ClientSize.Width * 3 / 4 &&
                Ball.Top > ClientSize.Height / 4 && Ball.Top < ClientSize.Height * 3 / 4)
                Ball.BackColor = Color.Red;
            else Ball.BackColor = Color.Blue;
 
            if (Ball.Right > ClientSize.Width || Ball.Left < 0) dx = ~dx + 1;
            if (Ball.Bottom > ClientSize.Height || Ball.Top < 0) dy = ~dy + 1;
 
            if (rbt_Slow.Checked)
            {
                dx = Math.Sign(dx) * 1;
                dy = Math.Sign(dy) * 1;
            }
            else
            {
                dx = Math.Sign(dx) * 3;
                dy = Math.Sign(dy) * 3;
            }
 
            Ball.Left += dx;
            Ball.Top += dy;
        }
    }
}