using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_5_9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine(array.Length);
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            AddZeroElement(ref array);

            Console.WriteLine();
            Console.WriteLine(array.Length);
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            AddNewElement(ref array, 100);

            Console.WriteLine();
            Console.WriteLine(array.Length);
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();

        }
        
        private static void AddZeroElement(ref int[] array)
        {
            int[] arrayNew = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i] = array[i];
            }

            array = arrayNew;
        }

        private static void AddNewElement(ref int[] array, int value)
        {
            int[] arrayNew = new int[array.Length + 1];
            arrayNew[0] = value;

            for (int i = 0; i < array.Length; i++)
            {
                arrayNew[i + 1] = array[i];
            }

            array = arrayNew;
        }
    }
}
