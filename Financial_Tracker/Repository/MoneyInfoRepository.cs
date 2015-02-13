using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Repository
{
    public class MoneyInfoRepository : IMoneyInfoRepository
    {

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void Add(Model.MoneyInfo E)
        {
            throw new NotImplementedException();
        }

        public void Delete(Model.MoneyInfo E)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.MoneyInfo> PastMoneyInfos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Model.MoneyInfo> All()
        {
            throw new NotImplementedException();
        }

        public Model.MoneyInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.MoneyInfo> SearchFor(System.Linq.Expressions.Expression<Func<Model.MoneyInfo, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
