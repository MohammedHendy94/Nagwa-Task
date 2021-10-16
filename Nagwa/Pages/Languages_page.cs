using OpenQA.Selenium;


namespace Nagwa.Pages
{
    public class Languages_page : BaseClass
    {
        #region Finding page_elements and decalring variable
        // this region to fine the web page elements and the used varaibles
        private readonly By ENlishlanguage_btn = By.XPath("//div//ul//li//a[@href='/en/']");

        #endregion

        #region Constructor
        public Languages_page(IWebDriver driver) : base(driver) { }

        #endregion

        #region Methods for operations can be made on webelemnts and to handle the test cases
        public void SelectEnglishLAnguage()
        {
            wrapper.ClicklOnElement(ENlishlanguage_btn);
        }
        #endregion
    }
}
