using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HumanOverride human = new HumanOverride();
            human.favorite();

            Man0 man = new Man0();
            man.favorite();
            human = man;
            human.favorite();
            //HumanOverride mann = new Man0();
            //mann.favorite();

            Woman0 woman = new Woman0();
            woman.favorite();
            human = woman;
            human.favorite();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            HumanOverride[] arr = new HumanOverride[10];
            for (int i = 0; i < 10; i++){
                int idx = rnd.Next(2);
                if (idx == 0)
                    arr[i] = new Man0();
                else
                    arr[i] = new Woman0();
            }
            for(int i = 0; i < 10; i++)
            {
                arr[i].favorite(); // 다형적 호출
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HumanNew human = new HumanNew();
            human.favorite();

            ManN man = new ManN();
            man.favorite();
            human = man;
            human.favorite(); // 다형적 호출 X

            womanN woman = new womanN();
            woman.favorite();
            human = woman;
            human.favorite(); // 다형적 호출 X
        }
    }
}
