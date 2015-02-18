using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financial_Tracker.Model;

namespace TestFinacialTracker
{
    [TestClass]
    public class ViewingMoneyInfoTest : TestHelper
    {
        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            TestHelper.SetupClass(_context);
        }
        [TestInitialize]
        public void SetupTests()
        {
            GivenThereIsNoMoneyInfo(
                new MoneyInfo(500, 450),
                new MoneyInfo(420, 425)
                );
            TestHelper.TestPrep();

        }

    }
}
