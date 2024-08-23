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
            bool[] topMenuChecks = searchPage.menuLinksTextsCheck(searchPage.inRegisterMenuItems, searchPage.inRegisterMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"InRegister menu item {searchPage.inRegisterMenuTexts[i]} " +
                    $"should be {searchPage.inRegisterMenuTexts[i]}, but is not");
            }
        }
    }


}
