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

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(completedProjectsPage.pageUrl);
            bool[] inRegisterMenuChecks = completedProjectsPage.menuLinksTextsCheck(completedProjectsPage.inRegisterMenuItems, completedProjectsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {completedProjectsPage.inRegisterMenuTexts[i]} " +
                    $"should be {completedProjectsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            CompletedProjectsPage completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(completedProjectsPage.pageUrl);
            bool[] byStatusMenuChecks = completedProjectsPage.menuLinksTextsCheck(completedProjectsPage.byStatusMenuItems, completedProjectsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Console.WriteLine(byStatusMenuChecks[i]);
                Console.WriteLine(completedProjectsPage.byStatusMenuTexts[i]);

                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {completedProjectsPage.byStatusMenuTexts[i]} " +
                    $"should be {completedProjectsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            CompletedProjectsPage completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(completedProjectsPage.pageUrl);
            bool[] roleMenuChecks = completedProjectsPage.menuLinksTextsCheck(completedProjectsPage.roleOfSlivenMunMenuItems, completedProjectsPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {completedProjectsPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {completedProjectsPage.byStatusMenuTexts[i]}, but is not");
            }
        }
    }
}
