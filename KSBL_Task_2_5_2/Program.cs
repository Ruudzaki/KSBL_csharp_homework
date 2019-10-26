using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 24;
            int bitNumber = 1;

            if (a % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

            Console.WriteLine(GetBit(a, bitNumber) ? "odd" : "even");

            Console.ReadKey();
        }

        public static bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
    }
}
