using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.OOP
{
    public class Tester
    {
        #region
        public static void Main()
        {
#if DEBUG
            Console.WriteLine("Debug Mode");
#else
             Console.WriteLine("Release Mode");
#endif
            Vehicle v = new Truck();


            Console.ReadLine();
        }
        #endregion
    }
}
