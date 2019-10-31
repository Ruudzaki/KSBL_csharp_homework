using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseCurrency;
            double FX;

            try
            {
                Console.Write("Amount in UAH: ");
                baseCurrency = double.Parse(Console.ReadLine());
                Console.Write("FX in USD: ");
                FX = double.Parse(Console.ReadLine());

                Console.WriteLine("Amount in USD: {0}", ConvertCurrency(baseCurrency, FX));

            }
            catch
            {
                Console.WriteLine("Unexpected value. Try again.");
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static double ConvertCurrency(double UAH, double FX)
        {
            return UAH * FX;
        }
    }
}
