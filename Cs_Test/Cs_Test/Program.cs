using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Cs_Test
{
    class Program
    {
        const int max = 30000000;
        static void Main(string[] args)
        {
            string A = "1:44,23:555";
            string[] B = A.Split(',');
            string[][] C = Array.ConvertAll<string, string[]>(B, e => e.Split(':'));
            int[] aa = new int[] { 1, 2, 3, 4, 5 };
            int[] bb = new int[] { 1, 2, 3, 4, 5 };
            EPI();
            ReadKey();
        }
        static public void EPI()
        {
            DateTime start = DateTime.Now;
            bool[] prime = new bool[max + 1];
            int i, j, pcnt = 0;
            for (i = 2; i <= max; i++)
            {
                if (prime[i] == false)
                {
                    pcnt++;
                    for (j = i * 2; j <= max; j += i)
                    {
                        prime[j] = true;
                    }
                }
                if ((i - 2) % 37500 == 0) WriteLine("{0}:{1}", i, pcnt);

            }
            WriteLine("{0}:{1}", i - 1, pcnt);

        }
    }
}