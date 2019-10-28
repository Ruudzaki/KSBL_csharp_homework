using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_3_6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int heigth = 15;
            int width = 25;

            DrawRectangle(heigth, width);
            Console.WriteLine();

            DrawRightTriangle(heigth);
            Console.WriteLine();

            DrawEquilateralTriangle(heigth);
            Console.WriteLine();

            DrawEquilateralRhombus(heigth);
            Console.WriteLine();

            Console.ReadKey();
        }

        static void DrawRectangle(int heigth, int width)
        {
            for (int i = 0; i < heigth; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void DrawRightTriangle(int heigth)
        {
            for (int i = 0; i < heigth ; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void DrawEquilateralTriangle(int heigth)
        {
            for (int i = 0; i < heigth / 2 + 1; i++)
            {
                for (int j = heigth, k = 0; j > 0 && k < heigth; k++, j--)
                {
                    if (i > k || i >= j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.Write("\n");
            }
        }

        static void DrawEquilateralRhombus(int heigth)
        {

            for (int i = heigth / 2 + 1; i > 0; i--)
            {
                Console.Write("\n");
                for (int j = heigth, k = 0; j > 0 && k < heigth; k++, j--)
                {
                    if (i > k  || i >= j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }

            for (int i = 0; i < heigth / 2 + 1; i++)
            {
                Console.Write("\n");
                for (int j = heigth, k = 0; j > 0 && k < heigth; k++, j--)
                {
                    if (i > k || i >= j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}

