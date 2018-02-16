using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Interfaces
{
    public class OneDrive : IStorable
    {
        public void Compress(string data)
        {

        }

        void ICompressible.Compress(string data)
        {
            throw new NotImplementedException();
        }

        public string Decompress(string data)
        {
            throw new NotImplementedException();
        }

        public string Read()
        {
            return "Reading from Microsoft One Drive";
        }

        public void Write(string data)
        {
            Compress(data);
            Console.WriteLine($"Writing {data} to one drive");
        }
    }
}
