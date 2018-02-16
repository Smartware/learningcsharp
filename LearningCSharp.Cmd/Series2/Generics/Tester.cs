using LearningCSharp.Cmd.Series2.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.Generics
{
    public class Tester
    {
        public static void Main()
        {
            var person = new 
            {
                LastName = "hgjhgghgh",
                FirstName = "khkhkjh" ,
                age = 89,
                Staffinfo = Staff.Initialize(7, "")
            };
           
            string age = "51xxx";

            if (int.TryParse(age, out int parseAge))
            {
                Console.WriteLine(parseAge);
            }
            else
            {
                Console.WriteLine(parseAge);
            }

            //int result = 0 ;
            //var addResult = Arithmentic.AddnMultiplier(4, 5, ref result);

            //Console.WriteLine(result);
            //Console.WriteLine(addResult);
            IDbManager<Staff> dbManager = new DbManager<Staff>();

            var staff = Staff.Initialize(1, "Prolifik Lexzy");
            dbManager.Add(staff);



            List<Point<double>> lines = new List<Point<double>>()
            {
                new Point<double>()
                {
                    X = 9,
                    Y = 7
                },
                 new Point<double>()
                {
                    X = 19,
                    Y = 70
                },
                  new Point<double>()
                {
                    X = 23,
                    Y = 67
                }
            };


            var pt = lines[0];

            Stack<Customer> staffsInaStack = new Stack<Customer>();
            staffsInaStack.Push(new Customer());

            People<Customer> p = new People<Customer>(staffsInaStack);

            p.AddPerson(new Customer());
            //int v = 'y';
            //string s = "";
            //s += 'c';

            // items.Push(new Box());
            // items.Push("Hello World");
            // items.Push("Prolifik Lexzy");
            //items.Push(121);
            //items.Push(true);
            //items.Push('y');

            //foreach (var item in items)
            //{
            //    Console.WriteLine((char)item);
            //}

            Console.Read();
        }
    }
}
