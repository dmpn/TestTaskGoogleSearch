
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowSearch.Specs.Steps
{ 
    public class BaseStep
    {
        protected static WebDriver driver = new ChromeDriver();
    }
}