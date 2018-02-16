using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Generics
{
    public class Arithmentic
    {
        public static int AddnMultiplier(int x, int y, ref int result)

        {
            result = x * y;
            return x + y;
        }
    }
}
