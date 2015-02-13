﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financial_Tracker.Model;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;


namespace TestFinacialTracker
{
    public class TestHelper
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestFinancialTracker\\bin\\Debug\\Financial_Tracker");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }

        public void AndTheMoneyInforShouldBeFilledInWithZero()
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

        public void ThenIShouldNotSeeTheEventForm()
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

        public void GivenThereIsNoMoneyInfo()
        {
            throw new NotImplementedException();
        }

    }
}
