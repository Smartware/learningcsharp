using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series3.ExtensionPlus
{
    public static class Excercise
    {
        public static void Main()
        {


            Console.WriteLine(344095323433434.CommaDelimiter());
            Console.WriteLine(145345353.CommaDelimiter());
            Console.WriteLine(567735353.CommaDelimiter());
            Console.Read();
        }

        public static string CommaDelimiter(this IComparable value) => string.Format("{0:n3}", value);

        //https://stackoverflow.com/questions/20972845/c-sharp-default-format-for-comma-delimited-numbers

    }
}
