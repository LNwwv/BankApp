namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAccBalancer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "AccountBalance", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "AccountBalance");
        }
    }
}
