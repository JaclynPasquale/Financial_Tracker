using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Financial_Tracker.Model;
using Financial_Tracker;
using Financial_Tracker.Repository;


namespace TestFinacialTracker
{
    [TestClass]
    public class MoneyInfoRepositoryTest
    {
        private static MoneyInfoRepository repo;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            repo = new MoneyInfoRepository();
            repo.Clear();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            repo.Clear();
            repo.Dispose();
        }

        [TestMethod]
        public void ClearDatabase()
        {
            repo.Clear();
        }
        [TestMethod]
        public void TestCreateToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Create(new MoneyInfo(5000, 3500));
           

        }
        [TestMethod]
        public void TestAllMethod()
        {
            repo.Clear();
            repo.Create(new MoneyInfo(4000, 2000));
            Assert.AreEqual(1, repo.GetCount());
        }
        [TestMethod]
        public void GetCount()
        {
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
            repo.Create(new MoneyInfo(2000, 1599));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Create(new MoneyInfo(200, 199));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void OnlyOneMoneyInfo()
        {
            MoneyInfo e = new MoneyInfo(500, 499);
            repo.Clear();
            repo.Create(e);
            repo.Create(e);
        }
        
    }
}
