using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_291019
{
    class MyClass
    {
        public string field;

        public void Method()
        {
            Console.WriteLine(field);
        }

        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            myClass.field = "lol";
            myClass.Method();

            Console.ReadKey();

        }
    }
}
