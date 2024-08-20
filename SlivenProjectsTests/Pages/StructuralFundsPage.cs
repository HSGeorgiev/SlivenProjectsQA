using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    // Descript the element and logic on the Structural Funds page,
    // excluding base elements, common for all pages.
    internal class StructuralFundsPage : BasePage
    {
        public StructuralFundsPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=9&Itemid=53";
    }
}
