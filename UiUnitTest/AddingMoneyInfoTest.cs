using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.BDDfy;
using TestFinacialTracker;
using Financial_Tracker.Model;

namespace TestFinancialTracker
{
    /// <summary>
    /// Summary description for AddingMoneyInfo
    /// </summary>
    [TestClass]
    public class AddingMoneyInfoTest : TestHelper
    {
        // As a user
        // In order to see my expenses and income
        // I want to create a new record of my money info including salary and expenses
        // * Salary and expenses will be auto filled in with 0
        // * Salary must contain at least one number
        // * Expenses are required and must be more than 0
        // * Click "Save" to add the money info
        // * The  shows up in the dashboard money section and the form goes away
        // * Click "x" to close the form

        [TestMethod]
        public void ScenarioHappyPathMoneyInfoCreation()
        {
            GivenThereIsNoMoneyInfo();
            WhenIClick("Add Money Info");
            ThenIShouldSeeTheMoneyInfoForm();
            AndTheButtonShouldBeDisabled("+");
            WhenIFillInSalaryWith("1,500");
            WhenIFillInExpensesWith("1,000");
            AndIClick("Save");
            ThenIShouldNotSeeTheMoneyInfoForm();
            AndIShouldSeeMoneyInfoFor("1,500", "1,000");
            AndTheButtonShouldBeEnabled("+");
        }

        [TestMethod]
        public void ScenarioDataValidationForMoneyInfoCreation()
        {
            GivenThereIsNoMoneyInfo();
            WhenIClick("Add Money Info");
            ThenIShouldSeeTheMoneyInfoForm();
            AndTheButtonShouldBeDisabled("+");
            AndIClick("Save");
            AndIShouldSeeAnErrorMessage("Please Fill in Salary and Debts");
            WhenIFillInSalaryWith("1,500");
            WhenIFillInExpensesWith("1,000");
            AndIClick("Save");
            ThenIShouldNotSeeTheMoneyInfoForm();
            AndIShouldSeeMoneyInfoFor("1,500", "1,000");
            AndTheButtonShouldBeEnabled("+");
        }

        

        [TestMethod]
        public void ScenarioCancelingOutOfMoneyInfoCreation()
        {
            GivenThereIsNoMoneyInfo();
            WhenIClick("Add Money Info");
            ThenIShouldSeeTheMoneyInfoForm();
            WhenIFillInSalaryWith("1,500");
            AndIClick("Cancel");
            ThenIShouldNotSeeTheMoneyInfoForm();
            AndIShouldSeeMoneyInfoFor("0", "0");
            AndTheButtonShouldNotBeEnabled("+");
            WhenIClick("Add Money Info");
            ThenIShouldSeeTheMoneyInfoForm();
            AndTheMoneyInfoShouldBeFilledInWithZero();


        }

        
    }
}
