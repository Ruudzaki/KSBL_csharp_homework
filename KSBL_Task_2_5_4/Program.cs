using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_5_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int years = 12;
            int salary = 20001;
            
            System.Console.WriteLine("Bonus for {0} years are {1}", years, GetBonusAmount(years, salary));


            Console.ReadKey();
        }

        static double GetBonusAmount(int years, int salary)
        {
            if (years < 5)
            {
                return salary * 0.1;
            }
            else if (years < 10)
            {
                return salary * 0.15;
            }
            else if (years < 15)
            {
                return salary * 0.25;
            }
            else if (years < 20)
            {
                return salary * 0.35;
            }
            else if (years < 25)
            {
                return salary * 0.45;
            }
            else
            {
                return salary * 0.5;
            }

        }
    }
}
