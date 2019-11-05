using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_4_8_2
{
    class BankCustomer
    {

        public int debtLeft { get; set; }
        public int currentDebtLeft { get; set; }
        public int agrPayment { get; set; }
        public int maturity { get; set; }

        public BankCustomer(int debtLeft, int maturity)
        {
            this.debtLeft = debtLeft;
            this.maturity = maturity;

            agrPayment = this.debtLeft / this.maturity;
            currentDebtLeft = 0;
        }

        static void Main()
        {
            BankCustomer cust = new BankCustomer(700, 7);
            string payment;

            while (true)
            {

                if (cust.debtLeft == 0)
                {
                    Console.ReadKey();
                    break;
                }

                Console.Write("This month's payment: ");

                payment = Console.ReadLine();

                if (payment == "exit")
                {
                    break;
                }

                try
                {
                    cust.WriteCalculatedDebt(int.Parse(payment));
                }
                catch
                {
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine();
                }
            }
        }

        private void WriteCalculatedDebt(int payment)
        {
            debtLeft -= payment;

            if (debtLeft == 0)
            {
                Console.WriteLine("Debt closed!");
            }
            else if (debtLeft < 0)
            {
                Console.WriteLine("Customer overpaid the debt by {0} UAH. Please, use negative numbers to return its amount to the customer.", -debtLeft);
            }
            else
            {
                maturity--;

                if (maturity >= 0)
                {
                    currentDebtLeft += agrPayment;
                }
                else
                {
                    Console.WriteLine("Debt overdue!");
                }

                currentDebtLeft -= payment;

                Console.WriteLine("Months left/overdue = {0} month(s)", maturity);
                Console.WriteLine("Lefted debt = {0} UAH", debtLeft);

                if (currentDebtLeft >= 0)
                {
                    Console.WriteLine("Current debt = {0} UAH", currentDebtLeft);
                }
                else
                {
                    Console.WriteLine("Overpaid by customer = {0} UAH", -currentDebtLeft);
                }
            }

            Console.WriteLine();
        }
    }
}
