using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class NationalProgrammsPage : BasePage
    {
        public NationalProgrammsPage(IWebDriver driver) : base(driver)
        {

        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=6&Itemid=53";

    }
}
