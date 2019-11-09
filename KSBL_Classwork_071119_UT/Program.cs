using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KSBL_ClassLibrary_071119;

namespace KSBL_Classwork_071119_UT
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            double result = c.Add(10, 20.5);
            Console.WriteLine(result);


        }
    }
}
