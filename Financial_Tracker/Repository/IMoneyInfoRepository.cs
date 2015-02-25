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
        MoneyInfo Get();
        MoneyInfo GetorCreate(); //
        void Create(MoneyInfo E); //
        void Clear(); //
       //IEnumerable<MoneyInfo> All(); //
        

        int GetGoalsCount(); //
        void ClearGoals(); //
        IEnumerable<Goals> PastGoals(); //
        Goals GetGoalsById(int id); //

        IQueryable<Goals> SearchFor(Expression<Func<Goals, bool>> predicate);
    }
}
