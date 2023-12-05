
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class LoginFormPost
    {
        public LoginFormPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/header/p/span[3]/a")]
        public IWebElement TestScenariosLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/figure/img")]
        public IWebElement Image { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/p[1]")]
        public IWebElement FirstSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/ul[1]/li[1]")]
        public IWebElement Point_1_FirstSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/ul[1]/li[2]")]
        public IWebElement Point_2_FirstSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/ul[1]/li[3]")]
        public IWebElement Point_3_FirstSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/ul[1]/li[4]")]
        public IWebElement Point_4_FirstSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/p[2]")]
        public IWebElement SecondtSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/ul[2]/li[1]")]
        public IWebElement Point_1_SecondtSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/ul[2]/li[2]")]
        public IWebElement Point_2_SecondtSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/h1")]
        public IWebElement InputFieldTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/p[4]")]
        public IWebElement InputFieldSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/form/ul/li[2]/input")]
        public IWebElement UserNameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/form/ul/li[4]/input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/form/ul/li[6]/input")]
        public IWebElement RepeatPasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-72\"]/div/form/ul/li[7]/input")]
        public IWebElement LoginButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_UsernameFieldInLoginFormPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_RegisterFormPost { get; set; }




    }
}
