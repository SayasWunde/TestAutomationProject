using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace WebTestingProject.UI_Elements
{
    public class Username_Field_In_Login_Form_Post
    {

        public Username_Field_In_Login_Form_Post(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/header/p/span[3]/a")]
        public IWebElement TestCasesLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/div/p")]
        public IWebElement ShortDiscriptionSection { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-74\"]/div/p/a")]
        public IWebElement LinkInDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_LoginButtonInLoginFormPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_LoginFormPost { get; set; }
    }
}
