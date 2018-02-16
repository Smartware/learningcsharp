using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series3.Delegates
{
    public class StaffManager
    {
        public static void FilterStaff(String name)
        {
            Console.WriteLine($"Searching for '{name}' inside staff database.");
        }
    }
}
