using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_8_12_0
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "KSBL_Task_8_12_0";

            DerivedPrinter2 printer1 = new DerivedPrinter2();
            printer1.Print(value);
            Console.WriteLine("Hash: {0}", printer1.GetHashCode());

            DerivedPrinter printer2 = printer1 as DerivedPrinter;
            printer2.Print(value);
            Console.WriteLine("Hash: {0}", printer2.GetHashCode());

            Printer printer3 = printer2 as Printer;
            printer3.Print(value);
            Console.WriteLine("Hash: {0}", printer3.GetHashCode());

            Console.ReadKey();
        }
    }

    class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class DerivedPrinter : Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }

    class DerivedPrinter2 : DerivedPrinter
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
