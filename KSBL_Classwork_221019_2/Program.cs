using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_221019_2
{
    class Calculate
    {
        static void Main(string[] args)
        {
            int a = 33;
            int b = 12;
            int c = 322;

            Calculate calculate = new Calculate();
            Console.WriteLine(calculate.CalculateAverage(a, b, c));

            Console.ReadKey();
        }

        /// <summary>
        /// Calculate Average for three arguments 
        /// </summary>
        /// <param name="a">number 1</param>
        /// <param name="b">number 2</param>
        /// <param name="c">number 3</param>
        /// <returns></returns>
        int CalculateAverage(int a, int b, int c)
        {
            return (a + b + c) / 3;
        }
    }
}
