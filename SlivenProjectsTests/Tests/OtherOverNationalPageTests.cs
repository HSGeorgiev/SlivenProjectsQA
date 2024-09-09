using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    }
}
