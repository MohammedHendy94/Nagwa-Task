using OpenQA.Selenium;


namespace Nagwa.Pages
{
   
    class Search_Results: BaseClass
    {
        #region Finding page_elements and decalring variable
        // this region to fine the web page elements and the used varaibles
        private readonly By SearchResult = By.XPath("//div//ul[@class='list']//li//a");

        #endregion

        #region Constructor
        public Search_Results(IWebDriver driver) : base(driver) { }

        #endregion

        #region Methods for operations can be made on webelemnts and to handle the test cases
        public void clickOnSearchResult(int searchresultindex)
        {
            wrapper.ClickOnItemFromList(SearchResult, searchresultindex);
        }



        #endregion
    }
}
