using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class CurrentYearPageTests : BaseTests
    {
        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var currentYearPage = new CurrentYearPage(driver);
            currentYearPage.GoToTargetPage(currentYearPage.pageUrl);
            bool[] topMenuChecks = currentYearPage.menuLinksTextsCheck(currentYearPage.topMenuItems, currentYearPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {currentYearPage.topMenuTexts[i]} " +
                    $"should be {currentYearPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var currentYearPage = new CurrentYearPage(driver);
            currentYearPage.GoToTargetPage(currentYearPage.pageUrl);
            bool[] inRegisterMenuChecks = currentYearPage.menuLinksTextsCheck(currentYearPage.inRegisterMenuItems, currentYearPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {currentYearPage.inRegisterMenuTexts[i]} " +
                    $"should be {currentYearPage.inRegisterMenuTexts[i]}, but is not");
            }
        }


        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var currentYearPage = new CurrentYearPage(driver);
            currentYearPage.GoToTargetPage(currentYearPage.pageUrl);
            bool[] byStatusMenuChecks = currentYearPage.menuLinksTextsCheck(currentYearPage.byStatusMenuItems, currentYearPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                //Console.WriteLine(byStatusMenuChecks[i]);
                //Console.WriteLine(completedProjectsPage.byStatusMenuTexts[i]);

                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {currentYearPage.byStatusMenuTexts[i]} " +
                    $"should be {currentYearPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            var currentYearPage = new CurrentYearPage(driver);
            currentYearPage.GoToTargetPage(currentYearPage.pageUrl);
            bool[] roleMenuChecks = currentYearPage.menuLinksTextsCheck(currentYearPage.roleOfSlivenMunMenuItems, currentYearPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {currentYearPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {currentYearPage.byStatusMenuTexts[i]}, but is not");
            }
        }

    }
}
