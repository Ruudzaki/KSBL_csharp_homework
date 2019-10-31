using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_7_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate(66, 43, 102);

            Console.ReadKey();
        }

        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine((double)(a + b + c) / 3);
        }
    }
}
