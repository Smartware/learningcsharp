using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Classes
{
    public class Tester
    {
        public static void Main()
        {
            object o = new Exception();

            object algebra = (Math)new Algebra();
            var caculus = new Caculus(6, 4, 9);


            Object m1 = Math.Initialize(5, 8);
            m1 = new Product();

            Math math1 = Math.Initialize(5, 8);

            math1.Add();

            DateTime now = DateTime.Now;

           // Console.WriteLine(now.ToString("d/MM/yy h:m:s"));
            Console.WriteLine(caculus);

            Console.Read();
        }

    }
}
