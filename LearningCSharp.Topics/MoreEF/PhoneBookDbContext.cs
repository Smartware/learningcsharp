using LearningCSharp.Topics.MoreEF.Models.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.MoreEF
{
    public class PhoneBookDbContext : DbContext
    {
        public PhoneBookDbContext() : base("PhoneBookDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new AddressMap());
        }


    }
}
