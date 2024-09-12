using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class CompletedProjectsPageTests : BaseTests
    {

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(completedProjectsPage.pageUrl);
            bool[] topMenuChecks = completedProjectsPage.menuLinksTextsCheck(completedProjectsPage.topMenuItems, completedProjectsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {completedProjectsPage.topMenuTexts[i]} " +
                    $"should be {completedProjectsPage.topMenuTexts[i]}, but is not");
            }
        }
    }
}
