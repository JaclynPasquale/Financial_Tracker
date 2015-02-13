using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Model
{
    public class MoneyInfo
    {
        public int Salary;
        public int Expenses;

        public MoneyInfo(int Salary, int Expenses)
        {
            this.Salary = Salary;
            this.Expenses = Expenses;
        }
    }
    
}
