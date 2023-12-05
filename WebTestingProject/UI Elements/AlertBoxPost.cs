
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class AlertBoxPost
    {
        public AlertBoxPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        /********************Element for the pop up window need to be added***********/

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/header/p/span[3]/a")]
        public IWebElement SpecialElementsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-119\"]/div/p[2]")]
        public IWebElement ShortDiscription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_NewTabPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_NamePost { get; set; }
    }
}
