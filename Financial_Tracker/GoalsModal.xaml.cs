using Financial_Tracker.Model;
using Financial_Tracker.Repository;
using Financial_Tracker;
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
    /// Interaction logic for GoalsModal.xaml
    /// </summary>
    public partial class GoalsModal : Window
    {
        public GoalsRepository goalsrepo;
        
        public GoalsModal(GoalsRepository goalsrepo)
        {
            this.goalsrepo = goalsrepo;
            InitializeComponent();
            GoalsList.DataContext = goalsrepo.Context().goals.Local;
        }
     

        private void AddGoalsDetail_Click(object sender, RoutedEventArgs e)
        {

            //goalTypes = goalType.SelectedValue.ToString();

            string goalTypes = ((ComboBoxItem)goalType.SelectedItem).Content.ToString();
            string cost = goalCost.Text;
            decimal GoalCost = decimal.Parse(cost);

            //goalDate.SelectedDate.GetValueOrDefault();

            
            goalsrepo.Add(new Goals(goalTitle.Text, goalTypes, GoalCost, goalDate.SelectedDate));
            AddGoalsDetail.IsEnabled = false;

        }
    }
}
