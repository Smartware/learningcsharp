using LearningCSharp.Cmd.Series2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Generics
{
    public class People<T>
    {
        public People(Stack<T> people)
        {
            this.Peoples = people;
            CurrentPerson = default(T);
        }

        public void AddPerson(T item)
        {
            Peoples.Push(item);
        }
        public T CurrentPerson { get; set; }

        public Stack<T> Peoples { get; set; } = new Stack<T>();
    }
}
