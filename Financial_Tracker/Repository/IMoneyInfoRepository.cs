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
        MoneyInfo GetMoney();
        MoneyInfo GetorCreate(MoneyInfo E); //
        void Create(MoneyInfo E); //
        void Clear(); //
       //IEnumerable<MoneyInfo> All(); //
        

        int GetGoalsCount(); //
        void ClearGoals(); //
        //IEnumerable<Goals> PastGoals(); //
        Goals GetGoalsById(int id); //

        IQueryable<Goals> SearchFor(Expression<Func<Goals, bool>> predicate);

        //int GetCount(); //
        //void Add(Event E); //
        //void Delete(Event E); //
        //void Clear(); //
        //IEnumerable<Event> PastEvents(); //
        //int CalculateMonth(Event E); //
        //IEnumerable<Event> All(); //
        //Event GetById(int id); //
        //Event GetByDate(string date); //
        //IQueryable<Event> SearchFor(Expression<Func<Event, bool>> predicate);
    }
}
