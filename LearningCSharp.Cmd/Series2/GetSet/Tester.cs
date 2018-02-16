using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.GetSet
{
    public class Tester
    {
        public static void Main()
        {
            Product p = new Product();
            p.SetName("Bottle Water");
            Console.WriteLine(p.ProductInfo());
        }
    }
}
