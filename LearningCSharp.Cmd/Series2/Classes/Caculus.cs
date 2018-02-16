using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Classes
{
    public class Caculus: Math
    {
        public Caculus(int p1, int p2, int p3) : base(p1, p2, p3)
        {

        }
        public string ToString(string format)
        {
            return String.Empty;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
