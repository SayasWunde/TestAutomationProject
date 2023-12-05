
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace WebTestingProject.UI_Elements
{
    public class RegisterFormPost
    {
        public RegisterFormPost(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/header/h1")]
        public IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/header/p/span[1]/a")]
        public IWebElement DateLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/header/p/span[2]/a")]
        public IWebElement TodorVachevLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/header/p/span[3]/a")]
        public IWebElement TestScenariosLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/header/p/span[4]/a")]
        public IWebElement CommentLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/figure/img")]
        public IWebElement Image { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/p[1]")]
        public IWebElement ShortDescrition { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/p[2]")]
        public IWebElement SubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/ul/li[1]")]
        public IWebElement Point_1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/ul/li[2]")]
        public IWebElement Point_2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/ul/li[3]")]
        public IWebElement Point_3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/ul/li[4]")]
        public IWebElement Point_4 { get; set; }
        //19 left
        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/h1")]
        public IWebElement InputFieldTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/h1")]
        public IWebElement InputFieldSubTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[2]/input")]
        public IWebElement UserIDField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[4]/input")]
        public IWebElement PasswordField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[6]/input")]
        public IWebElement NameField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[8]/input")]
        public IWebElement AddressField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select")]
        public IWebElement Country_Drop_Down_Menu_Field { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select/option[1]")]
        public IWebElement DDM_Default_Option { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select/option[2]")]
        public IWebElement DDM_Option_Australia { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select/option[3]")]
        public IWebElement DDM_Option_Canada { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select/option[4]")]
        public IWebElement DDM_Option_India { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select/option[5]")]
        public IWebElement DDM_Option_Russia { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[10]/select/option[6]")]
        public IWebElement DDM_Option_USA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[12]/input")]
        public IWebElement ZipCodeField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[14]/input")]
        public IWebElement EmailField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[16]/input")]
        public IWebElement RadioButton_Male_Option { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[17]/input")]
        public IWebElement RadioButton_Female_Option { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[19]/input")]
        public IWebElement CheckBoxEnglish { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"desc\"]")]
        public IWebElement AboutField { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"post-70\"]/div/form/ul/li[22]/input")]
        public IWebElement RigesterButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[2]/a/p")]
        public IWebElement NextButtonTo_LoginFormPost { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"main-content\"]/nav/div[1]/a/p")]
        public IWebElement PreviousButtonTo_TextInputFieldPost { get; set; }





    }
}
