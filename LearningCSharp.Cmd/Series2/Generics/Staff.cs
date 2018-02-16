using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Generics
{
    public class Staff
    {
        static Staff()
        {
            Console.WriteLine("Constructor called......");
        }
        private Staff(int id, string fullName)
        {
            this.Id = id;
            this.FullName = fullName;
        }
        public static Staff Initialize(int id, string fullName)
        {
            return new Staff(id, fullName);
        }
        public int Id { get; private set; }
        public string FullName { get; private set; }

    }
}
