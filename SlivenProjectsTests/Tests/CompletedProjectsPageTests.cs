using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class CompletedProjectsPageTests : BaseTests
    {
        [Test]
        public void FooterTextShouldBeCorect()
        {
            var completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = completedProjectsPage.GetText(completedProjectsPage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }

        [Test]
        public void HeadingTextShouldBeCorect()
        {
            var completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(BASE_URL);

            string headingTextActual = completedProjectsPage.GetText(completedProjectsPage.pageHeading);
            string headingTextExpected = "Регистър за проекти - Община Сливен";
            //Console.WriteLine(headingTextActual);
            //Console.WriteLine(headingTextExpected);
            Assert.IsTrue(headingTextActual == headingTextExpected, "Footer text should be correct");
        }

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

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            var completedProjectsPage = new CompletedProjectsPage(driver);
            completedProjectsPage.GoToTargetPage(completedProjectsPage.pageUrl);
            bool[] yearsMenuChecks = completedProjectsPage.menuLinksTextsCheck(completedProjectsPage.yearsMenuItems, completedProjectsPage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {
                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {completedProjectsPage.yearsMenuTexts[i]} " +
                    $"should be {completedProjectsPage.yearsMenuTexts[i]}, but is not");
            }
        }
    }
}
