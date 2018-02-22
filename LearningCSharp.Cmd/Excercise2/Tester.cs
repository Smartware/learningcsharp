using LearningCSharp.Cmd.Excercise2.try1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d = LearningCSharp.Cmd.Excercise2.try2;

namespace LearningCSharp.Cmd.Excercise2
{
    public class Tester
    {
        public static void Main()
        {
            // Excercise 2

            d.Dog dogA = new d.Dog { Name = "Tupac" };
            d.Dog dogB = new d.Dog { Name = "Tupac" };

            if (dogA == dogB)
            {
                Console.WriteLine("Dogs are equal");
            }
            else
            {
                Console.WriteLine("Dogs are not equal");
            }


            Console.Read();

            // Excercise 1
            List<Animal> animals = new List<Animal>()
            {
                new Dog(4.5, "Lucy"),
                new Cat(4.5, "Mooreen"),
                new Dog(4.5, "Charlie"),
                new Cat(4.5, "Luke"),
                new Dog(4.5, "James"),
            };


            foreach (Animal item in animals)
            {
                item.Move();
                item.Speak();
                item.ToString();

            }

            Console.Read();
        }
    }
}
