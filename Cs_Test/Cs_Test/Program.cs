using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            EPI(10, 20);
            ReadKey();
        }
        static void EPI(int start, int end)
        {
            bool[] prime = new bool[end + 1];
            int i, j, pcnt = 0;
            bool flag;

            for (i = start; i <= end; i++)
            {
                flag = true;
                for(j = 2; j <= Math.Sqrt(i) + 1; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) WriteLine("{0}는 소수이다.", i);
                else WriteLine("{0}는 소수가 아니다.", i);
            }
            
        }
    }
}
