namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBankAccountNumberToRegistration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ClientNumber", c => c.String());
            AddColumn("dbo.AspNetUsers", "BankAccountNumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "UserNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "UserNumber", c => c.String());
            DropColumn("dbo.AspNetUsers", "BankAccountNumber");
            DropColumn("dbo.AspNetUsers", "ClientNumber");
        }
    }
}
