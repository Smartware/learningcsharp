using LearningCSharp.Topics.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.LINQ
{
    public class CollectionManager
    {

        public static List<Product> GetProduct()
        {
            string[] categories = new string[] 
            {
                "BEVERAGES",
                "DETERGENT",
            };

            List<Product> productList = new List<Product>();
            productList.Add(new Product()
            {
                Category = categories.First(),
                Id = 1,
                Name = "Milo"
            });
            productList.Add(new Product()
            {
                Category = categories.Last(),
                Id = 2,
                Name = "Good mama"
            });
            productList.Add(new Product()
            {
                Category = categories.First(),
                Id = 3,
                Name = "Milk shake"
            });


            return productList;

        }
        public static List<KeyValuePair<string, string>> KeyList { get; set; } = new List<KeyValuePair<string, string>>();

        public static Dictionary<string, string> GetTechWords()
        {

            Dictionary<string, string> dictionary =
                new Dictionary<string, string>
                {
                    { "CLR", "Common Language Runtime" },
                    { "CTS", "Common Type System"},
                    { "CLI", "Common Language Infrstructure"}
                };


            KeyList = dictionary.ToList();
            KeyValuePair<string, string>[] v = dictionary.ToArray();
            return dictionary;
        }
    }
}
