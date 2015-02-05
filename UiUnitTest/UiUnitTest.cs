using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace UiUnitTest
{
    [TestClass]
    public class UITests
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\UiUnitTest\\bin\\Debug\\Financial_Tracker");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);

        }
        [TestMethod]
        public void TestZeroState()
        {
            TextBox first_box = window.Get<TextBox>("salarybox");
            TextBox second_box = window.Get<TextBox>("loansbox");
            TextBox third_box = window.Get<TextBox>("debtsbox");
            TextBox fourth_box = window.Get<TextBox>("utilitybox");
            Button submit_button = window.Get<Button>("submit");

            Assert.IsTrue(first_box.Enabled);
            Assert.IsTrue(second_box.Enabled);
            Assert.IsTrue(third_box.Enabled);
            Assert.IsTrue(fourth_box.Enabled);
            Assert.IsTrue(submit_button.Enabled);

        }
        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
