using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker
{
    public class GoalsContext : DbContext
    {
        public DbSet<Model.Goals> goals { get; set; }
    }
}
