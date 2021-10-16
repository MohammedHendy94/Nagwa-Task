using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Nagwa.Wrapper_Factory
{
   public class Wrapper
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait wait;

        public Wrapper(IWebDriver driver)
        {
            this.Driver = driver;
           // driver = new ChromeDriver();
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(15));
        }

        public void SendTextToElement(By element, String text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(element));
            Driver.FindElement(element).Clear();
            Driver.FindElement(element).SendKeys(text);
        }
        public void ClicklOnElement (By element)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(element));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            Driver.FindElement(element).Click();
        }
        public void ClickElementUsingKeyboardEnter(By element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            Driver.FindElement(element).SendKeys(Keys.Enter);
        }
        public void ClickOnItemFromList(By element, int index)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            Driver.FindElements(element)[index].Click();
        }
     
    }
}
