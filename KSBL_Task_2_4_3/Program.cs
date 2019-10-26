using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_4_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int guess = -1;

            Console.Write("Your guess: ");

            try
            {
                guess = int.Parse(Console.ReadLine());
                CheckRange(guess);
            }
            catch
            {
                Console.WriteLine("Wrong input.");
            }

            Console.ReadKey();

        }

        static void CheckRange(int guess)
        {
            if ((guess >= 0) && (guess <= 14))
            {
                Console.WriteLine("You are in 0-14 range.");
            }
            else if ((guess >= 15) && (guess <= 35))
            {
                Console.WriteLine("You are in 15-35 range.");
            }
            else if ((guess >= 36) && (guess <= 50))
            {
                Console.WriteLine("You are in 36-50 range.");
            }
            else if ((guess >= 51) && (guess <= 100))
            {
                Console.WriteLine("You are in 50-100 range.");
            }
            else
            {
                Console.WriteLine("no such range");
            }
        }
    }
}
