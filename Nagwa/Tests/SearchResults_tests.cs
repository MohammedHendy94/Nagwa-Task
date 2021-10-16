using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nagwa.Tests
{
    [TestClass]
   public class SearchResults_tests : BaseTests
    {
        IWebDriver driver;
        Pages.Search_Results searchreslts;

        #region Test Data
        //private readonly string searchTXT = "addition";
        //private readonly int index_of_result_Item = 1;
        #endregion
        #region Setups tests
        [TestInitialize]

        public void TestSetup()
        {
            driver = new ChromeDriver(@"C:\Users\Candle_Store\Desktop\Nagwa - Task\Nagwa");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.nagwa.com";
            Pages.Languages_page langpag = new Pages.Languages_page(driver);
            langpag.SelectEnglishLAnguage();
            Pages.HomePage homepag = new Pages.HomePage(driver);
            homepag.SearchingInWebsite(searchKeyWord);
        }
        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }

        #endregion

        #region Test Cases
        [TestMethod]

        public void ValidateUserCanClickOnSearchResults()
        {
            searchreslts = new Pages.Search_Results(driver);
            searchreslts.clickOnSearchResult(numOfSearchResultsToBeClicked);
        }
        
        #endregion
    }
}
