using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class HumanOverride
    {
        protected int age = 26, height = 172;

        public virtual void favorite()
        {
            Console.WriteLine("food");
        }
    }

    class Man0: HumanOverride
    {
        public override void favorite()
        {
            Console.WriteLine("car");
        }
    }

    class Woman0: HumanOverride
    {
        public override void favorite()
        {
            Console.WriteLine("jewel");
        }

    }
}
