using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_of_Week
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_dow_Click(object sender, EventArgs e)
        {
            lbl_date.Text = "Date: " + txt_year.Text + " - " + txt_month.Text + " - " + txt_day.Text;
            string[] dow = new string[] { "일", "월", "화", "수", "목", "금", "토" };
            int year = Convert.ToInt32(txt_year.Text);
            int month = Convert.ToInt32(txt_month.Text);
            int day = Convert.ToInt32(txt_day.Text);
            if (month == 1 || month == 2)
            {
                month += 12;
                year--;
            }
            int DOW = (year + year / 4 - year / 100 + year / 400 + (int)(2.6 * month + 1.6) + day) % 7;
            lbl_result.Text = dow[DOW] + "요일";
        }

        private void btn_cly_Click(object sender, EventArgs e)
        {
            lbl_date.Text = "Date: " + txt_year.Text + " - " + txt_month.Text + " - " + txt_day.Text;
            int year = Convert.ToInt32(txt_year.Text);
            lbl_leapYear.Text = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0)? "윤년입니다.": "윤년이 아닙니다.";

        }
    }
}
