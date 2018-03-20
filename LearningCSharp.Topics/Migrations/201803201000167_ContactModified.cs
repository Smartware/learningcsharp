namespace LearningCSharp.Topics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactModified : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "MobileNo", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "MobileNo", c => c.String());
        }
    }
}
