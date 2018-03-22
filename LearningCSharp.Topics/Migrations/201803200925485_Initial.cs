namespace LearningCSharp.Topics.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 250),
                        WorkPhoneNo = c.String(),
                        MobileNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(maxLength: 250),
                        State = c.String(maxLength: 250),
                        Contact_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contacts", t => t.Contact_Id)
                .Index(t => t.Contact_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "Contact_Id", "dbo.Contacts");
            DropIndex("dbo.Addresses", new[] { "Contact_Id" });
            DropTable("dbo.Addresses");
            DropTable("dbo.Contacts");
        }
    }
}
