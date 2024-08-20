using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class HomePage : BasePage
    {

        // Descript the element and logic on the Home page,
        // excluding base elements, common for all pages.
        public HomePage(IWebDriver driver) : base(driver)
        {
            
        }

        
        public new string pageUrl => BASE_URL + "/";

        
    }
}
