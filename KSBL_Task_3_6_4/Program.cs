using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_3_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 5;

            Console.WriteLine(GetFactorial(N));

            Console.ReadKey();
        }

        static int GetFactorial(int N)
        {
            int fact = 1;
            int i = 1;

            do
            {
                fact *= i;
                i++;
            }
            while (i <= N);

            return fact;
        }
    }
}
