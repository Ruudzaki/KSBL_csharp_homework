using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Tasks_1_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 6;
            int c = 99;

            Console.WriteLine(GetAverage(a, b, c));
            Console.ReadKey();
        }

        static double GetAverage(int a, int b, int c) 
        {
            return Convert.ToDouble(a + b + c) / 3;
        }
    }
}
