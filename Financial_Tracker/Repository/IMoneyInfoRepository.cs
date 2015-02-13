using Financial_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Repository
{
    interface IMoneyInfoRepository
    {
        int GetCount(); //
        void Add(MoneyInfo E); //
        void Delete(MoneyInfo E); //
        void Clear(); //
        IEnumerable<MoneyInfo> PastMoneyInfos(); //
        
        IEnumerable<MoneyInfo> All(); //
        MoneyInfo GetById(int id); //
        
        IQueryable<MoneyInfo> SearchFor(Expression<Func<MoneyInfo, bool>> predicate);
    }
}
