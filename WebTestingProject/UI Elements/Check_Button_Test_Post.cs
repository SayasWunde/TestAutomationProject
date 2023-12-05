
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class Check_Button_Test_Post
    {
        public Check_Button_Test_Post(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/header/p/span[3]/a")]
        public IWebElement SpecialElementsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[1]")]
        public IWebElement ShortDiscriptionSection_1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[2]")]
        public IWebElement ShortDiscriptionSection_2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[3]")]
        public IWebElement ShortDiscriptionSection_3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[4]")]
        public IWebElement ShortDiscriptionSection_4 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[5]")]
        public IWebElement ShortDiscriptionSection_5 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/h3")]
        public IWebElement CheckButtonsHeadline { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[6]/input[1]")]
        public IWebElement CheckBox_IHaveABike { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/p[6]/input[2]")]
        public IWebElement CheckBox_IHaveACar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/h6")]
        public IWebElement TextBeforLink  { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-33\"]/div/h6/a")]
        public IWebElement LinkToExample { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_TextInputFieldPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/span")]
        public IWebElement PreviousButtonTo_RadioButtonTestPost { get; set; }
    }
}
