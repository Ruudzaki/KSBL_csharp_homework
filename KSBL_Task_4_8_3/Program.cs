using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 39; //max value of N = 39;
            long fact = 1;

            if (n >= 0)
            {
                Recursion(n, ref fact);
                Console.WriteLine(fact);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            Console.ReadKey();
        }

        private static void Recursion(int n, ref long fact)
        {
            if (n > 1)
            {
                fact *= n--;
                Recursion(n, ref fact);
            }
        }
    }
}
