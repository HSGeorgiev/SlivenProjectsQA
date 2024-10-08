﻿using SlivenProjectsTests.Pages;

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
            bool[] inRegisterMenuChecks = structuralFundsPage.menuLinksTextsCheck(structuralFundsPage.inRegisterMenuItems, structuralFundsPage.inRegisterMenuTexts);

            for (int i = 0; i < inRegisterMenuChecks.Length; i++)
            {
                Assert.IsTrue(inRegisterMenuChecks[i], $"InRegister menu item {structuralFundsPage.inRegisterMenuTexts[i]} " +
                    $"should be {structuralFundsPage.inRegisterMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByStatus_LinksTexts_ShouldBeProper()
        {
            var structuralFundsPage = new StructuralFundsPage(driver);
            structuralFundsPage.GoToTargetPage(structuralFundsPage.pageUrl);
            bool[] byStatusMenuChecks = structuralFundsPage.menuLinksTextsCheck(structuralFundsPage.byStatusMenuItems, structuralFundsPage.byStatusMenuTexts);

            for (int i = 0; i < byStatusMenuChecks.Length; i++)
            {
                Console.WriteLine(byStatusMenuChecks[i]);
                Console.WriteLine(structuralFundsPage.byStatusMenuTexts[i]);

                Assert.IsTrue(byStatusMenuChecks[i], $"ByProjects Status menu item {structuralFundsPage.byStatusMenuTexts[i]} " +
                    $"should be {structuralFundsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void RoleOfSliven_LinksTexts_ShouldBeProper()
        {
            var structuralFundsPage = new StructuralFundsPage(driver);
            structuralFundsPage.GoToTargetPage(structuralFundsPage.pageUrl);
            bool[] roleMenuChecks = structuralFundsPage.menuLinksTextsCheck(structuralFundsPage.roleOfSlivenMunMenuItems, structuralFundsPage.roleOfSlivenMunMenuTexts);

            for (int i = 0; i < roleMenuChecks.Length; i++)
            {
                Assert.IsTrue(roleMenuChecks[i], $"By Role Of Sliven menu item {structuralFundsPage.roleOfSlivenMunMenuTexts[i]} " +
                    $"should be {structuralFundsPage.byStatusMenuTexts[i]}, but is not");
            }
        }

        [Test]
        public void ByYearsMenu_LinksTexts_ShouldBeProper()
        {
            var structuralFundsPage = new StructuralFundsPage(driver);
            structuralFundsPage.GoToTargetPage(structuralFundsPage.pageUrl);
            bool[] yearsMenuChecks = structuralFundsPage.menuLinksTextsCheck(structuralFundsPage.yearsMenuItems, structuralFundsPage.yearsMenuTexts);

            for (int i = 0; i < yearsMenuChecks.Length; i++)
            {
                Console.WriteLine(yearsMenuChecks[i]);
                Console.WriteLine(structuralFundsPage.yearsMenuTexts[i]);
                Assert.IsTrue(yearsMenuChecks[i], $"By year menu item {structuralFundsPage.yearsMenuTexts[i]} " +
                    $"should be {structuralFundsPage.yearsMenuTexts[i]}, but is not");
            }
        }

    }
}
