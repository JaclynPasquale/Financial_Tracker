using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Tracker.Model
{
    public class Goals
    {
        public Goals()
        {

        }
        public string GoalTitle { get; set; }
        public string GoalType { get; set; }
        public decimal GoalCost { get; set; }
        //public DateTime GoalTime { get; set; }
        public int GoalsId { get; set; }

        public Goals(string goalTitle, string goalType, decimal goalCost)
        {
            this.GoalTitle = goalTitle;
            this.GoalType = goalType;
            this.GoalCost = goalCost;
            //this.GoalTime = goalTime;
        }
        
    }


}
