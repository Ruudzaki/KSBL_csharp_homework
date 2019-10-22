using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_221019
{
    class NumberGame
    {


        static void Main(string[] args)
        {
            Random R = new Random();
            int count = 0;
            int guess;
            int value = R.Next(100);

            Console.WriteLine("Try to guess a random number from 0 to 100.");

            while (true)
            {
                Console.Write("Your guess: ");

                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong input.");
                    continue;
                }

                count++;

                if (guess == value)
                {
                    Console.WriteLine("You win on {0} try.", count);
                    break;
                }

                if (guess > value)
                {
                    Console.WriteLine("Value is lower.");
                }

                if (guess < value)
                {
                    Console.WriteLine("Value is higher.");
                }

            }

            Console.ReadKey();
        }
    }
}
