using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_8_12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Plane());
            vehicles.Add(new Car());
            vehicles.Add(new Ship());
            vehicles.Add(new Ship());

            Console.WriteLine(vehicles.Count);
            Console.WriteLine();

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
                Console.WriteLine("Hash: {0}", vehicle.GetHashCode());

                Console.WriteLine("Coordinats: {0} : {1}", vehicle.PointX, vehicle.PointY);
                Console.WriteLine("Price: {0}", vehicle.Price);
                Console.WriteLine("Speed: {0}", vehicle.Speed);
                Console.WriteLine("Year: {0}", vehicle.Year);

                if (vehicle is Plane)
                {
                    Plane plane = (Plane)vehicle;
                    Console.WriteLine("Height: {0}", plane.Height);
                    Console.WriteLine("Amount of Passangers: {0}", plane.AmountPassangers);
                }
                if (vehicle is Ship)
                {
                    Ship ship = (Ship)vehicle;
                    Console.WriteLine("Shipment Port: {0}", ship.ShipmentPort);
                    Console.WriteLine("Amount of Passangers: {0}", ship.AmountPassangers);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        protected int pointX;
        protected int pointY;
        protected double price;
        protected double speed;
        protected int year;
        public int PointX
        {
            get { return pointX; }
            set { pointX = value; }
        }
        public int PointY
        {
            get { return pointY; }
            set { pointY = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }

    class Plane : Vehicle
    {
        private double height;
        private int amountPassangers;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public int AmountPassangers
        {
            get { return amountPassangers; }
            set { amountPassangers = value; }
        }

        public Plane()
        {
            pointX = 100;
            pointY = 100;
            price = 3000000;
            speed = 1200;
            year = 2016;
            height = 200.5;
            amountPassangers = 300;
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            pointX = 200;
            pointY = 200;
            price = 10000;
            speed = 220;
            year = 1950;
        }
    }

    class Ship : Vehicle
    {
        private int amountPassangers;
        private string shipmentPort;

        public string ShipmentPort
        {
            get { return shipmentPort; }
            set { shipmentPort = value; }
        }
        public int AmountPassangers
        {
            get { return amountPassangers; }
            set { amountPassangers = value; }
        }
        public Ship()
        {
            pointX = 300;
            pointY = 300;
            price = 9000000;
            speed = 20;
            year = 2000;
            shipmentPort = "Odessa";
            amountPassangers = 1300;
        }
    }
}
