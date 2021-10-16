using OpenQA.Selenium;
using System.Collections.Generic;

namespace Nagwa.Pages
{
	class Worksheet_Homepage : BaseClass
	{
		#region Variables
		private readonly By numOfQuestionsListElement = By.XPath("//div[@class='instances']/div");
		private IList<IWebElement> NumOfQuestionList;
		#endregion

		#region Constructor
		public Worksheet_Homepage(IWebDriver driver) : base(driver) { }
		#endregion

		#region Methods to handle test cases
		public int GetNumberOfSearchResults()
		{
			NumOfQuestionList = Driver.FindElements(numOfQuestionsListElement);
			return NumOfQuestionList.Count;
		}
		#endregion

	}
}
