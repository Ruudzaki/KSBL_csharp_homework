using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_5_9_0
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

            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
