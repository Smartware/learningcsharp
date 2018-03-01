using LearningCSharp.Topics.Delegates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series3.DelegateEx
{
    public class Tester
    {
        public static void Main()
        {
            Draw<Char, int> d = (x) => { return 9; };
            //d('i', new Line());

            Func<int, int, int> predicate = delegate (int i, int j)
            {
                return '\0';
            };


            List<String> names = new List<string>()
            {
                "Prolifik Lexzy",
                "Bill Gates"
            };

            var v = 2m;
            var result = 0m;

            Func<decimal, decimal, decimal> action = (decimal x, decimal y) =>
            {
                result = (x * v);
                return result;
            };

            List<Draw> drawList = new List<Draw>();
            int count = 0;
            Draw d1 = () => Console.WriteLine($"Delegate {++count}");
            Draw d2 = () => Console.WriteLine($"Delegate {++count}");
            Draw d3 = () => Console.WriteLine($"Delegate {++count}");

            drawList.Add(d1);
            drawList.Add(d2);
            drawList.Add(d3);

            foreach (var allDs in drawList)
            {
                allDs();
            }

            List<Byte> byteList = new List<byte>();

            FileStream stream = new FileStream("", FileMode.Create);
            Byte[] bytes = byteList.ToArray();


            Console.WriteLine("End of Main");
            Console.Read();

        }


        public static void SomeMethod(Func<decimal, decimal, decimal> param1)
        {

            Console.WriteLine($"{param1(2, 2)}");
        }
    }
}
