using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_1_2_1_Console
{
    
    class Program
    {
        static readonly double pi = 3.141592653;
        static readonly decimal e = 2.7182818284590452M;

        static void Main(string[] args)
        {
            double firstNumber = pi;
            decimal secondNumber = e;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            Console.ReadKey();
        }
    }
}
