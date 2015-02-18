using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financial_Tracker.Model;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using System.Reflection;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
using Financial_Tracker.Repository;
using Financial_Tracker;
using System.Windows.Automation;
using TestStack.White.UIItems;
using Finacial_Tracker.Model.Finacial_Tracker;


namespace TestFinacialTracker
{
    public class TestHelper
    {

        private static TestContext test_context;
        protected static Window window;
        private static Application application;
        private static MoneyInfoRepository repo = new MoneyInfoRepository();
        private static MoneyInfoContext context;
        private static String applicationPath;

        public static void SetupClass(TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestFinancialTracker\\bin\\Debug\\Financial_Tracker");
        }
        public static void TestPrep()
        {
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            context = repo.Context();
        }

        public void AndTheMoneyInfoShouldBeFilledInWithZero()
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldNotBeEnabled(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIShouldSeeAnErrorMessage(string p)
        {
            throw new NotImplementedException();
        }
        public void AndTheButtonShouldBeEnabled(string p)
        {
            throw new NotImplementedException();
        }

        public void AndIShouldSeeMoneyInfoFor(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldNotSeeTheMoneyInfoForm()
        {
            throw new NotImplementedException();
        }

        public void AndIClick(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInExpensesWith(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInSalaryWith(string p)
        {
            throw new NotImplementedException();
        }

        public void AndTheButtonShouldBeDisabled(string p)
        {
            throw new NotImplementedException();
        }

        public void ThenIShouldSeeTheMoneyInfoForm()
        {
            throw new NotImplementedException();
        }

        public void WhenIClick(string p)
        {
            throw new NotImplementedException();
        }

        public static void GivenThereIsNoMoneyInfo(params MoneyInfo[] moneyinfos)
        {
            foreach (MoneyInfo money in moneyinfos)
            {
                // Add MoneyInfo to MoneyInfos here.
                repo.Add(money);
            }

            //context.SaveChanges();
            Assert.AreEqual(moneyinfos.Length, repo.GetCount());
        }
        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
            repo.Clear();
        }

    }
}
