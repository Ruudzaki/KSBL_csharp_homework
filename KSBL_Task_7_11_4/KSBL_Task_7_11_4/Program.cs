using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_7_11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(123456, "KSBL", "SimCorp");

            invoice1.CalculatePrice("chair", 4);

            Console.ReadKey();
        }
    }

    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;

        private string article;
        private int quantity;
        private double price;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        private void InitiateInvoice(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
            price = GetPrice(article);
        }

        public void CalculatePrice(string article, int quantity)
        {
            InitiateInvoice(article, quantity);
            
            if (price >= 0)
            {
                Console.WriteLine("{0}, {1}, Price with VAT: {2}, whitout VAT: {3}", article, quantity, price * quantity, price * quantity / 6 * 5);
            }
            else 
            {
                Console.WriteLine("Undefined article!");
            }
        }

        private double GetPrice(string article)
        {
            //emulate a DB :)
            switch (article)
            {
                case "chair":
                    return 100.12;
                case "table":
                    return 111.55;
                case "desk":
                    return 150;
                default:
                    return -1;
            }
        }
    }
}
