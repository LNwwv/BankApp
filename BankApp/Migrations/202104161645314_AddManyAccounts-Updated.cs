namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyAccountsUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccounts", "Balance", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserAccounts", "Balance");
        }
    }
}
