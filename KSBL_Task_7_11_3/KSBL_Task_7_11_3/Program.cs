using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_7_11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Bilous", "Kostiantyn");
            employee1.SetPositionAndWorkingYears("Junior Dev", 0.7);

            employee1.CalculateSalaryAndTax();
            employee1.ShowInfo();

            Console.ReadKey();
        }
    }

    class Employee
    {

        public double Salary { get; set; }
        public double Tax { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double WorkingYears { get; set; }

        public Employee(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }

        public void SetPositionAndWorkingYears(string position, double workingYears)
        {
            Position = position;
            WorkingYears = workingYears;
        }

        public void CalculateSalaryAndTax()
        {
            switch (Position)
            {
                case "Senior Dev":
                    Salary = 2500 + (500 * WorkingYears);
                    break;
                case "Middle Dev":
                    Salary = 1000 + (500 * WorkingYears);
                    break;
                case "Junior Dev":
                    Salary = 500 + (500 * WorkingYears);
                    break;
                default:
                    Console.WriteLine("Unknown position!");
                    return;
            }

            Tax = Salary * 0.195;
        }

        public void ShowInfo()
        {
            if (Salary > 0)
            {
                Console.WriteLine("{0} {1}, {4} : Salary = {2} USD, Tax = {3} USD", Name, Surname, Salary, Tax, Position);
            }
            else 
            {
                Console.WriteLine("Can't show the info!");
            }
        }
    }
}
