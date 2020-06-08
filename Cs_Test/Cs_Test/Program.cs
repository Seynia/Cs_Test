using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Test
{
    class Program
    {
        interface itest
        {
            void WriteLog(String log);
        }

        class ctest: itest
        {
            public void WriteLog(String log)
            {
                Console.WriteLine(log);
            }
        }

        
        static void Main(string[] args)
        {
            itest iLog = new ctest();
            iLog.WriteLog("do it");
        }
    }
}
