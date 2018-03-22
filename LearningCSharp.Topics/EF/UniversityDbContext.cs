using LearningCSharp.Topics.EF.Maps;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.EF
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext() : base("UniversityDbContext")
        {
            Database.SetInitializer<UniversityDbContext>(null);

            //Database.SetInitializer(new DropCreateDatabaseAlways<UniversityDbContext>());
        }

        //// public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new StudentMap());
        }
    }

    public class BaseEntity
    {
        [KeyAttribute]
        public int Id { get; set; }
    }
    public class Student: BaseEntity
    {
        private string _fullName;
        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
            set
            {
                _fullName = value;
            }
        }

       
        [Required]
        public string MatricNo { get; set; }
        [Required]
        [MaxLength(150)]
        public string LastName { get; set; }
        [MaxLengthAttribute(150)]
        public string FirstName { get; set; }
        [MyCustom(34)]
        public Department Department { get; set; }
    }

    public class Course: BaseEntity
    {
        public string Title { get; set; }
    }
    public class Department: BaseEntity
    {
        public string Name { get; set; }
    }

    public class MyCustomAttribute : Attribute
    {
        public MyCustomAttribute(int name)
        {

        }
    }
}
