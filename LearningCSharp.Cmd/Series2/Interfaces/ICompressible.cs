using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Interfaces
{
    public interface ICompressible
    {
        void Compress(string data);
        string Decompress(string data);
    }
}
