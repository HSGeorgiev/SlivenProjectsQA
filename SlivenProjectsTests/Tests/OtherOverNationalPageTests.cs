using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class OtherOverNationalPageTests : BaseTests
    {
        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var otherOverNationalPage = new OtherOverNationalPage(driver);
            otherOverNationalPage.GoToTargetPage(otherOverNationalPage.pageUrl);
            bool[] topMenuChecks = otherOverNationalPage.menuLinksTextsCheck(otherOverNationalPage.topMenuItems, otherOverNationalPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {otherOverNationalPage.topMenuTexts[i]} " +
                    $"should be {otherOverNationalPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            OtherOverNationalPage otherOverNationalPage = new OtherOverNationalPage(driver);
            otherOverNationalPage.GoToTargetPage(otherOverNationalPage.pageUrl);
            bool[] inRegisterMenuChecks = otherOverNationalPage.menuLinksTextsCheck(otherOverNationalPage.inRegisterMenuItems, otherOverNationalPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {otherOverNationalPage.inRegisterMenuTexts[i]} " +
                    $"should be {otherOverNationalPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var otherOverNationalPage = new OtherOverNationalPage(driver);
            otherOverNationalPage.GoToTargetPage(otherOverNationalPage.pageUrl);
            bool[] byStatusMenuChecks = otherOverNationalPage.menuLinksTextsCheck(otherOverNationalPage.byStatusMenuItems, otherOverNationalPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {otherOverNationalPage.byStatusMenuTexts[i]} " +
                    $"should be {otherOverNationalPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            var otherOverNationalPage = new OtherOverNationalPage(driver);
            otherOverNationalPage.GoToTargetPage(otherOverNationalPage.pageUrl);
            bool[] roleMenuChecks = otherOverNationalPage.menuLinksTextsCheck(otherOverNationalPage.roleOfSlivenMunMenuItems, otherOverNationalPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {otherOverNationalPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {otherOverNationalPage.byStatusMenuTexts[i]}, but is not");

            }

        }

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            OtherOverNationalPage otherOverNationalPage = new OtherOverNationalPage(driver);
            otherOverNationalPage.GoToTargetPage(otherOverNationalPage.pageUrl);
            bool[] yearsMenuChecks = otherOverNationalPage.menuLinksTextsCheck(otherOverNationalPage.yearsMenuItems, otherOverNationalPage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {

                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {otherOverNationalPage.yearsMenuTexts[i]} " +
                    $"should be {otherOverNationalPage.yearsMenuTexts[i]}, but is not");
            }
        }
    }

}
