using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Classes
{
    public class Math
    {
        private int _parameter1;
        private int _parameter2;
        private int _parameter3;

        public Math()
        {
        }
        public Math(int parameter1, int parameter2)
        {
            _parameter1 = parameter1;
            _parameter2 = parameter2;
        }

        public Math(int parameter1, int parameter2, int parameter3)
        {
            _parameter1 = parameter1;
            _parameter2 = parameter2;
            _parameter3 = parameter3;
        }


        public override string ToString()
        {
            return $"{_parameter1}: {_parameter2} : {_parameter3}";
        }


        public static Math Initialize(int parameter1, int parameter2)
        {
            return new Math(parameter1, parameter2);
        }

        public void Add()
        {
            Console.WriteLine($"{_parameter1} + {_parameter2} = {_parameter1 + _parameter2}");
        }

        public void Minus()
        {
            Console.WriteLine($"{_parameter1} - {_parameter2} = {_parameter1 - _parameter2}");
        }
    }
}
