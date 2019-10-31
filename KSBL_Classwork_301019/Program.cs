using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSBL_Classwork_301019
{
    
    //Herbert Shilt - OOP

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals =
            {
                new Dog("Sharik"),
                new Cat("Murchik"),
                new Cow("Burenka")
            };

            foreach (var animal in animals)
            {
                DoAction(animal);
                
            }

            PetHomeAnimal((Dog)animals[0]);
            PetHomeAnimal((Cat)animals[1]);

            //Wait
            Console.ReadKey();
        }

        private static void PetHomeAnimal(IPet animal)
        {
            Console.WriteLine("*pet*");
            animal.Pet();

            Console.WriteLine();
        }

        private static void DoAction(Animal animal)
        {
            Console.WriteLine("Hi! My name is {0}", animal.Name);

            if (animal is Dog)
            {
                ((Dog)animal).DigBones();
            }

            Dog dog = animal as Dog;
            if (dog != null)
            {
                dog.DigBones();
            }

            animal.Voice();
            animal.Eat();
            animal.Sleep();

            Console.WriteLine();
        }
    }
}
