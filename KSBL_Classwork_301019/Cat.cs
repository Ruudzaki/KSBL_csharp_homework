using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_301019
{
    class Cat : Animal, IPet
    {

        public Cat(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("...and also mice");
        }

        public void Pet()
        {
            Console.WriteLine("*mrr-mrr*");
        }

        public override void Voice()
        {
            Console.WriteLine("Meow-meow");
        }
    }
}
