using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_291019_2
{
    class GetSetProgram
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            Student st2 = new Student();

            st1.SetName("KSBL");
            st1.SetAge(23);

            st2.Name = "";
            st2.Age = -1;

            st1.SayHello();
            st2.SayHello();

            Console.ReadKey();
        }
    }

    class Student
    {
        private string name;
        private int age;


        //prop
        //propfull

        public string FirstName { get; set; }

        //property
        public int Age
        {
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    age = 18;
                }
            }
            get { return age; }
        }

        public string Name
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    name = "Ivan";
                }

            }
            get { return name; }
        }


        public void SetName(string name)
        {
            if (name != "")
            {
                this.name = name;
            }
            else
            {
                this.name = "Ivan";
            }
        }


        public string GetName()
        {
            return name;
        }

        
        public void SetAge(int age)
        {

            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                this.age = 18;
            }

        }
        
        
        public int GetAge()
        {
            return age;
        }

        
        /// <summary>
        /// This action says "hello" with a name and age of a student.
        /// </summary>
        public void SayHello()
        {
            Console.WriteLine($"Hi! My name is {name}. I'm {age} years old.");
        }

    }


}
