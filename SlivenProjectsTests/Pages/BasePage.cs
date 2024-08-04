using OpenQA.Selenium;
using SlivenProjectsTests.Globals;
using SlivenProjectsTests.Helpers;

namespace SlivenProjectsTests.Pages
{
    public class BasePage : DriverHelper
    {
        public string SubUrl { get; set; }
 
        public BasePage(IWebDriver driver) : base(driver)
        {

        }

        // Go to current page

        public void GoToCurrentPage()
        {
            driver.Navigate().GoToUrl(GlobalConstants.BASE_URL + SubUrl);
        }

        // all six top-menu links
        protected readonly By topMenuItems = By.CssSelector(".art-hmenu li a");

        // texts on the all six top-menu links/tabs
        string[] topMenuTexts = { "Начало", "Структурни фондове на ЕС", "Други инструменти на ЕС",
            "Предприсъединителни инструменти", "Национални програми", "Търсене" };


        public bool[] menuLinksTextsCheck(By by, string[] texts)

        // by => an By class menu element description - need to be a menu element
        // texts => an array of strings, containing menu's items' texts.
        // The number of the strings in texts[] should be equal to number of menu items
        // return array of bools, true if the element's text is equal to
        // the corresponding string in the argument array, else otherwise.
        // If number of elements doesn't fit length of texts array, fail the assert with message.
        
        {
            bool[]? results = null; ;
            string[]? menuElementsTexts = GetElementsTextArray(by);

            if (menuElementsTexts.Length == texts.Length)
            {
                for (int i = 0; i < texts.Length; i += 1)
                {
                    if (menuElementsTexts[i] == texts[i])
                    {
                        results[i] = true;
                    }
                    else
                    {
                        results[i] = false;
                    }
                }
            }
            else
            {
                Assert.Fail($"The number of top-menu items doesn't fit. " +
                    $"Must be {texts.Length}, but is {menuElementsTexts.Length}");
            }

            return results;
        }

    }
}
