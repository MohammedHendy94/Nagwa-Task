using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nagwa.Tests
{
    [TestClass]
    public class Worksheet_tests : BaseTests
    {
        IWebDriver driver;
        Pages.Worksheet_Homepage worksheet_Homepage;
        #region Test Data
        //private readonly string SearchText = "Addition";
        #endregion

        #region TestSetup
        [TestInitialize]
        public void TestSetup()
        {
            driver = new ChromeDriver(@"C:\Users\Candle_Store\Desktop\Nagwa - Task\Nagwa");
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.nagwa.com";
            Pages.Languages_page langpag = new Pages.Languages_page(driver);
            langpag.SelectEnglishLAnguage();
            Pages.HomePage hompag = new Pages.HomePage(driver);
            hompag.SearchingInWebsite(searchKeyWord);
            Pages.Search_Results srchreslt = new Pages.Search_Results(driver);
            srchreslt.clickOnSearchResult(numOfSearchResultsToBeClicked);
            Pages.Lessons lessons = new Pages.Lessons(driver);
            lessons.PreviewLessonWorksheet();
          

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
		public void GetNumberOfQuestions()
		{
           
           worksheet_Homepage = new Pages.Worksheet_Homepage(driver);
            int numOfSearchResults = worksheet_Homepage.GetNumberOfQuestions();
            System.Console.WriteLine("Number of Questions are: {0}", numOfSearchResults);
        }
    }
}
