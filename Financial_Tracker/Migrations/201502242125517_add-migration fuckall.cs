namespace Financial_Tracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationfuckall : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Goals",
                c => new
                    {
                        GoalsId = c.Int(nullable: false, identity: true),
                        GoalTitle = c.String(),
                        GoalType = c.String(),
                        GoalCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GoalDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.GoalsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Goals");
        }
    }
}
