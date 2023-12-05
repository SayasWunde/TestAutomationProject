using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTestingProject.UI_Elements
{
    public class NamePost
    {
        public NamePost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/header/p/span[3]/a")]
        public IWebElement SelectorsLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/div/p[1]")]
        public IWebElement ShortDiscription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/div/h3")]
        public IWebElement TextfieldDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/div/p[3]/input")]
        public IWebElement Textfield { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/span")]
        public IWebElement NextButtonTo_AlertBoxPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-111\"]/div/p[1]")]
        public IWebElement PreviousButtonTo_IDPost { get; set; }
    }
}
