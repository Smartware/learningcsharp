using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2
{
    public class ConditionalStatement
    {
        public static void IfStatement()
        {
            int count = 0;
            lolipop:

            if (count < 30) // Exvaluate to true
                count++;
            Console.WriteLine($"{count}. Hello World.");
            goto lolipop;
        }

        public static void SwitchCaseStatement()
        {
            lolipop:
            var gender = Console.ReadLine();
            switch (gender.ToUpper())
            {
                case "FEMALE":
                    goto case "F";
                case "MALE":
                    goto case "M";
                case "F":
                    {
                        Console.WriteLine("Female");
                        break;
                    }
                case "M":
                    {
                        Console.WriteLine("M is Male");
                        break;
                    }
                default:
                    Console.WriteLine("Unkwown");
                    break;
            }
            Console.WriteLine("End of SwitchCaseStatement Method.");
            goto lolipop;
        }
    }
}
