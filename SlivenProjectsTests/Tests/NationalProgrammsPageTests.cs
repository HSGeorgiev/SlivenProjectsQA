using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class NationalProgrammsPageTests : BaseTests
    {
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
        public void byStatus_LinksTexts_ShouldBeProper()
        {
            var nationalProgrammsPage = new NationalProgrammsPage(driver);
            nationalProgrammsPage.GoToTargetPage(nationalProgrammsPage.pageUrl);
            bool[] byStatusMenuChecks = nationalProgrammsPage.menuLinksTextsCheck(nationalProgrammsPage.byStatusMenuItems, nationalProgrammsPage.byStatusMenuTexts);
            Console.WriteLine(byStatusMenuChecks.Length);
            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Console.WriteLine(byStatusMenuChecks[i]);
                Console.WriteLine(nationalProgrammsPage.byStatusMenuTexts[i]);

                Assert.IsTrue(byStatusMenuChecks[i], $"InRegister menu item {nationalProgrammsPage.byStatusMenuTexts[i]} " +
                    $"should be {nationalProgrammsPage.byStatusMenuTexts[i]}, but is not");
            }
        }




    }
}
