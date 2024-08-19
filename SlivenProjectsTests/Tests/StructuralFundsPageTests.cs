using SlivenProjectsTests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlivenProjectsTests.Tests
{
    internal class StructuralFundsPageTests : BaseTests
    {

        

        [Test]
        public void TopMenu_LinksTexts_ShouldBeProper()
        {
            var structuralFundsPage = new StructuralFundsPage(driver);
            structuralFundsPage.GoToTargetPage(structuralFundsPage.pageUrl);
            bool[] topMenuChecks = structuralFundsPage.menuLinksTextsCheck(structuralFundsPage.topMenuItems, structuralFundsPage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"Top menu item {structuralFundsPage.topMenuTexts[i]} " +
                    $"should be {structuralFundsPage.topMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void InRegisterMenu_LinksTexts_ShouldBeProper()
        {
            var structuralFundsPage = new StructuralFundsPage(driver);
            structuralFundsPage.GoToTargetPage(structuralFundsPage.pageUrl);
            bool[] topMenuChecks = structuralFundsPage.menuLinksTextsCheck(structuralFundsPage.inRegisterMenuItems, structuralFundsPage.inRegisterMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"InRegister menu item {structuralFundsPage.inRegisterMenuTexts[i]} " +
                    $"should be {structuralFundsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

    }
}
