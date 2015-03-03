using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Model
{
    public class MoneyInfo

    {
        public MoneyInfo()
        {

        }
        public int MoneyInfoId { get; set; }
        public int Salary{get; set;}
        public int Expenses{get; set;}
        public int Difference { get; set; }

        public MoneyInfo(int Salary, int Expenses)
        {
            this.Salary = Salary;
            this.Expenses = Expenses;
            this.Difference = Salary - Expenses;
        }
        
    }
    
}
