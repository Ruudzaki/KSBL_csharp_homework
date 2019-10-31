using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPleaseAll(180);

            Console.ReadKey();
        }

        private static void CheckPleaseAll(int a)
        {
            Console.Write("Number \"{0}\": ", a);
            CheckOddOrEven(a);
            CheckPrimeOrNot(a);
            CheckSomethingWithNumbers(a);
        }

        private static void CheckOddOrEven(int a)
        {
            if (a % 2 == 0)
            {
                Console.Write("Even. ");
            }
            else
            {
                Console.Write("Odd. ");
            }
        }

        private static void CheckPrimeOrNot(int a)
        {
            bool prime = true;

            if (a < 1)
            {
                Console.Write("Not a Natural thus Not a Prime Number. ");
                return;
            }

            for (int i = a - 1; i > 1; i--)
            {
                if (a % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.Write("A Prime Number. ");
            }
            else
            {
                Console.Write("Not a Prime Number. ");
            }
        }

        private static void CheckSomethingWithNumbers(int a)
        {
            if (a % 2 == 0 && a % 5 == 0 && a % 9 == 0)
            {
                Console.Write("Devides on 2, 3, 5, 6, 9 without remainder. ");
            }
            else
            {
                Console.Write("Does not devide on 2, 3, 5, 6, 9 without remainder. ");
            }

        }
    }
}
