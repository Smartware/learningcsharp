using LearningCSharp.Topics.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series5
{
    public class Tester2
    {
        public static void Main()
        {
            UniversityDbContext context = new UniversityDbContext();
            for (int i = 0; i < 9; i++)
            {
                context.Students.Add(new Student() { LastName = $"Great gaby {i}", FirstName = "Law" });
            }
            context.SaveChanges();

            var searchItems = context.Students.Where(s => s.LastName != "Great gaby"); ;

            foreach (var removeItem in searchItems)
            {
                context.Students.Remove(removeItem);
            }


            context.SaveChanges();

            var students = context.Students.Select(s => new { L = s.LastName, F = s.FirstName }).ToList();

            foreach (var item in students)
            {
                Console.WriteLine(item.L);
            }

            Console.Read();
        }
    }
}
