using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series3.ExtensionPlus
{
    public static class Program
    {
        public static void Main()
        {
            //Console.WriteLine("{0:n0}", 100000000);
            //var myDate = new DateTime(2018, 02, 27);

            var myDate = "2018/02/27";
            Console.WriteLine(myDate);
            Console.WriteLine(myDate.ToCyberDateTime());

            Student std = new Student();
            std.FullName = Console.ReadLine();
            std.DoB = Console.ReadLine();

            //SaveBioData(std);
            Console.Read();
        }

        public static void SaveBioData(Student stud)
        {
            if (String.IsNullOrEmpty(stud.FullName))
            {
                return;
            }
            DateTimeFormatInfo info = DateTimeFormatInfo.InvariantInfo;
            DateTime dob;
            if (!DateTime.TryParse(stud.DoB, out dob))
            {
                return;
            }

            SaveToDatabase(stud);
        }

        private static void SaveToDatabase(Student stud)
        {
            throw new NotImplementedException();
        }

        public static DateTime ToCyberDateTime(this String value)
        {
            return DateTime.ParseExact(value, "yyyy/MM/dd", null);
        }
    }

    public class Student
    {
        public string FullName { get; set; }
        public String DoB { get; set; }
    }
}
