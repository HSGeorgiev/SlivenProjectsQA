using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class NationalProgrammsPageTests : BaseTests
    {

        [Test]
        public void FooterTextShouldBeCorect()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(BASE_URL);
            string currentYear = DateTime.Now.Year.ToString();
            string footerTextActual = nationalProgrammsPage.GetText(nationalProgrammsPage.footerText);
            string footerTextExpected = $"Община Сливен, (с) 2008 - {currentYear}";
            //Console.WriteLine(footerTextActual);
            //Console.WriteLine(footerTextExpected);
            Assert.IsTrue(footerTextActual == footerTextExpected, "Footer text should be correct");
        }



        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] topMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.topMenuItems, nationalProgrammsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {nationalProgrammsPage.topMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] inRegisterMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.inRegisterMenuItems, nationalProgrammsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {nationalProgrammsPage.inRegisterMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] byStatusMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.byStatusMenuItems, nationalProgrammsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {

                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {nationalProgrammsPage.byStatusMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] roleMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.roleOfSlivenMunMenuItems, nationalProgrammsPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {nationalProgrammsPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            NationalProgrammsPage nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] yearsMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.yearsMenuItems, nationalProgrammsPage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {

                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {nationalProgrammsPage.yearsMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.yearsMenuTexts[i]}, but is not");
            }
        }




    }
}
