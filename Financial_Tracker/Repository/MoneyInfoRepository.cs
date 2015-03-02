﻿using Financial_Tracker.Model;
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
            
            _dbContext.Goals.Load();
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

        public Model.MoneyInfo GetMoney()
        {
           var query = from MoneyInfo in _dbContext.MoneyInfo
                           select MoneyInfo;
           return query.First<Model.MoneyInfo>();    
        }

        public void Create(Model.MoneyInfo E)
        {
            
            _dbContext.MoneyInfo.Add(E);
            _dbContext.SaveChanges();
        }

        public Model.MoneyInfo GetorCreate(Model.MoneyInfo E)
        {
            Model.MoneyInfo moneyinfo = GetMoney();
            
            if (moneyinfo == null)
            {
               
                Create(E);
            }
            return moneyinfo;
            
        }

        public void Delete(Model.MoneyInfo E)
        {
            _dbContext.MoneyInfo.Remove(E);
            _dbContext.SaveChanges();
        }

        public int Difference()
        {
            MoneyInfo moneyinfo = GetMoney();

           return moneyinfo.Salary - moneyinfo.Expenses;
        }

        

        public void Clear()
        {
            var a = this.All();
           _dbContext.MoneyInfo.RemoveRange(a);
           _dbContext.SaveChanges();
            
        }
        public void UpdateMoney(Model.MoneyInfo E)
        {
            Model.MoneyInfo moneyinfo = GetMoney();
            Delete(E);
            Create(moneyinfo);
    
           
        }


        public IEnumerable<Model.MoneyInfo> All()
        {
            var qu = from MoneyInfo in _dbContext.MoneyInfo select MoneyInfo;
            return qu.ToList<Model.MoneyInfo>();
        }

        public void Dispose()
        { 
            _dbContext.Dispose();
        }
  
     
        public DbSet<Model.Goals> GetGoalsDbSet()
        {
            return _dbContext.Goals;
        }
        public int GetGoalsCount()
        {
            return _dbContext.Goals.Count<Model.Goals>();
        }

        public void Add(Model.Goals E)
        {
            _dbContext.Goals.Add(E);
            _dbContext.SaveChanges();
        }

        public void Delete(Model.Goals E)
        {
            _dbContext.Goals.Remove(E);
            _dbContext.SaveChanges();
        }

        //public int DaysFromGoal()
        //{  
        //    var query = from Goals in _dbContext.Goals select Goals.GoalDate;
        //   // return ;

        //}

        public void ClearGoals()
        {
            var b = this.AllGoals();
            _dbContext.Goals.RemoveRange(b);
            _dbContext.SaveChanges();
        }

       

        public IEnumerable<Model.Goals> AllGoals()
        {
            var qu = from Goals in _dbContext.Goals select Goals;
            return qu.ToList<Model.Goals>();
        }

        public Model.Goals GetGoalsById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Model.Goals> SearchFor(System.Linq.Expressions.Expression<Func<Model.Goals, bool>> predicate)
        {
            throw new NotImplementedException();
        } 


         

       

    }
}
