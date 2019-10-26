using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 4;
            int operand2 = 0;

            String sign = Console.ReadLine();

            Calculate(operand1, operand2, sign);

            Console.ReadKey();


        }
        static void Calculate(int operand1, int operand2, string sign)
        {
            switch (sign)
            {
                case "+":
                    Console.WriteLine(operand1 + operand2);
                    break;

                case "-":
                    Console.WriteLine(operand1 - operand2);
                    break;

                case "*":
                    Console.WriteLine(operand1 * operand2);
                    break;

                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("cannot devide on zero.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                        break;
                    }

                case "%":
                    Console.WriteLine(operand1 % operand2);
                    break;

                default:
                    Console.WriteLine("I don't know this sign.");
                    break;
            }

        }
    }
}
