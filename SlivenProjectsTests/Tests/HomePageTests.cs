using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class HomePageTests : BaseTests
    {

        [Test]
        public void FooterTextShouldBeCorect()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = homePage.GetText(homePage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }

        [Test]
        public void HeadingTextShouldBeCorect()
        {
            var homePage = new HomePage(driver);
            homePage.GoToTargetPage(BASE_URL);

            string headingTextActual = homePage.GetText(homePage.pageHeading);
            string headingTextExpected = "Регистър за проекти - Община Сливен";
            //Console.WriteLine(headingTextActual);
            //Console.WriteLine(headingTextExpected);
            Assert.IsTrue(headingTextActual == headingTextExpected, "Footer text should be correct");
        }



        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] topMenuChecks = homePage.menuLinksTextsCheck(homePage.topMenuItems, homePage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {homePage.topMenuTexts[i]} " +
                    $"should be {homePage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] inRegisterMenuChecks = homePage.menuLinksTextsCheck(homePage.inRegisterMenuItems, homePage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {homePage.inRegisterMenuTexts[i]} " +
                    $"should be {homePage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] byStatusMenuChecks = homePage.menuLinksTextsCheck(homePage.byStatusMenuItems, homePage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Assert.IsTrue(byStatusMenuChecks[i], $"By Status menu item {homePage.byStatusMenuTexts[i]} " +
                    $"should be {homePage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] roleMenuChecks = homePage.menuLinksTextsCheck(homePage.roleOfSlivenMunMenuItems, homePage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {homePage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {homePage.roleOfSlivenMunMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToTargetPage(homePage.pageUrl);
            bool[] yearsMenuChecks = homePage.menuLinksTextsCheck(homePage.yearsMenuItems, homePage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {
              
                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {homePage.yearsMenuTexts[i]} " +
                    $"should be {homePage.yearsMenuTexts[i]}, but is not");
            }
        }
    }
}
