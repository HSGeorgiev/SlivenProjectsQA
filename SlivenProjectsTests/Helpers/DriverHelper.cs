using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using SlivenProjectsTests.Globals;

namespace SlivenProjectsTests.Helpers
{
    public class DriverHelper
    {
        protected readonly IWebDriver driver;
        protected readonly WebDriverWait wait;

        public DriverHelper(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(GlobalConstants.DEFAULT_TIMEOUT));
        }

        public IWebElement FindElement(By by)

        // We pass a By class selector as argument here.
        // Returns an single element IWebElement or throw an exception
        // Would return an IWebElement if By argument is a valid selector.
        // Would throw an exception if By argument is not a valid selector.
        // Would throw an exception if element is not found within timeout, defined in GlobalConstants class.
        // If By selector points more than one element on the page, the first element will be returned.

        {
            IWebElement? element = null;

            try
            {
                wait.Until(ExpectedConditions.ElementIsVisible(by));
                element = driver.FindElement(by);
            }
            catch (WebDriverTimeoutException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Element, described as| {by} | not found " +
                    $"after timeout, set on {GlobalConstants.DEFAULT_TIMEOUT} seconds.\n" +
                    $"WebDriver says: {e.Message}");
            }
            catch (InvalidSelectorException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: The argument  | {by} | is not a valid selector here!" +
                    $"WebDriver says: {e.Message}");
            }

            catch (ElementNotVisibleException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Requested element | {by} | is present but is not visible!" +
                    $"WebDriver says: {e.Message}");
            }

            catch (Exception e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Exception thrown when trying to find element | {by} |!" +
                    $"An exception, not handled in SlivenProjectsTests.Helpers.DriverHelper class." +
                    $"WebDriver says: {e.Message}");
            }

            return element;

        }

        protected IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            // We pass a By class selector as argument here.
            // Returns an collection of web elements IWebElement or throw an exception
            // Would return an IReadOnlyCollection if By argument is a valid selector.
            // Would throw an exception if By argument is not a valid selector.
            // Would throw an exception if element/elements is/are not found within timeout, defined in GlobalConstants class.

            IReadOnlyCollection<IWebElement>? elements = null;

            try
            {
                wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(by));
                elements = driver.FindElements(by);
            }
            catch (WebDriverTimeoutException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Some of elements, described as | {by} | not found " +
                    $"after timeout, set on {GlobalConstants.DEFAULT_TIMEOUT} seconds.\n" +
                    $"WebDriver says: {e.Message}");
            }
            catch (InvalidSelectorException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: The argument  | {by} | is not a valid selector here!" +
                    $"WebDriver says: {e.Message}");
            }

            catch (ElementNotVisibleException e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Somme of requested elements | {by} | is/are present but is/are not visible!" +
                    $"WebDriver says: {e.Message}");
            }

            catch (Exception e)
            {
                Assert.Fail($"SLIVEN_PROJECTS_TESTS_ERROR: Exception thrown when trying to find element | {by} |!" +
                    $"An exception, not handled in SlivenProjectsTests.Helpers.DriverHelper class." +
                    $"WebDriver says: {e.Message}");
            }

            return elements;

        }

        protected void click(By by)
        {
            // We wrap the standard click method here, using our custom FindElement method
            FindElement(by).Click();
        }

        protected void SendKeys(By by, string text)
        {
            // We wrap the standard SendKeys method here, using our custom FindElement method
            // we also clear the element first

            IWebElement element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected string GetText(By by)
        {
            return FindElement(by).Text;
        }

        protected string[] GetElementsTextArray(By by)
        {
            IReadOnlyCollection<IWebElement> elements = FindElements(by);
            IWebElement[] webElementsArrauy = elements.ToArray();
            string[] textArray = new string[elements.Count];
            for (int i = 0; i < elements.Count; i++)
            {
                textArray[i] = webElementsArrauy[i].Text;
            }
            return textArray;
        }

        protected IWebElement[] GetWebElementsArray(By by)
        {
            IReadOnlyCollection<IWebElement> elements = FindElements(by);
            return elements.ToArray();
        }

        public string GetCurrentUrl(IWebDriver driver)
        {
            return driver.Url;
        }

        public string GetCurrentPageTitle(IWebDriver driver)
        {
            return driver.Title;
        }
    }
}
