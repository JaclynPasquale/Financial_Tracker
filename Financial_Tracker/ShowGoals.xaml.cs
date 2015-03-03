using Financial_Tracker.Model;
using Financial_Tracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Financial_Tracker
{
    /// <summary>
    /// Interaction logic for ShowGoals.xaml
    /// </summary>
    public partial class ShowGoals : Window
    {
        private Goals goalInput;
        private string oldTitle;
        private MoneyInfoRepository repo;

        
    
        public ShowGoals(Goals goals, MoneyInfoRepository repo)
        {
            InitializeComponent();
            
            goalInput = goals;
            this.repo = repo;
            goalDate.Text = goals.GoalDate.ToString();
            goalTitle.Text = goals.GoalTitle;
            goalType.Text = goals.GoalType;
            goalCost.Text = goals.GoalCost.ToString();
            timeTill.Text = timeTillDeadline().Value.Days.ToString();
            saveTarget.Text = SavingsPerDay().ToString();
            

        }
        private TimeSpan? timeTillDeadline()
        {
            DateTime now = DateTime.Now;
            var timeDiff = goalInput.GoalDate - now;
            return timeDiff;
        }
        private decimal SavingsPerDay()
        {
            decimal dailySavingsTarget =
                goalInput.GoalCost/timeTillDeadline().Value.Days;
            return Math.Round(dailySavingsTarget, 2);
        }
    }
        
 }

