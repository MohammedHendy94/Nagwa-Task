
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nagwa.Tests
{
    [TestClass]
  public class LanguagePage_tests
    {
        IWebDriver driver ;
        Pages.Languages_page Langpage;
        #region Test Data

        #endregion

        #region Test Setup
        [TestInitialize]
        // before each test case this method will be executed to open Nagwa URL.
        public void TestSetup()
        {
            driver = new ChromeDriver(@"C:\Users\Candle_Store\Desktop\Nagwa - Task\Nagwa");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.nagwa.com";
        }
        [TestCleanup]
        // After each test case execution in this class, this method will be executed.
        // This method closes the driver & terminates the session.
        public void TearDown()
        {
            driver.Quit();
        }
        #endregion

        #region Test Cases
        [TestMethod]
        public void ValidateThatUsercanchooseEnglishlanguge()
        {
            Langpage = new Pages.Languages_page(driver);
            Langpage.SelectEnglishLAnguage();
            Assert.IsTrue(driver.Url.Contains("en"));
        }
        #endregion

    }
}
