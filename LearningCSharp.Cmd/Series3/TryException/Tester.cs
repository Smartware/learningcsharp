using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.TryException
{
    public class Tester
    {
        public static void Main()
        {
            var i = 0;
            try
            {
                throw new MyCustomEx("oops");
                //var result = 8 / i;
                //throw new NotImplementedException("Not implemented exception was thrown");
            }
            catch(MyCustomEx ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (NotImplementedException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw ex;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Divide by zero exception was thrown");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            finally
            {
                Console.WriteLine("Finally block...");
            }

            Console.Read();
        }
    }
}
