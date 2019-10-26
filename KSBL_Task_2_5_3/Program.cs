using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_5_3
{
    class Program
    {
        static int x = 5;
        static int y = 10;
        static int z = 15;

        static void Main(string[] args)
        {
            

            x += y >> x++ * z;
            Console.WriteLine(x);
            SetInitialValues();

            z = ++x & y * 5;
            Console.WriteLine(z);
            SetInitialValues();

            y /= x + 5 | z;
            Console.WriteLine(y);
            SetInitialValues();

            z = x++ & y * 5;
            Console.WriteLine(z);
            SetInitialValues();

            x = y << x++ ^ z;
            Console.WriteLine(x);
            SetInitialValues();

            Console.ReadKey();
        }

        static void SetInitialValues()
        {
            x = 5;
            y = 10;
            z = 15;
        }
    }
}
