using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_5_9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            int[] arrayR = MyReverse(array);

            for (int i = 0; i < arrayR.Length; i++)
            {
                Console.WriteLine(arrayR[i]);
            }

            Console.WriteLine();

            int[] subArray = SubArray(array, 5, 10);

            for (int i = 0; i < subArray.Length; i++)
            {
                Console.WriteLine(subArray[i]);
            }

            Console.ReadKey();
        }

        private static int[] MyReverse(int[] array)
        {
            int[] arrayR = new int[array.Length];

            for (int i = 0, j = arrayR.Length - 1; i < array.Length; i++, j--)
            {
                arrayR[j] = array[i];
            }

            return arrayR;
        }

        private static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];

            for (int i = 0; i < count; i++, index++)
            {
                if (index < array.Length)
                {
                    subArray[i] = array[index];
                }
                else
                {
                    subArray[i] = 1;
                }
            }

            return subArray;
        }
    }
}
