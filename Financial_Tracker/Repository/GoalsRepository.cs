using Financial_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Repository
{
     public class GoalsRepository
    {
        private GoalsContext _dbContext;

        public GoalsRepository()
        {
            _dbContext = new GoalsContext();
            _dbContext.goals.Load();
        }
        public GoalsContext Context()
        {
            return _dbContext;
        }
        public DbSet<Goals> GetDbSet()
        {
            return _dbContext.goals;
        }
    }
}
