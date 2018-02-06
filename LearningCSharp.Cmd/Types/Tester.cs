using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Types
{
    public class Tester
    {
        public static void Main()
        {
            Int16 w = 23;
            short z = w;

            Int32 x = 23;
            int y = w;

            Int64 a = 89;
            long b = a;


            char d = '\t';
            Char e = d;

            Console.WriteLine($"{x} + {y} = {x + y}");
        }
    }
}
