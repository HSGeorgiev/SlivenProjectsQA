using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class AwaitingProjectsPageTests : BaseTests
    {
        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            AwaitingProjectsPage awaitingProjectsPage = new AwaitingProjectsPage (driver);
            awaitingProjectsPage.GoToTargetPage(awaitingProjectsPage.pageUrl);
            bool[] topMenuChecks = awaitingProjectsPage.menuLinksTextsCheck(awaitingProjectsPage.topMenuItems, awaitingProjectsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {awaitingProjectsPage.topMenuTexts[i]} " +
                    $"should be {awaitingProjectsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            AwaitingProjectsPage awaitingProjectsPage = new AwaitingProjectsPage(driver);
            awaitingProjectsPage.GoToTargetPage(awaitingProjectsPage.pageUrl);
            bool[] inRegisterMenuChecks = awaitingProjectsPage.menuLinksTextsCheck(awaitingProjectsPage.inRegisterMenuItems, awaitingProjectsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {awaitingProjectsPage.inRegisterMenuTexts[i]} " +
                    $"should be {awaitingProjectsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            AwaitingProjectsPage awaitingProjectsPage = new AwaitingProjectsPage(driver);
            awaitingProjectsPage.GoToTargetPage(awaitingProjectsPage.pageUrl);
            bool[] byStatusMenuChecks = awaitingProjectsPage.menuLinksTextsCheck(awaitingProjectsPage.byStatusMenuItems, awaitingProjectsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Console.WriteLine(byStatusMenuChecks[i]);
                Console.WriteLine(awaitingProjectsPage.byStatusMenuTexts[i]);

                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {awaitingProjectsPage.byStatusMenuTexts[i]} " +
                    $"should be {awaitingProjectsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

    }


}
