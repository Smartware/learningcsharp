using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2
{
    public class AnotherType
    {
        public static void MethodA()
        {
            Console.WriteLine("Statement A1");
            Console.WriteLine("Statement A2");
            MethodB();
            Console.WriteLine("Statement A3");
            Console.WriteLine("End Statement Method A");

        }

        public static void MethodB()
        {
            Console.WriteLine("Statement B1");
            Console.WriteLine("Statement B2");
            Console.WriteLine("End Statement Method B3");
        }
    }

    
}


