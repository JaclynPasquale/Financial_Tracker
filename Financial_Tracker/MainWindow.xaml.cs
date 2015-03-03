﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using Financial_Tracker.Model;
using Financial_Tracker.Repository;
using Financial_Tracker;


namespace Financial_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MoneyInfoRepository repo = new MoneyInfoRepository();
       
        public MainWindow()
        {
            InitializeComponent();
            //salarydisplay.DataContext = repo.Context().MoneyInfo.Local;
            //expensesdisplay.DataContext = repo.Context().MoneyInfo.Local;
            GoalsList.DataContext = repo.Context().Goals.Local;
            MoneyInfoList.DataContext = repo.Context().MoneyInfo.Local;
            
            
            
        }
        

        public void Save_Click(object sender, RoutedEventArgs e)
        {
            string moneyin = Salary.Text;
            int salary = Int32.Parse(moneyin);

            string moneyout = Expenses.Text;
            int expenses = Int32.Parse(moneyout);

            MoneyInfo moneyinfo = repo.GetorCreate();
            moneyinfo.Expenses = expenses;
            moneyinfo.Salary = salary;
            moneyinfo.Difference = salary - expenses;
            repo.Save();
            MoneyInfoList.Items.Refresh();
            
           
  
        }

        private void AddGoal_Click(object sender, RoutedEventArgs e)
        {
            GoalsModal goals = new GoalsModal(repo);
            goals.Show();
            
        }



        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            object Sender = sender as TextBlock;
            
        }
         

        private void Delete_Goal_Click(object sender, RoutedEventArgs e)
        {
            Goals goals = new Goals();
            repo.Delete(goals);

        }


    }
}
