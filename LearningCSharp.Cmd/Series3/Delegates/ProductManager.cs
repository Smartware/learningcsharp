using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series3.Delegates
{

    public delegate void ItemFilter(string keyword);
    public delegate T ItemInsert<T>(T item);

    public class ProductManager
    {
        public ProductManager()
        {
            Stocks = new List<string>()
            {
                "Grand Square Bread",
                "Tomato Ketchup",
                "Tin Tomato",
                "Peanut Butter",
                "Hot Dog",
                "Chicken Ribs"
            };
        }


        public static void FilterStock(string searchName)
        {
            int count = 1;
            Func<String, Boolean> filter = (f) =>
            {
                Console.WriteLine(count++);
                if (f.IndexOf("ma") != -1)
                    return true;
                else
                    return false;

            };

            var result = Stocks.Where(filter);
            Console.WriteLine($"Searching for '{searchName}' inside product stocks");
        }

        public static string Add(string item)
        {
            return String.Empty;
        }

        public static List<string> Stocks { get; set; }
    }
}
