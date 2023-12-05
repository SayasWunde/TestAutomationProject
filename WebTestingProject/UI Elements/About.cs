using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace WebTestingProject.UI_Elements
{
    public class About
    {
        public About(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-2\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"page-2\"]/div/p")]
        public IWebElement ShortDescription { get; set; }
    }
}
