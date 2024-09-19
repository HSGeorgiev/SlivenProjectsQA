using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
