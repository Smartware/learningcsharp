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
            Int32 x; // declaration
            x = 34;
            int y = 67; // Initialization

            Console.WriteLine("{0} + {1} = {2} ", x, y, (x + y));
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
    }
}
