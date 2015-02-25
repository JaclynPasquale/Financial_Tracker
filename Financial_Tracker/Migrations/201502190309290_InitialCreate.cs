namespace Financial_Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MoneyInfoes",
                c => new
                    {
                        MoneyInfoId = c.Int(nullable: false, identity: true),
                        Salary = c.Int(nullable: false),
                        Expenses = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MoneyInfoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MoneyInfoes");
        }
    }
}
