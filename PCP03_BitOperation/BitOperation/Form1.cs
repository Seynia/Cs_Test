using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 기시디 기자부 4학년 19110015 최호승
// 과제 개요에서 따로 언급 되지 않은 예외 처리에 대해서는 무시하였습니다.

namespace BitOperation
{
    public partial class Form1 : Form
    {
        // 분리된 체크박스를 체크박스 클래스 배열로 선언하고 인덱스로 사용가능하게 할당
        CheckBox[] bits = new CheckBox[8];

        public Form1()
        {
            InitializeComponent();
            bits[0] = chk0;
            bits[1] = chk1;
            bits[2] = chk2;
            bits[3] = chk3;
            bits[4] = chk4;
            bits[5] = chk5;
            bits[6] = chk6;
            bits[7] = chk7;
        }
        private void numToBit(int gB)
        {
            // 비트를 1부터 1씩 좌시프트해가며 비트단위로 비교해가며 체크박스를 설정
            int i, bit = 1;
            for (i = 0; i < 8; i++, bit <<= 1)
                bits[i].Checked = (gB & bit) != 0x00;
            txtNumber.Text = Convert.ToString(gB);
        }

        private void bitToNum()
        {
            // 체크박스의 체크 여부에 따라 같은 위치의 비트를 ON
            int i, gB = 0, bit = 1;
            for (i = 0; i < 8; i++, bit <<= 1)
                if (bits[i].Checked) gB |= bit;
            txtNumber.Text = Convert.ToString(gB);
        }

        private void btnToBit_Click(object sender, EventArgs e)
        {
            numToBit(Convert.ToInt32(txtNumber.Text));
        }

        private void btnFromBit_Click(object sender, EventArgs e)
        {
            bitToNum();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            // gB와 1을 인덱스만큼 좌시프트한 값을 비트or연산하여 대입 -> 해당비트만 ON
            int idx = Convert.ToInt32(txtIndex.Text), gB = Convert.ToInt32(txtNumber.Text);
            gB |= 0x01 << idx;
            numToBit(gB);

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            // 1을 인덱스만큼 좌시프트한 값을 비트not 연산을 통해 반전하여 gB와 비트and 연산을 하여 특정 비트만 off
            int bit, idx = Convert.ToInt32(txtIndex.Text), gB = Convert.ToInt32(txtNumber.Text);
            bit = ~(0x01 << idx);
            numToBit(gB & bit);
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            // 해당 인덱스 위치의 체크박스 값을 논리 not 연산을 하여 토글한 값을 그대로 대입
            int idx = Convert.ToInt32(txtIndex.Text);
            bits[idx].Checked = !bits[idx].Checked;
            bitToNum();
        }

        private void btnShiftUp_Click(object sender, EventArgs e)
        {
            // 인덱스와 넘버 값을 읽고 인덱스만큼 넘버값을 시프트하여 바로 출력
            int idx = Convert.ToInt32(txtIndex.Text), gB = Convert.ToInt32(txtNumber.Text);
            numToBit(gB <<= idx);
        }

        private void btnShiftDown_Click(object sender, EventArgs e)
        {
            // 인덱스와 넘버 값을 읽고 인덱스만큼 넘버값을 시프트하여 바로 출력
            int idx = Convert.ToInt32(txtIndex.Text), gB = Convert.ToInt32(txtNumber.Text);
            numToBit(gB >>= idx);
        }
    }
}