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
        public MoneyInfoRepository repo;
        
        public GoalsModal(MoneyInfoRepository repo)
        {
            this.repo = repo;
            InitializeComponent();
            //GoalsList.DataContext = repo.Context().Goals.Local;
        }
     

        private void AddGoalsDetail_Click(object sender, RoutedEventArgs e)
        {

            string goalTypes = ((ComboBoxItem)goalType.SelectedItem).Content.ToString();
            string cost = goalCost.Text;
            decimal GoalCost = decimal.Parse(cost);
            DateTime? date = goalDate.SelectedDate;
            
             //var prettyDate = date.Value.ToShortDateString();
            //DateTime GoalDate = DateTime.TryParse();
            //goalDate.SelectedDate.

            repo.Add(new Goals(goalTitle.Text, goalTypes, GoalCost, date));
            AddGoalsDetail.IsEnabled = false;
            this.Close();
            
            

        }
    }
}
