using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_301019
{
    abstract class Animal
    {
        public string Name { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("I eat meat");
        }

        public void Sleep()
        {
            Console.WriteLine("Z-z-z-z-z");
        }

        public abstract void Voice();
    }
}
