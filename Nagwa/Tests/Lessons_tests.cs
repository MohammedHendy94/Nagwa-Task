using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nagwa.Tests
{
   [TestClass]
   public class Lessons_tests
    {
        IWebDriver driver;
        Pages.Lessons lesson;
        #region Test Data
        private readonly string search_text = "Addition";
        private readonly int Index_of_ResultItem = 1;
        #endregion
        
        #region Test Setupt and cleanup
        [TestInitialize]
        public void Testsetup()
        {
            driver = new ChromeDriver (@"C:\Users\Candle_Store\Desktop\Nagwa - Task\Nagwa");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.nagwa.com";
            Pages.Languages_page lanpag = new Pages.Languages_page(driver);
            lanpag.SelectEnglishLAnguage();
            Pages.HomePage hompag = new Pages.HomePage(driver);
            hompag.SearchingInWebsite(search_text);
            Pages.Search_Results srchreslt = new Pages.Search_Results(driver);
            srchreslt.clickOnSearchResult(Index_of_ResultItem);
        }
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }

        #endregion
        #region Test Cases
        [TestMethod]

        public void ValidateUserCanViewLessonworksheet()
        {
            lesson = new Pages.Lessons(driver);
            lesson.PreviewLessonWorksheet();
        }
        
        
        #endregion


    }
}
