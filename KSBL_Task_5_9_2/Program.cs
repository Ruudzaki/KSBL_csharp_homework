using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_5_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 3 + 1;
            }

            Console.WriteLine();

            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());

            Console.WriteLine();

            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
