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
        private static MoneyInfoRepository repo = new MoneyInfoRepository();


        [TestMethod]
        public static void Setup(TestContext _context)
        {
            repo = new MoneyInfoRepository();
            repo.Clear();
        }
        [TestMethod]
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
        public void TestAddToDatabase()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new MoneyInfo(5000, 3500));

        }
        [TestMethod]
        public void TestAllMethod()
        {
            repo.Add(new MoneyInfo(4000, 2000));
            repo.Add(new MoneyInfo(100, 100));
            Assert.AreEqual(2, repo.GetCount());
        }
        [TestMethod]
        public void GetCount()
        {
            Assert.AreEqual(0, repo.GetCount());
            repo.Add(new MoneyInfo(2000, 1599));
            Assert.AreEqual(1, repo.GetCount());
        }

        [TestMethod]
        public void TestClear()
        {
            repo.Add(new MoneyInfo(200, 199));
            repo.Clear();
            Assert.AreEqual(0, repo.GetCount());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MoneyInfoIsUnique()
        {
            MoneyInfo e = new MoneyInfo(500, 499);
            repo.Clear();
            repo.Add(e);
            repo.Add(e);
        }
        
    }
}
