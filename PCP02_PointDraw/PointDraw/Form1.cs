using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointDraw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color Col = Color.Red;
        Graphics grp;
        int xold, yold;

        private void button1_Click(object sender, EventArgs e)
        {
            grp = pictureBox1.CreateGraphics();
            grp.Clear(Color.White);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked) Col = Color.Red;
            else if (radioButton2.Checked) Col = Color.Green;
            else Col = Color.Blue;
            if (e.Button == MouseButtons.Left)
            {
                grp = pictureBox1.CreateGraphics();
                //grp.DrawEllipse(new Pen(Col), e.X, e.Y, 3, 3);
                grp.DrawLine(new Pen(Col), xold, yold, e.X, e.Y);
            }
            xold = e.X;
            yold = e.Y;
        }
    }
}
