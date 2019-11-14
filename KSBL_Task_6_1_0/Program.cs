using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_6_1_0
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address(65026, "Ukraine", "Odessa", "Zhukovskogo", 17, 5);

            Console.WriteLine("{0}, {1}, {2} {3}/{4}, {5}", address1.Country, address1.City, address1.Street, address1.House, address1.Apartment, address1.Index);

            Console.ReadKey();
        }
    }

    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public Address(int index, string country, string city, string street, int house, int apartment)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartment = apartment;
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
