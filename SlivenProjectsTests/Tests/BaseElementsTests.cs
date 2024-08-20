using SlivenProjectsTests.Pages;

namespace SlivenProjectsTests.Tests
{
    internal class BaseElementsTests : BaseTests
    {

        //TopMenu_LinksTexts_ShouldBeProper - Pages, accessible from the top menu
        [TestCase("Home","/")]
        [TestCase("Начало", "/index.php?option=com_sobi2&Itemid=87")]
        [TestCase("Структурни фондове на ЕС", "/index.php?option=com_sobi2&catid=9&Itemid=53")]
        [TestCase("Други инструменти на ЕС", "/index.php?option=com_sobi2&catid=8&Itemid=53")]
        [TestCase("Предприсъединителни фондове", "/index.php?option=com_sobi2&catid=7&Itemid=53")]
        [TestCase("Национални програми", "/index.php?option=com_sobi2&catid=6&Itemid=53")]
        [TestCase("Търсене", "/index.php?option=com_sobi2&sobi2Task=search&Itemid=53")]

        //TopMenu_LinksTexts_ShouldBeProper - Pages, accessible from the 'InTheRegister' menu
        [TestCase("Проекти", "/index.php?option=com_sobi2&Itemid=86")]
        [TestCase("Търсене в регистъра", "/index.php?option=com_sobi2&sobi2Task=search&Itemid=53")]
        [TestCase("Структурни фондове на Европейския съюз", "/index.php?option=com_sobi2&catid=9&Itemid=53")]
        [TestCase("Други инструменти на Европейския съюз", "/index.php?option=com_sobi2&catid=8&Itemid=53")]
        [TestCase("Предприсъединителни инструменти", "/index.php?option=com_sobi2&catid=7&Itemid=53")]
        [TestCase("Други наднационални инструменти", "/index.php?option=com_sobi2&catid=59&Itemid=53")]

        //TopMenu_LinksTexts_ShouldBeProper Pages, accessible from the 'By status' menu
        [TestCase("Приключили проекти", "/index.php?option=com_sobi2&catid=33&Itemid=53")]
        [TestCase("Текущи проекти", "/index.php?option=com_sobi2&catid=34&Itemid=53")]
        [TestCase("Очакващи одобрение и финансиране", "/index.php?option=com_sobi2&catid=35&Itemid=53")]

        //TopMenu_LinksTexts_ShouldBeProper Pages, accessible from the 'Leader/Partner' menu
        [TestCase("Водеща организация", "/index.php?option=com_sobi2&catid=39&Itemid=53")]
        [TestCase("Партньорска организация", "/index.php?option=com_sobi2&catid=40&Itemid=53")]




        public void TopMenu_LinksTexts_ShouldBeProper(string pageHeading, string subUrl)
        {
            BasePage basePage = new BasePage(driver);
            basePage.GoToTargetPage(BASE_URL + subUrl);
            bool[] topMenuChecks = basePage.menuLinksTextsCheck(basePage.topMenuItems, basePage.topMenuTexts);

            for (int i = 0; i < topMenuChecks.Length; i++)
            {
                Assert.IsTrue(topMenuChecks[i], $"On the page {pageHeading}  'Top menu' item {basePage.topMenuTexts[i]} " +
                    $"should be {basePage.topMenuTexts[i]}, but is not");
            }
        }

        // To check the test

        //[TestCase("Home", "")]
        //public void TopMenuLinks_Should_work_proper(string pageHeading, string subUrl)
        //{
        //    BasePage basePage = new BasePage(driver);
        //    basePage.GoToTargetPage(subUrl);
        //    bool[] topMenuTargetsCheck = basePage.menuLinksTargetsCheck(basePage.inRegisterMenuItems);
        //    for (int i = 0; i < topMenuTargetsCheck.Length; i++)
        //    {
        //        Assert.IsTrue(topMenuTargetsCheck[i], $"On the page {pageHeading}  'Top menu' item {basePage.topMenuTexts[i]} " +
        //            $"target wrong URL address");
        //    }
        //}

    }
}
