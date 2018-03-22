using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.EF.Maps
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            this.Property(s => s.LastName).HasMaxLength(200);
            this.Property(s => s.LastName).IsUnicode(false);
            this.HasKey(s => s.Id);
             this.Ignore(s => s.FullName);
        }
    }
}
