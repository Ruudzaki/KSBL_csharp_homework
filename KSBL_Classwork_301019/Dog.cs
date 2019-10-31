using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_301019
{
    class Dog : Animal, IPet
    {
        public Dog(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("...and also bones");
        }

        public void DigBones() 
        {
            Console.WriteLine("*digging bones*");
        }

        public override void Voice()
        {
            Console.WriteLine("Bark-bark");
        }

        public void Pet()
        {
            Console.WriteLine("*tail swinging*");
        }
    }
}
