using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_1_3_4
{
    class Program
    {
        const double pi = 3.141592653;

        static void Main(string[] args)
        {
            int r = 24;
            int h = 35;

            Console.WriteLine(GetCylinderVolume(r, h));
            Console.WriteLine(GetCylinderArea(r, h));
            Console.ReadKey();
        }

        static double GetCylinderVolume(int r, int h) 
        {
            return pi * Math.Pow(r, 2) * h;
        }

        static double GetCylinderArea(int r, int h) 
        {
            return 2 * pi * r * (r + h);

            ;
            ;
        }
    }
}
