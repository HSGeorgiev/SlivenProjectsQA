using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class ProjectsPage : BasePage
    {
        // Descript the element and logic on the Projects page,
        // excluding base elements, common for all pages.
        public ProjectsPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&Itemid=86";

        public By categoriesNames => By.XPath("//p[@class='sobi2CatName']");
    }
}
