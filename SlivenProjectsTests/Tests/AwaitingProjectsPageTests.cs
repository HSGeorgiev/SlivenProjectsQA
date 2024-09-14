using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }


}
