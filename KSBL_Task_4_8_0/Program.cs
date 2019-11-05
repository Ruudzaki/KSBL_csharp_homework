using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_8_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            int b = 15;
            int c = 20;

            Calculate(ref a, ref b, ref c);

            Console.WriteLine("a / 5 = {0}, b / 5 = {1}, c / 5 = {2}", a, b, c);
            Console.ReadKey();
        }

        private static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }
    }
}
