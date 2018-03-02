using LearningCSharp.Topics.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series4.LINQPlus
{
    public class Tester
    {
        public static void Main()
        {
            var keywords = CollectionManager.GetTechWords();
            var keyList = CollectionManager.KeyList;

            Dictionary<string, string> dictionary2 =
                new Dictionary<string, string>();

            dictionary2.Add("CLR", "Common Language Runtime(2)");

            var j = keywords.Union(dictionary2);

            foreach (var item in j)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine("===============================");

            keywords["CLR"] = "Common Language Runtime (2)";
            //if (!keywords.ContainsKey("CLR"))
            //{
            //    keywords.Add("CLR", "Common Language Runtime");
            //}

            foreach (var item in keywords)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.ReadLine();
            //IEnumerable<KeyValuePair<string, string>> a = keywords.Where(n => n.Value.Contains("a"))
            //    .OrderBy(n => n.Value.Length)
            //    .Select(n => n);

            var a = from k in keywords
                    let nk = k.Value.Replace("a", "")
                    where nk.Length > 9
                    select k;


          
        }
    }
}
