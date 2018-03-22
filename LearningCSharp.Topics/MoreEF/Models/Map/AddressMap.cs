using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.MoreEF.Models.Map
{
    public class AddressMap: EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            this.Property(a => a.Street).HasMaxLength(250);
            this.Property(a => a.State).HasMaxLength(250);
        }
    }
}
