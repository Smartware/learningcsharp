using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Interfaces
{
    public class DropBox : IStorable
    {
        public void Compress(string data)
        {
            throw new NotImplementedException();
        }

        public string Decompress(string data)
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            throw new NotImplementedException();
        }

        public void Write(string data)
        {
            Console.WriteLine($"Writing {data} to Drop Box");
        }
    }
}
