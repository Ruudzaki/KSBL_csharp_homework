using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_7_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            string sign;

            while (true)
            {
                try
                {
                    Console.Write("Write a: ");
                    a = Int32.Parse(Console.ReadLine());
                    Console.Write("Write sign (+, -, *, /): ");
                    sign = Console.ReadLine();
                    Console.Write("Write b: ");
                    b = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Unexpected value. Try again.");
                    Console.WriteLine();
                    continue;
                }

                switch (sign)
                {
                    case "+":
                        Add(a, b);
                        Console.WriteLine();
                        break;

                    case "-":
                        Sub(a, b);
                        Console.WriteLine();
                        break;

                    case "*":
                        Mul(a, b);
                        Console.WriteLine();
                        break;

                    case "/":
                        Div(a, b);
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Wrong sign!");
                        Console.WriteLine("Try again.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a , b, a + b);
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        static void Mul(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }

        static void Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Undefined!");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);
            }

        }
    }
}
