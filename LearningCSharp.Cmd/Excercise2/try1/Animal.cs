using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Excercise2.try1
{
    public abstract class Animal
    {
        private double _weight;
        private string _name;
        public Animal(double weight, string name)
        {
            _weight = weight;
            _name = name;
        }

        public abstract void Speak();
        public abstract void Move();
        public new abstract void ToString();
    }
}
