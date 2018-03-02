using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series4.LINQ
{
    public class Program
    {
        public static void Main()
        {
            //List<Char> charList = new List<Char>()
            //{
            //    'P', 'R', 'O', 'L', 'I', 'F', 'I', 'K'
            //};

            var charList = Console.ReadLine();

            //Func<Char, bool> action = (char x) =>
            //{
            //    if (x == 'P')
            //    {
            //        return true;
            //    }

            //    if (x == 'F')
            //        return true;

            //    return false;

            //    //return x == 'P' || x == 'F';
            // };

            //var a = charList.Where(x => x == 'P' || x == 'F');
            //var b = charList.Select(p => p);
            //var c = charList.OrderByDescending(x => x);


            var c = charList.Where(x => x == 'P' || x == 'F' || x == 'I')
                .Select(x => x)
                .OrderByDescending(x => x);

            //var n = from x in charList
            //        orderby x ascending
            //        select x;

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        public static bool Filter(Char x)
        {
            if (x == 'P')
            {
                return true;
            }

            if (x == 'F')
                return true;

            return false;
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public override string ToString()
        {
            return $"Id: {this.Id}, Name: {this.Name}";
        }
    }
}
