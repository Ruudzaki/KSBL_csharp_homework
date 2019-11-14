using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_7_11_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(24.32, 26.76, 0.38);

            string cur = "eur";
            double amount = 300;

            //

            double convertAmount = converter.Convert(cur, amount);
            double reverseConvertAmount = converter.ReverseConvert(cur, amount);

            if (convertAmount >= 0)
            {
                Console.WriteLine("{1} {0} = {2} uah", cur, amount, convertAmount);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            if (convertAmount >= 0)
            {
                Console.WriteLine("{1} uah = {2} {0}", cur, amount, reverseConvertAmount);
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }

            Console.ReadKey();
        }
    }

    class Converter 
    {
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }

        public Converter(double usd, double eur, double rub)
        {
            Usd = usd;
            Eur = eur;
            Rub = rub;
        }

        public double Convert(string cur, double amount)
        {
            switch (cur)
            {
                case "usd":
                    return amount * Usd;

                case "eur":
                    return amount * Eur;

                case "rub":
                    return amount * Rub;
            }
            return -1;
        }

        public double ReverseConvert(string cur, double amount)
        {
            switch (cur)
            {
                case "usd":
                    return amount / Usd;

                case "eur":
                    return amount / Eur;

                case "rub":
                    return amount / Rub;
            }
            return -1;
        }
    }
}
