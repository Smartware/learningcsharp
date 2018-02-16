using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2
{
    public enum CarType
    {
        SALON,
        TRUCK = 23,
        SUV
    }

    public class Tester
    {

        public static void Main()
        {
            Item i = new Item();
            i.name = "Tomato Paste";

            Console.WriteLine(i.Price);

            Item i2 = new Item();
            i2.name = "Match Stick";

            Console.WriteLine(i2.Price);
            //Console.WriteLine("Main A1");
            //Console.WriteLine("Main A2");
            //AnotherType.MethodA();
            //Console.WriteLine("End of Main Method.");


            //int y = 9;
            //int v = y;

            //v++;
            //Console.WriteLine(y);
            //Console.WriteLine(v);

            //CloudStorage store1 = new CloudStorage();
            //CloudStorage store2 = store1;
            //store1++;

            string s = "";

            Console.Read();
        }
    }



}
