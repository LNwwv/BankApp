namespace BankApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserNumberToRegistrtationModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserNumber");
        }
    }
}
