using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class AwaitingProjectsPage : BasePage
    {
        public AwaitingProjectsPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=35&Itemid=53";
    }
}
