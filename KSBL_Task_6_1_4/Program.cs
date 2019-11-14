using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_6_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(10, 15, "A");
            Point point2 = new Point(10, 20, "B");
            Point point3 = new Point(20, 20, "C");
            Point point4 = new Point(30, 15, "D");
            Point point5 = new Point(15, 10, "E");

            Figure figure1 = new Figure(point1, point2, point3, point4, point5);
            Figure figure2 = new Figure(point1, point2, point3, point4);
            Figure figure3 = new Figure(point1, point2, point3);

            WriteName(figure1);
            Console.WriteLine(figure1.PerimeterCalculator());
            Console.WriteLine();

            WriteName(figure2);
            Console.WriteLine(figure2.PerimeterCalculator());
            Console.WriteLine();

            WriteName(figure3);
            Console.WriteLine(figure3.PerimeterCalculator());
            Console.WriteLine();

            Console.ReadKey();
        }

        public static void WriteName(Figure figure1)
        {
            for (int i = 0; i < figure1.Points.Count; i++)
            {
                Console.Write(figure1.Points.ElementAt(i).Name);
            }

            Console.WriteLine();
        }
    }
    class Point
    {
        private int value1;

        public int Value1
        {
            get { return value1; }
        }

        private int value2;

        public int Value2
        {
            get { return value2; }
        }

        private string name;

        public string Name
        {
            get { return name; }
        }

        public Point(int value1, int value2, string name)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.name = name;
        }
    }

    class Figure
    {
        private List<Point> points = new List<Point> { };

        public List<Point> Points
        {
            get { return points; }
        }

        public Figure(Point A, Point B, Point C)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            points.Add(D);
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points.Add(A);
            points.Add(B);
            points.Add(C);
            points.Add(D);
            points.Add(E);
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(A.Value1 - B.Value1, 2) + Math.Pow(A.Value2 - B.Value2, 2));
        }

        public double PerimeterCalculator()
        {
            double size = LengthSide(points.ElementAt(0), points.ElementAt(points.Count - 1));

            for (int i = 0; i < points.Count - 1; i++)
            {
                size += LengthSide(points.ElementAt(i), points.ElementAt(i + 1));
            }
            return size;
        }
    }
}
