using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_2_5_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 16;

            Console.WriteLine(getPowerTwo(a) ? "power 2" : "not power 2");

            Console.ReadKey();

        }

        static bool getPowerTwo(byte b)
        {
            bool flag = false;

            for (int i = 0; i < 8; i++)
            {
                if ((b & (1 << i)) != 0)
                {
                    if (flag == false)
                    {
                        flag = true;
                    }
                    else 
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
