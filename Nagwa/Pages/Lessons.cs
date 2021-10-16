using OpenQA.Selenium;


namespace Nagwa.Pages
{
    class Lessons : BaseClass
    {
        #region Finding page_elements and decalring variables 
        private readonly By LessonWorkSheet = By.XPath("//*[@class='question-preview']");

        #endregion

        #region Constructor
        public Lessons (IWebDriver driver) : base(driver) { }
        #endregion

        #region Methods for operations can be made on webelemnts and to handle the test cases
        public void PreviewLessonWorksheet()
        {
            wrapper.ClicklOnElement(LessonWorkSheet);

        }
        #endregion
    }
}
