using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace KSBL_Classwork_051119
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CancelKeyPress += Console_CancelKeyPress;

            /*
            while(true)
            {
                Console.WriteLine("Ping");
                Thread.Sleep(300);
            }
            */

            
            MyList<string> myList = new MyList<string>();
            myList.Set(0, "a");
            myList.Set(1, "b");
            myList.Set(2, "c");
            myList.Set(3, "d");
            myList.Set(4, "e");

            myList.Print();

            Console.ReadKey();
            
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            Console.WriteLine("Hello world!");
        }
    }

    class MyList<T>
    {
        T[] array = new T[5];

        public void Set(int index, T value)
        {
            array[index] = value;
        }

        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
