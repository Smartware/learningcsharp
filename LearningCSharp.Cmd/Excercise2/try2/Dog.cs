using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Excercise2.try2
{
    public class Dog
    {
        public string Name { get; set; }


        public static bool operator ==(Dog a, Dog b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Dog a, Dog b)
        {
            return a.Equals(b);

        }
        public override bool Equals(object obj)
        {
            var d = obj as Dog;

            if (d is Dog && d.Name == this.Name)
            {
                return true;
            }
            return false;
        }
    }
}
