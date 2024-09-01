using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class OtherEUFundsPgeTests : BaseTests
    {
        

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] topMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.topMenuItems, otherEUFundsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {otherEUFundsPage.topMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var otherEUFundsPage = new OtherEUInstrumentsPage(driver);
            otherEUFundsPage.GoToTargetPage(otherEUFundsPage.pageUrl);
            bool[] inRegisterMenuChecks = otherEUFundsPage.menuLinksTextsCheck(otherEUFundsPage.inRegisterMenuItems, otherEUFundsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {otherEUFundsPage.inRegisterMenuTexts[i]} " +
                    $"should be {otherEUFundsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }
    }
}
