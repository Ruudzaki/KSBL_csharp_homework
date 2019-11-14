using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_6_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10, 15);

            Console.WriteLine("Area = {0}, Perimeter = {1}", rectangle1.Area, rectangle1.Perimeter);

            Console.ReadLine();
        }
    }

    class Rectangle
    {
        private double side1;
        private double side2;

        public double Area
        {
            get { return AreaCalculator(); }
        }

        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double AreaCalculator()
        {
            return side1 * side2;
        }

        public double PerimeterCalculator()
        {
            return side1 * 2 + side2 * 2;
        }
    }
}
