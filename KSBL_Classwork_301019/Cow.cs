using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_301019
{
    class Cow : Animal
    {
        public Cow(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            
            Console.WriteLine("I eat only grass");
        }
        public override void Voice()
        {
            Console.WriteLine("Moo-moo");
        }
    }
}
