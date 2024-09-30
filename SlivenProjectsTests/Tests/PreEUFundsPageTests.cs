using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class PreEUFundsPageTests  : BaseTests
    {

        [Test]
        public void FooterTextShouldBeCorect()
        {
            PreEUFundsPage preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = preEUFundsPage.GetText(preEUFundsPage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }

        [Test]
        public void HeadingTextShouldBeCorect()
        {
            PreEUFundsPage preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(BASE_URL);

            string headingTextActual = preEUFundsPage.GetText(preEUFundsPage.pageHeading);
            string headingTextExpected = "Регистър за проекти - Община Сливен";
            //Console.WriteLine(headingTextActual);
            //Console.WriteLine(headingTextExpected);
            Assert.IsTrue(headingTextActual == headingTextExpected, "Footer text should be correct");
        }



        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] topMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.topMenuItems, preEUFundsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {preEUFundsPage.topMenuTexts[i]} " +
                    $"should be {preEUFundsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] inRegisterMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.inRegisterMenuItems, preEUFundsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {preEUFundsPage.inRegisterMenuTexts[i]} " +
                    $"should be {preEUFundsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] byStatusMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.byStatusMenuItems, preEUFundsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {


                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {preEUFundsPage.byStatusMenuTexts[i]} " +
                    $"should be {preEUFundsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            var preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] roleMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.roleOfSlivenMunMenuItems, preEUFundsPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {preEUFundsPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {preEUFundsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            PreEUFundsPage preEUFundsPage = new PreEUFundsPage(driver);
            preEUFundsPage.GoToTargetPage(preEUFundsPage.pageUrl);
            bool[] yearsMenuChecks = preEUFundsPage.menuLinksTextsCheck(preEUFundsPage.yearsMenuItems, preEUFundsPage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {

                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {preEUFundsPage.yearsMenuTexts[i]} " +
                    $"should be {preEUFundsPage.yearsMenuTexts[i]}, but is not");
            }
        }

    }
}
