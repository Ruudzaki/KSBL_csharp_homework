using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_9_13_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            int[] mass = new int[n];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = i;
            }

            Console.WriteLine("Max = {0}", mass.Max());
            Console.WriteLine("Min = {0}", mass.Min());
            Console.WriteLine("Sum = {0}", mass.Sum());
            Console.WriteLine("Average = {0}", mass.Average());

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 != 0)
                {
                    Console.Write(mass[i] + " ");
                }
            }

            Console.ReadKey();
        }

    }
}
