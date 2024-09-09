using OpenQA.Selenium;

namespace SlivenProjectsTests.Pages
{
    internal class OtherOverNationalPage : BasePage
    {
        public OtherOverNationalPage(IWebDriver driver) : base(driver)
        {
        }

        public new string pageUrl => BASE_URL + "/index.php?option=com_sobi2&catid=59&Itemid=53";

        public By categoriesNames => By.XPath("//p[@class='sobi2CatName']");
    }
}
