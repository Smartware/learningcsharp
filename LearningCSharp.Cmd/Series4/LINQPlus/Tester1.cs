using LearningCSharp.Topics.Domains;
using LearningCSharp.Topics.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series4.LINQPlus
{
    public class Tester1
    {
        public static void Main()
        {
            List<Category> squad = new List<Category>()
            {
               new Category(){ Name =  "Jersey" },
               new Category(){ Name =  "Boot" },
            };

            var squadResult = squad.Last(s => s.Name.Contains("gaby"));
            Console.WriteLine(squadResult);

            var name1 = new List<dynamic> { new { Name = "Prolifik", Id = 1 } };
            var name2 = new List<dynamic> { new { Name = "Lexzy", Id = 2 } };

            var name1Name2 = from n1 in name1
                             join n2 in name2
                             on n1.Id equals n2.Id
                             select new { FullName = $"{n1.Name} {n2.Name}" };


            foreach (var item in name1Name2)
            {
                Console.WriteLine(item.FullName);
            }

            Console.WriteLine("======================");

            List<string> names = new List<string>()
            {
                "Gaby",
                "Prolifik",
                "Lola"
            };

            names.ForEach(n => { Console.WriteLine(n); });


            var categories = names.Select(n => new { Name = n });


            Console.WriteLine(names.Skip(2).Last());

            var prodList = CollectionManager.GetProduct().GroupBy(p => p.Category);

            foreach (var groupKey in prodList)
            {
                Console.Write(groupKey.Key);
                Console.WriteLine("======================");
                foreach (var item in groupKey)
                {
                    Console.WriteLine($"{item.Category}: {item.Name}");
                }
            }

            Console.Read();
        }
    }
}
