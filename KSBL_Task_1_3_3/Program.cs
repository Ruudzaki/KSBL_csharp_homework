using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_1_3_3
{
    class Program
    {
        const double pi = 3.141592653;

        static void Main(string[] args)
        {
            int r = 24;

            Console.WriteLine(GetCircleArea(r));
            Console.ReadKey();
        }

        static double GetCircleArea(int r)
        {
            return Math.Pow(r, 2) * pi;
        }
    }
}
