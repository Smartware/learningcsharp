using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Excercise2.try1
{
    public class Cat : Animal
    {
        public Cat(double weight, string name) : base(weight, name)
        {

        }
        public override void Move()
        {
            Console.WriteLine($"{nameof(Cat)} Move");
        }

        public override void Speak()
        {
            Console.WriteLine($"{nameof(Cat)} Move");
        }

        public override void ToString()
        {
            Console.WriteLine($"{nameof(Cat)} ToString()");
        }
    }
}
