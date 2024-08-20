using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class HomePageTests : BaseTests
    {
       
        

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] topMenuChecks = homePage.menuLinksTextsCheck(homePage.topMenuItems, homePage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {homePage.topMenuTexts[i]} " +
                    $"should be {homePage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] topMenuChecks = homePage.menuLinksTextsCheck(homePage.inRegisterMenuItems, homePage.inRegisterMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"InRegister menu item {homePage.inRegisterMenuTexts[i]} " +
                    $"should be {homePage.inRegisterMenuTexts[i]}, but is not");
            }
        }
    }
}
