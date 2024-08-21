using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&sobi2Task=search&Itemid=53";
        public By searchInputElement => By.XPath("//input[@id='sobi2Search']");
        public By searchButtonElement => By.XPath("//input[@id='sobiSearchSubmitBt']");
        public By anyWordRadioButtonElement => By.XPath("//input[@id='searchphraseany']");
        public By allWordRadioButtonElement => By.XPath("//input[@id='searchphraseall']");
        public By exactPhraseRadioButtonElement => By.XPath("//input[@id='searchphraseexact']");
        public By searchFormSlideButtonElement => By.XPath("//input[@id='sobiSearchFormExtOptToggle']");
        public By clearFormButtonElement => By.XPath("sobiSearchFormExtOptToggle");

    }
}
