using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_3_6_0
{
    class Program
    {
        static void Main(string[] args)
        {
            drawRectangle(10, 15);

            Console.ReadKey();
        }

        static void drawRectangle(int heigth, int width)
        {
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
