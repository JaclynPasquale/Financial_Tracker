using Financial_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Repository
{
    public class MoneyInfoRepository : IMoneyInfoRepository
    {
        private MoneyInfoContext _dbContext;

        public MoneyInfoRepository()
        {
            _dbContext = new MoneyInfoContext();
            _dbContext.MoneyInfo.Load();
        }
        public MoneyInfoContext Context()
        {
            return _dbContext;
        }
        public DbSet<Model.MoneyInfo> GetDbSet()
        {
            return _dbContext.MoneyInfo;
        }


        public int GetCount()
        {
            return _dbContext.MoneyInfo.Count<Model.MoneyInfo>();
        }

        public void Add(Model.MoneyInfo E)
        {
            _dbContext.MoneyInfo.Add(E);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.MoneyInfo E)
        {
            _dbContext.MoneyInfo.Remove(E);
            _dbContext.SaveChanges();
        }

        public void Clear()
        {
            var a = this.All();
            _dbContext.MoneyInfo.RemoveRange(a);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Model.MoneyInfo> PastMoneyInfos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.MoneyInfo> All()
        {
            var qu = from Event in _dbContext.MoneyInfo select Event;
            return qu.ToList<Model.MoneyInfo>();
        }

        public Model.MoneyInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.MoneyInfo> SearchFor(System.Linq.Expressions.Expression<Func<Model.MoneyInfo, bool>> predicate)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        { 
            _dbContext.Dispose();
        }
    }
}
