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
            bool[] inRegisterMenuChecks = homePage.menuLinksTextsCheck(homePage.inRegisterMenuItems, homePage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {homePage.inRegisterMenuTexts[i]} " +
                    $"should be {homePage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] byStatusMenuChecks = homePage.menuLinksTextsCheck(homePage.byStatusMenuItems, homePage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {homePage.byStatusMenuTexts[i]} " +
                    $"should be {homePage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] roleMenuChecks = homePage.menuLinksTextsCheck(homePage.roleOfSlivenMunMenuItems, homePage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {homePage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {homePage.byStatusMenuTexts[i]}, but is not");
            }
        }
    }
}
