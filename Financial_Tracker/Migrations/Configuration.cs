namespace Financial_Tracker.Migrations
{
    using Financial_Tracker.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Financial_Tracker.MoneyInfoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Financial_Tracker.MoneyInfoContext";
        }

        protected override void Seed(Financial_Tracker.MoneyInfoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //context.MoneyInfo.AddOrUpdate<Model.MoneyInfo>(
            //    n => n.Salary,// any linq expression
            //    new Model.MoneyInfo { Salary = 200, Expenses = 100 }
            //    );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
