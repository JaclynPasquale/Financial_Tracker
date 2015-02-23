using Financial_Tracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Repository
{
    interface IGoalsRepository
    {
        int GetCount(); //
        void Add(Goals E); //
        void Delete(Goals E); //
        void Clear(); //
        IEnumerable<Goals> PastGoalss(); //
        IEnumerable<Goals> All(); //
        Goals GetById(int id); //

        
    }
}
