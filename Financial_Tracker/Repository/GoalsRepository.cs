using Financial_Tracker.Model;
using Financial_Tracker;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Repository
{
     public class GoalsRepository : IGoalsRepository
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
        public int GetCount()
        {
            return _dbContext.goals.Count<Model.Goals>();
        }

        public void Add(Model.Goals E)
        {
            _dbContext.goals.Add(E);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Goals E)
        {
            _dbContext.goals.Remove(E);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.goals.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Model.Goals> PastGoalss()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.Goals> All()
        {
            var qu = from Event in _dbContext.goals select Event;
            return qu.ToList<Model.Goals>();
        }

        public Model.Goals GetById(int id)
        {
            throw new NotImplementedException();
        }

        
        public void Dispose()
        {
            _dbContext.Dispose();
        }

    }
}
