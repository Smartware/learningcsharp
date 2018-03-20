using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.MoreEF.Models.Map
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            this.Property(c => c.FullName).HasMaxLength(250);
            this.Property(c => c.MobileNo).HasMaxLength(50);
        }
    }
}
