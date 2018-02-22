using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.Delegates
{
    public delegate void Draw();
    public delegate T2 Draw<in T1, out T2>(T1 x) ;
    public delegate void Draw<T1, T2, T3>(T1 x, T2 y, T3 z);

    public class Line
    { }
}
