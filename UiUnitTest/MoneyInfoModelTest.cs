using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financial_Tracker.Model;

namespace TestFinacialTracker
{
    [TestClass]
    public class MoneyInfoModelTest
    {
        [TestMethod]
        public void CreateMoneyInfoStoreProperties()
        {
            MoneyInfo MyMoney = new MoneyInfo(50, 100);
            Assert.AreEqual(50, MyMoney.Salary);
            Assert.AreEqual(100, MyMoney.Expenses);
        }
    }
}
