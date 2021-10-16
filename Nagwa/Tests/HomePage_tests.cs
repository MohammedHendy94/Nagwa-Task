﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nagwa.Tests
{
    [TestClass]
    public class HomePage_tests
    {
        IWebDriver driver;
        Pages.HomePage homepage;
        #region Test Data
        private readonly String SearchText = "Addition";
        #endregion
        #region TestSetup
        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver(@"C:\Users\Candle_Store\Desktop\Nagwa Automation Task\Nagwa");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.nagwa.com";
            Pages.Languages_page langpag = new Pages.Languages_page(driver);
            langpag.SelectEnglishLAnguage();
        }
        [TestCleanup]
        // After each test case execution in this class, this method will be executed.
        // This method closes the driver & terminates the session.
        public void TearDown()
        {
            driver.Quit();
        }
        #endregion
        [TestMethod]
        public void ValidateUserCanSearch()
        {
            homepage = new Pages.HomePage(driver);
            homepage.SearchingInWebsite(SearchText);
            //Assert.IsTrue(driver.Url.Contains("addition"));
        }
    }
}