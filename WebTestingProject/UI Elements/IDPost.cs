
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class IDPost
    {

        public IDPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/header/p/span[3]/a")]
        public IWebElement SelectorsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/div/p[1]")]
        public IWebElement ShortDiscription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-110\"]/div/h3")]
        public IWebElement TitleAbouveImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"testImage\"]")]
        public IWebElement SmallerImage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_NamePost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_XpathPost { get; set; }














    }
}
