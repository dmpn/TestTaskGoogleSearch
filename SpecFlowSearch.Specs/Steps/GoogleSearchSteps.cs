using Google.Protobuf.WellKnownTypes;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static NUnit.Core.NUnitFramework;

namespace SpecFlowSearch.Specs.Steps

{
    public class GoogleSearchSteps : BaseStep
    {
        private const string GooglePageUrl = "https://www.google.com";
        
        private const string GoogleSearchFieldXPath = "/html/body/div/div[3]/form/div[2]/div[2]/div[1]/div[1]/div[3]/div/div[3]/div/input[1]";
        private const string GoogleSearchButtonXPath = "/html/body/div/div[3]/form/div[2]/div[3]/center/input[1]";
        
        private string keyWord = string.Empty;

        private IWebElement googleSearchField = driver.FindElement(By.XPath(GoogleSearchFieldXPath));
        private IWebElement googleSearchButton = driver.FindElement(By.XPath(GoogleSearchButtonXPath));
        
        [Given(@"I have entered the Google Home page")]
        public void GivenIHaveEnteredTheGoogleHomePage()
        {
            driver.Navigate().GoToUrl(GooglePageUrl);
        }
        
        [Given(@"I have entered 'Automation' into google search bar")]
        public void GivenIHaveEnteredAutomationIntoGoogleSearchBar(string keyWord)
        {
            this.keyWord = keyWord;
            googleSearchField.SendKeys(this.keyWord);
        }
        
        [When(@"I press search button")]
        public void WhenIPressSearchButton()
        {
            googleSearchButton.Click();
        }

        [Then(@"the result should be a new page")]
        public void ThenTheFirstResultsShouldContainNeededKeyword()
        {
            Assert.AreEqual("Google", driver.Title);
            
        }
    }
}