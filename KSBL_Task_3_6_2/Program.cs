using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_3_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 21;

            Console.WriteLine(GetSum(a, b));
            GetEvenSum(a, b);

            Console.ReadKey();
        }

        static int GetSum(int a, int b)
        {
            int sum = 0;

            a++;
            for (; a < b; a++)
            {
                sum += a;
            }
            return sum;
        }

        static void GetEvenSum(int a, int b)
        {
            a++;
            for (; a < b; a++)
            {
                if (a % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(a);
            }
        }
    }
}
