
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Radio_Button_Test_Post
    {
        public Radio_Button_Test_Post(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/header/p/span[3]/a")]
        public IWebElement SpecialElementsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/text()")]
        public IWebElement ShortDiscriptionSection_1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/p[2]")]
        public IWebElement ShortDiscriptionSection_2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/p[3]")]
        public IWebElement ShortDiscriptionSection_3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/h3")]
        public IWebElement RadioButtonHeadline { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/p[5]/input[1]")]
        public IWebElement RadioButton_Male { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/p[5]/input[2]")]
        public IWebElement RadioButton_Female { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/form/p[5]/input[3]")]
        public IWebElement RadioButton_Other { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/h6")]
        public IWebElement TextBeforeLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-10\"]/div/h6/a")]
        public IWebElement LinkToExample { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_CheckButtonTestPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_DropDownMenuTestPost { get; set; }

    }
}
