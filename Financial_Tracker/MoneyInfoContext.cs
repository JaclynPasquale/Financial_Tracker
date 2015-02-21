using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Financial_Tracker;
using System.Threading.Tasks;
using System.Data.Entity;
using Financial_Tracker.Model;



namespace Financial_Tracker
    {
     public class MoneyInfoContext : DbContext
        {
            public DbSet<MoneyInfo> MoneyInfo { get; set; }
            public DbSet<Goals> Goals { get; set; }
        
     }
}
