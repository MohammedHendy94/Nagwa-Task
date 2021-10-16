using Nagwa.Wrapper_Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Nagwa.Pages
{
    public class BaseClass
    {
        protected IWebDriver Driver { get; set; }
        protected WebDriverWait wait;
        protected Actions actions;
        protected Wrapper wrapper;
		public BaseClass (IWebDriver driver)
		{
            this.Driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            actions = new Actions(driver);
            wrapper = new Wrapper(driver);
		}
    }
}
