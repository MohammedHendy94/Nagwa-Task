using OpenQA.Selenium;


namespace Nagwa.Pages
{
    class HomePage : BaseClass
    {
        #region Finding page_elements and decalring variable
        // this region to fine the web page elements and the used varaibles
        // relative xpath for the SearchTextBox is (//div//form//label//input[@id='txt_search_query'])
        // relative xpath for the SearchIcon is (/html/body/header/div[1]/div/div[3]/button/i)

        private readonly By SearchIcon = By.XPath("/html/body/header/div[1]/div/div[3]/button/i");
        private readonly By SearchTextBox = By.Id("txt_search_query");

        #endregion

        #region Constructor
        public HomePage(IWebDriver driver) : base (driver) { }
        #endregion

        #region Methods for operations can be made on webelemnts and to handle the test cases
        public void SearchingInWebsite(string search_text)
        {
            wrapper.ClicklOnElement(SearchIcon);
            wrapper.SendTextToElement(SearchTextBox, search_text);
            wrapper.ClickElementUsingKeyboardEnter(SearchTextBox);
        }
        #endregion
    }
}
