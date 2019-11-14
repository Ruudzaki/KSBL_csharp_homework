using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Task_7_11_0
{
    class Program
    {
        
        static void Main(string[] args)
        {
            User user1 = new User("Ruudzaki", "Kostiantyn", "Bilous", 23, DateTime.Now);

            Console.WriteLine("Login: {0}, Name: {1} {2}, Age: {3}, Reg. Date: {4}", user1.Login, user1.Name, user1.Surname, user1.Age, user1.RegDate);

            Console.ReadKey();
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public DateTime RegDate { get; }

        public User(string login, string name, string surname, int age, DateTime regDate)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            RegDate = regDate;
        }
    }
}
