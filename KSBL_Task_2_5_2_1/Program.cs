using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_5_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool A = true;
            bool B = false;
            // A | B = !(!A & !B)

            Console.WriteLine(A | B == !(!A & !B));

            Console.ReadKey();
        }
    }
}
