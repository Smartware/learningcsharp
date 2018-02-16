using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Interfaces
{
    public class Tester
    {
        public static void Main()
        {
            IStorable[] storables = new IStorable[2]
            {
            new DropBox(),
            new OneDrive()
            };

            int count = 0;
            foreach (IStorable item in storables)
            {
                count++;
                if (item != null)
                {
                    item.Write($"Hello World {count}");
                }

            }

            Console.Read();
        }
    }
}
