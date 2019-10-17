using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_1_3_1
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static int z = 0;

        static void Main(string[] args)
        {
            SetInitialValues();           

            //1
            x += y - x++ * z;
            Console.WriteLine(x);
            SetInitialValues();

            //2
            z = --x - y * 5;
            Console.WriteLine(z);
            SetInitialValues();

            //3
            y /= x + 5 % z;
            Console.WriteLine(y);
            SetInitialValues();

            //4
            z = x++ + y * 5;
            Console.WriteLine(z);
            SetInitialValues();

            //5
            x = y - x++ * z;
            Console.WriteLine(x);
            SetInitialValues();

            Console.ReadKey();
        }
        static void SetInitialValues()
        {
            x = 10;
            y = 12;
            z = 3;
        }
    }
}
