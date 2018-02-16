using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Interfaces
{
    public interface IStorable: ICompressible
    {
        void Compress(string data);
        void Write(string data);
        string Read();

    }
}
