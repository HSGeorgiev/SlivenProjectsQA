using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class CurrentYearPage : BasePage
    {
        public CurrentYearPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=87&Itemid=53";
    }
}
