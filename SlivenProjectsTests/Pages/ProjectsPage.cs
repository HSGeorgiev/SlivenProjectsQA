using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class ProjectsPage : BasePage
    {
        public ProjectsPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&Itemid=86";
    }
}
