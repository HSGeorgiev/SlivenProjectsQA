using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class ProjectsPageTests : BaseTests
    {

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var projectsPage = new ProjectsPage(driver);
            projectsPage.GoToTargetPage(projectsPage.pageUrl);
            bool[] topMenuChecks = projectsPage.menuLinksTextsCheck(projectsPage.topMenuItems, projectsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {projectsPage.topMenuTexts[i]} " +
                    $"should be {projectsPage.topMenuTexts[i]}, but is not");
            }
        }
    }
}
