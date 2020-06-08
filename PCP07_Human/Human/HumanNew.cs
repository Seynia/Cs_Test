using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class HumanNew
    {
        protected int age = 26, height = 172;

        public virtual void favorite()
        {
            Console.WriteLine("food");
        }
    }

    class ManN: HumanNew
    {
        public new void favorite()
        {
            Console.WriteLine("car");
        }
    }
    class womanN: HumanNew
    {
        public new void favorite()
        {
            Console.WriteLine("jewel");
        }
    }
}
