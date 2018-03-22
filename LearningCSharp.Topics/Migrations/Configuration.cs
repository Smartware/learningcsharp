namespace LearningCSharp.Topics.Migrations
{
    using LearningCSharp.Topics.MoreEF.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LearningCSharp.Topics.MoreEF.PhoneBookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LearningCSharp.Topics.MoreEF.PhoneBookDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.Set<Contact>().AddOrUpdate(c => c.FullName, new Contact()
            {
                MobileNo = "08062066850",
                FullName = "Prolifik Lexzy"
            });

            context.SaveChanges();
        }
    }
}
