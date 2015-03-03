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
using Financial_Tracker.Model;
using Financial_Tracker.Repository;

namespace Financial_Tracker
{
    /// <summary>
    /// Interaction logic for EditGoals.xaml
    /// </summary>
    public partial class EditGoals : Window
    {
        private Goals goalInput;
        private string oldTitle;
        private MoneyInfoRepository repo;


        public EditGoals(Goals goals, MoneyInfoRepository repo)
        {
            InitializeComponent();
            goalInput = goals;
            this.repo = repo;
            goalDate.SelectedDate = goals.GoalDate;
            goalTitle.Text = goals.GoalTitle;
            goalType.SelectedValue = goals.GoalType;
            goalCost.Text = goals.GoalCost.ToString();

        }

        private void EditSaveGoals_Click(object sender, RoutedEventArgs e)
        {
            var goals = repo.GetGoalsById(goalInput.GoalsId);
            goals.GoalCost = Convert.ToDecimal(goalCost.Text);
            goals.GoalDate = goalDate.SelectedDate;
            goals.GoalType = goalType.SelectedValue.ToString();
            goals.GoalTitle = goalTitle.Text;
            repo.Save();
            MainWindow.goalslist.Items.Refresh();
            this.Close();
           

        }
    }
}
