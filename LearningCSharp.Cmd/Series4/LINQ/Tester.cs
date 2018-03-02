using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series4.LINQ
{
    public class Tester
    {
        public static void Main()
        {
            List<String> productStrings = new List<string>()
            {
                "Eva Table Water",
                "Ragolis Table Water",
                "Swan Table Water",
                "Indomie",
                "Ketchup Sauce"
            };
            int count = 1;

            var searchKeyword = Console.ReadLine().Trim();
            var stringResult = productStrings.Where(
                p => p.IndexOf(searchKeyword, StringComparison.InvariantCultureIgnoreCase) != -1)
            .OrderByDescending(p => p)
            .Select(p => new Product() { Id = count++, Name = p });


            foreach (var item in stringResult)
            {
                Console.WriteLine(item);
            }

            searchKeyword = Console.ReadLine().Trim();

            List<Product> productList = new List<Product>();
            productList.Add(new Product() { Id = 1, Name = "Eva Table Water" });
            productList.Add(new Product() { Id = 2, Name = "Ragolis Table Water" });
            productList.Add(new Product() { Id = 3, Name = "Swan Table Water" });
            productList.Add(new Product() { Id = 4, Name = "Indomie" });
            productList.Add(new Product() { Id = 5, Name = "Ketchup Sauce" });

        
            var result = productList.Where(
                p => p.Name.IndexOf(searchKeyword, StringComparison.InvariantCultureIgnoreCase) != -1)
            .OrderByDescending(p => p.Id);


            //   var result = productList.Where(p => p.Name.ToLower().Contains(searchKeyword))
            //.OrderByDescending(p => p.Id);


            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}