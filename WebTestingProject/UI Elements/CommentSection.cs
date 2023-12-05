using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTestingProject.UI_Elements
{
    class CommentSection
    {
        public CommentSection(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "reply-title")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"commentform\"]/p[1]")]
        public IWebElement SubTitle { get; set; }

        [FindsBy(How = How.Id, Using = "comment")]
        public IWebElement Comment { get; set; }

        [FindsBy(How = How.Id, Using = "author")]
        public IWebElement Name { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "url")]
        public IWebElement WebSite { get; set; }

        [FindsBy(How = How.Id, Using = "wp-comment-cookies-consent")]
        public IWebElement SaveMyNameCheckBox { get; set; }

        [FindsBy(How = How.Name, Using = "submit")]
        public IWebElement SubmitButton { get; set; }
        //*[@id="mh-comments"]/h4/span
        [FindsBy(How = How.XPath, Using = "//*[@id=\"div-comment-4379\"]/div[1]")]
        public IWebElement RedMessageConfirmed { get; set; }


    }
}
