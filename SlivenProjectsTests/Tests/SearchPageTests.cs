using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }


}
