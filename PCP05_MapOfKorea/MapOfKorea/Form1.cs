using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MapOfKorea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rtn = openFileDialog.ShowDialog();
                if (rtn != DialogResult.OK) return;
                lbl_location.Text = openFileDialog.FileName;

                //Open File (suing System.IO)
                StreamReader sr = new StreamReader(lbl_location.Text, Encoding.Default);
                string st = sr.ReadLine();
                int npoint = Convert.ToInt32(st);
                int[] xp = new int[npoint];
                int[] yp = new int[npoint];

                for (int i = 0; i < npoint; i++)
                {
                    st = sr.ReadLine();
                    string[] words = st.Split(',');
                    xp[i] = Convert.ToInt32(words[0].Trim());
                    yp[i] = Convert.ToInt32(words[1].Trim());
                }
                sr.Close();
                //그리기
                Graphics grp = pic_draw.CreateGraphics();

                Point[] pts = new Point[npoint];
                for (int i = 0; i < npoint; i++)
                {
                    pts[i] = new Point(xp[i], yp[i]);
                }
                grp.DrawCurve(new Pen(Color.Red), pts);
            }
            catch
            {
                MessageBox.Show("파일을 읽을 수 없습니다.", "오류!");
                return;
            }
        }
        
    }
}
