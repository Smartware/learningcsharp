using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.EF
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(): base("UniversityDbContext")
        {
        }
        public DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
