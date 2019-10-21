using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_ClassWork_181019_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random R = new Random();
           
            int value = R.Next(100);
            GetResult(value);

            value = R.Next(7);
            GetResultDay(value);

            Console.ReadKey();

        }

        static private void GetResultDay(int value)
        {
            Console.WriteLine();
            Console.WriteLine(value);
            switch (value)
            {

                case 0:
                    Console.WriteLine("Monday");
                    break;

                case 1:
                    Console.WriteLine("Tuesday");
                    break;

                case 2:
                    Console.WriteLine("Wednesday");
                    break;

                case 3:
                    Console.WriteLine("Thursday");
                    break;

                case 4:
                    Console.WriteLine("Friday");
                    break;

                case 5:
                    Console.WriteLine("Saturday");
                    break;

                case 6:
                    Console.WriteLine("Sunday");
                    break;
            }

        }

        static private void GetResult(int value)
        {

            if (value % 2 == 0)
            {
                Console.WriteLine(value + " -- even");
            }
            else
            {
                Console.WriteLine(value + " -- odd");
            }

            Console.WriteLine(value % 2 == 0 ? value + " <-- even (t)" : value + " <-- odd (t)");
        }
    }
}
