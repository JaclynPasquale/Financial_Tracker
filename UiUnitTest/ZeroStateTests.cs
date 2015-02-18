using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace TestFinacialTracker
{
    [TestClass]
    public class ZeroStateTest : TestHelper
    {

        [ClassInitialize]
        public static void SetUpTests(TestContext _context)
        {
            TestHelper.SetupClass(_context);
        }

        [TestInitialize]
        public void SetUpTest()
        {
            TestHelper.TestPrep();
        }
        [TestCleanup]
        public void CleanUp()
        {
            TestHelper.CleanThisUp();
        }
       
        
        //[ClassCleanup]
        //public static void TearDown()
        //{
        //    window.Close();
        //    application.Close();
        //}
    }
}
