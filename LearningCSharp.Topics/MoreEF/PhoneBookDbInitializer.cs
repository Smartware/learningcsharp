using LearningCSharp.Topics.MoreEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.MoreEF
{
    public class PhoneBookDbInitializer: CreateDatabaseIfNotExists<PhoneBookDbContext>
    {
        protected override void Seed(PhoneBookDbContext context)
        {
            base.Seed(context);

            context.Set<Contact>().AddOrUpdate(c => c.FullName, new Contact()
            {
                MobileNo = "08062066850",
                FullName = "Prolifik Lexzy"
            });

            context.SaveChanges();

        }
    }
}
