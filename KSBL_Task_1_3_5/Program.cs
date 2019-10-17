using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_1_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int uberflu? = 1; <-- No
            int _Identifier = 1; //<-- Yes
            int \u006fIdentifier = 1; //<-- Yes
            //int  &myVar = 1; <-- No
            int myVariab1le = 1; //<-- Yes

            Console.WriteLine(_Identifier);
            Console.WriteLine(\u006fIdentifier);
            Console.WriteLine(myVariab1le);

            Console.ReadKey();
        }
    }
}
