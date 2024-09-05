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

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var projectsPage = new ProjectsPage(driver);
            projectsPage.GoToTargetPage(projectsPage.pageUrl);
            bool[] inRegisterMenuChecks = projectsPage.menuLinksTextsCheck(projectsPage.inRegisterMenuItems, projectsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {projectsPage.inRegisterMenuTexts[i]} " +
                    $"should be {projectsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var projectsPage = new ProjectsPage(driver);
            projectsPage.GoToTargetPage(projectsPage.pageUrl);
            bool[] byStatusMenuChecks = projectsPage.menuLinksTextsCheck(projectsPage.byStatusMenuItems, projectsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Assert.IsTrue(byStatusMenuChecks[i], $"By Status menu item {projectsPage.byStatusMenuTexts[i]} " +
                    $"should be {projectsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            ProjectsPage projectsPage = new ProjectsPage(driver);
            projectsPage.GoToTargetPage(projectsPage.pageUrl);
            bool[] roleMenuChecks = projectsPage.menuLinksTextsCheck(projectsPage.roleOfSlivenMunMenuItems, projectsPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {projectsPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {projectsPage.roleOfSlivenMunMenuTexts[i]}, but is not");
            }
        }
    }
}
