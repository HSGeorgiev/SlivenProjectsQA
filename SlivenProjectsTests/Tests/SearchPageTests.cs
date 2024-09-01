using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class SearchPageTests : BaseTests
    {

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var searchPage = new SearchPage(driver);
            searchPage.GoToTargetPage(searchPage.pageUrl);
            bool[] topMenuChecks = searchPage.menuLinksTextsCheck(searchPage.topMenuItems, searchPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {searchPage.topMenuTexts[i]} " +
                    $"should be {searchPage.topMenuTexts[i]}, but is not");
            }
        }


        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var searchPage = new SearchPage(driver);
            searchPage.GoToTargetPage(searchPage.pageUrl);
            bool[] inRegisterMenuChecks = searchPage.menuLinksTextsCheck(searchPage.inRegisterMenuItems, searchPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {searchPage.inRegisterMenuTexts[i]} " +
                    $"should be {searchPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void byStatus_LinksTexts_ShouldBeProper()
        {
            var searchPage = new SearchPage(driver);
            searchPage.GoToTargetPage(searchPage.pageUrl);
            bool[] byStatusMenuChecks = searchPage.menuLinksTextsCheck(searchPage.byStatusMenuItems, searchPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Console.WriteLine(byStatusMenuChecks[i]);
                Console.WriteLine(searchPage.byStatusMenuTexts[i]);

                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {searchPage.byStatusMenuTexts[i]} " +
                    $"should be {searchPage.byStatusMenuTexts[i]}, but is not");
            }
        }
    }


}
