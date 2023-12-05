using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Text_Input_field_Post
    {
        public Text_Input_field_Post(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/header/p/span[3]/a")]
        public IWebElement SpecialElementsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/div/p[1]")]
        public IWebElement ShortDiscriptionFirst { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/div/p[2]")]
        public IWebElement ShortDiscriptionSeconde { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/div/h3")]
        public IWebElement TextFieldHeadline { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-59\"]/div/p[3]/input")]
        public IWebElement TextField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_RegisterForm { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_CheckButtonTestPost { get; set; }

    }
}
