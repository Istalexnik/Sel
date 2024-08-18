using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.ObjectModel;
using Sel.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium.Internal;
using System.Diagnostics;

namespace Sel.Utilities
{
    public static class SeleniumExtensions
    {
        private static IWebDriver Driver => SeleniumBase.driver ?? throw new NullReferenceException("Driver is not initialized.");

        /// <summary>
        /// Default timeout value used when waiting for an element or condition.
        /// </summary>
        public static readonly int DefaultTimeoutInSeconds = 10;

        public static int GetTimeout()
        {
            // Example: Return a different timeout for a specific environment
            //if (Environment.GetEnvironmentVariable("Env") == "QA")
            //{
            //    return 15;
            //}
            return DefaultTimeoutInSeconds;
        }

        public static Dictionary<string, string> ErrorMessages = new Dictionary<string, string>
        {
            {"ElementNotFound", "Element with locator {0} was not found when attempting to {1}."}
             // add more as needed
        };

        /// <summary>
        /// Returns a WebDriverWait object configured with the provided timeout or the default timeout.
        /// </summary>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns a WebDriverWait object.</returns>
        public static WebDriverWait GetWait(int? waitTimeInSeconds = null)
        {
            return new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTimeInSeconds ?? GetTimeout()));
        }

        /// <summary>
        /// Waits for the element specified by the locator to be clickable.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns the locator of the element.</returns>
        public static By WaitForElementToBeClickable(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            IWebElement? element = null;
            try
            {
                wait.Until(d =>
                {
                    element = d.FindElement(locator);
                    return element.Displayed && element.Enabled;
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw new InvalidOperationException($"Element with locator {locator} was not clickable within the given wait time.");
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "WaitForElementToBeClickable()"));
            }

            return locator;
        }

        /// <summary>
        /// Waits for the element specified by the locator to be visible.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns the locator of the element.</returns>
        public static By WaitForElementToBeVisible(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);
            ReadOnlyCollection<IWebElement>? elements = null;
            try
            {
                wait.Until(d =>
                {
                    elements = d.FindElements(locator);
                    return elements.Count > 0 && elements[0].Displayed;
                });
            }
            catch (WebDriverTimeoutException)
            {
                throw new InvalidOperationException($"Element with locator {locator} was not visible within the given wait time.");
            }

            return locator;
        }

        /// <summary>
        /// Waits for the element specified by the locator to become stale and then waits for it to reappear.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="waitTimeInSeconds">Optional timeout in seconds. Uses default if not provided.</param>
        /// <returns>Returns the locator of the refound element.</returns>
        public static By WaitForElementToBeStaleAndRefind(this By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);

            IWebElement? originalElement = null;

            try
            {
                originalElement = Driver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                // If the element doesn't exist at the start, we'll just move on. 
            }

            // If we found the element originally, wait for it to become stale.
            if (originalElement != null)
            {
                wait.Until(driver =>
                {
                    try
                    {
                        // Attempting to access any property, like Displayed, will throw if the element is stale
                        bool dummy = originalElement.Displayed;
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        // This is what we want; the element is now stale!
                        return true;
                    }
                    catch (WebDriverTimeoutException)
                    {
                        // This is what we want; the element is now stale!
                        return true;
                    }
                });
            }

            // Wait for the element to appear again (re-finding it)
            wait.Until(driver => driver.FindElements(locator).Count > 0);

            return locator;
        }


        /// <summary>
        /// Waits for suggestions to appear within the identified element. The function supports waiting for suggestions 
        /// within both a dropdown (using option tags) and a div structure (using list items).
        /// </summary>
        /// <param name="locator">The By locator used to identify and locate the element (either a dropdown or div) containing suggestions on the webpage.</param>
        /// <param name="waitTimeInSeconds">Optional parameter specifying the maximum time to wait for suggestions to appear. Defaults to 10 seconds if not specified.</param>
        /// <returns>Returns the original locator of the element being checked for suggestions.</returns>
        public static By WaitForSuggestions(By locator, int? waitTimeInSeconds = null)
        {
            var wait = GetWait(waitTimeInSeconds);

            try
            {
                wait.Until(d =>
                {
                    try
                    {
                        // Attempt to locate the container element
                        IWebElement container = d.FindElement(locator);

                        // Check if the container is a <select> dropdown
                        if (container.TagName.ToLower() == "select")
                        {
                            var optionElements = container.FindElements(By.TagName("option"));
                            return optionElements.Count > 1; // More than one option means suggestions are present
                        }
                        // Check if the container is a div structure for suggestions
                        else if (container.GetAttribute("class").Contains("ac_results"))
                        {
                            var suggestionItems = container.FindElements(By.TagName("li"));
                            return suggestionItems.Count > 0; // Presence of list items means suggestions are present
                        }

                        return false; // Default to false if neither condition is met
                    }
                    catch (NoSuchElementException)
                    {
                        // If the element is not found, return false and wait until the condition is met
                        return false;
                    }
                    catch (StaleElementReferenceException)
                    {
                        // If the element becomes stale, return false and retry
                        return false;
                    }
                });
            }
            catch (WebDriverTimeoutException ex)
            {
                // Handle the timeout if the condition is not met within the wait period
                Debug.WriteLine($"Element not found or condition not met: {ex.Message}");
            }


            return locator;
        }



        //just wait
        public static By WaitFor(this By locator, int? waitTimeInMS = 500)
        {
            Thread.Sleep((int)waitTimeInMS!);
            return locator;
        }


        /// <summary>
        /// Clicks on the element specified by the locator using JavaScript.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        public static By JSClick(this By locator)
        {
            var js = (IJavaScriptExecutor)Driver;
            try
            {
                IWebElement element = Driver.FindElement(locator);
                js.ExecuteScript("arguments[0].click();", element);
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "JSClick()"));
            }
            catch (StaleElementReferenceException)
            {
                locator.WaitForElementToBeStaleAndRefind().JSClick();
            }
            return locator;
        }

        /// <summary>
        /// Clicks on the element specified by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        public static By Click(this By locator)
        {
            if (Driver.FindElements(locator).Count == 0) return locator;

            try
            {
                Driver.FindElement(locator).Click();
            }
            catch (StaleElementReferenceException)
            {
                locator.WaitForElementToBeStaleAndRefind().Click();
            }
            catch (ElementNotInteractableException)
            {
                locator.JSClick();
            }
            return locator;
        }


        /// <summary>
        /// Checks if an element specified by the provided locator is present in the DOM.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <returns>Returns the locator if the element is present, otherwise null.</returns>
        //public static By? IsPresent(this By locator)
        //{
        //    if (Driver.FindElements(locator).Count > 0)
        //    {
        //        return locator;
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        /// <summary>
        /// Checks if the element specified by the locator is present.
        public static bool FindIt(this By locator)
        {
            return Driver.FindElements(locator).Count > 0;
        }

        public static bool IsClickable(this By locator)
        {
            return Driver.FindElements(locator).Count > 0
                && Driver.FindElement(locator).Displayed
                && Driver.FindElement(locator).Enabled;
        }

        public static By? IsEnabled(this By locator)
        {
            if (Driver.FindElement(locator).Displayed
                && Driver.FindElement(locator).Enabled)
            {
                return locator;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Sends the specified text to the element determined by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <param name="text">The text to be sent to the element.</param>
        public static By SendKeys(this By locator, string? text)
        {
            try
            {
                IWebElement element = Driver.FindElement(locator);
                element.SendKeys(text);
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "SendKeys()"));
            }
            return locator;
        }


        /// <summary>
        /// Sends the specified text to an element within an iframe, if the iframe exists.
        /// </summary>
        /// <param name="locator">The By locator for the iframe element.</param>
        /// <param name="locatorIFrameElement">The By locator for the target element inside the iframe to which text will be sent.</param>
        /// <param name="text">The text to be sent to the target element.</param>
        public static void SendTextToIFrame(this By locator, By locatorIFrameElement, string text)
        {
            if (Driver.FindElements(locator).Count() > 0)
            {
                IWebElement iframe = Driver.FindElement(locator);
                Driver.SwitchTo().Frame(iframe);
                Driver.FindElement(locatorIFrameElement).SendKeys(text);
                Driver.SwitchTo().ParentFrame();
            }
        }


        /// <summary>
        /// Locates an element using the provided locator and sends the specified text to it. After a delay, simulates pressing the "arrow down" and "enter" keys on the element.
        /// </summary>
        /// <param name="locator">The By locator used to identify and locate the element on the webpage.</param>
        /// <param name="text">The text to be sent to the identified element.</param>
        /// <returns>Returns the original locator.</returns>
        public static By EnterText(this By locator, string? text, By suggesstionsLocator)
        {
            try
            {
                IWebElement element = Driver.FindElement(locator);
                Thread.Sleep(500);

                element.SendKeys(text + Keys.ArrowUp);

                WaitForSuggestions(suggesstionsLocator);

                element.SendKeys(Keys.ArrowDown + Keys.Enter);

            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "SendKeys()"));
            }
            catch (ElementNotInteractableException)
            {

            }
            return locator;
        }


        public static By EnterText2(this By locator, string? text, By suggesstionsLocator)
        {
            try
            {
                IWebElement element = Driver.FindElement(locator);
                Thread.Sleep(500);

                element.SendKeys(text + Keys.ArrowUp);

                Thread.Sleep(2500);

                element.SendKeys(Keys.ArrowDown + Keys.Enter);

            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "SendKeys()"));
            }
            catch (ElementNotInteractableException)
            {

            }
            return locator;
        }



        /// <summary>
        /// Retrieves the text of the element specified by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the element.</param>
        /// <returns>Returns the text of the element.</returns>
        public static string GetText(this By locator)
        {
            try
            {
                return Driver.FindElement(locator).GetAttribute("value");
            }
            catch (NoSuchElementException)
            {
                throw new NoSuchElementException(string.Format(ErrorMessages["ElementNotFound"], locator, "GetText()"));
            }
        }

        public static string Text(this By locator)
        {
            return Driver.FindElement(locator).Text;
        }

        public static By Clear(this By locator)
        {
            Driver.FindElement(locator).Clear();

            return locator;
        }

        /// <summary>
        /// Performs a click action on all visible elements matched by the specified locator, 
        /// repeating the action 5 times with a 300ms delay between each iteration.
        /// </summary>
        /// <param name="locator">The By locator for the elements to be clicked.</param>
        public static void LoopAndClickAllVisible(this By locator)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(300);
                locator.ClickAllVisible();
            }
        }





        /// <summary>
        /// Clicks on all visible elements specified by the locator.
        /// </summary>
        /// <param name="locator">The By locator for the elements.</param>
        public static By ClickAllVisible(this By locator)
        {
            var elements = Driver.FindElements(locator);
            foreach (var element in elements)
            {
                if (element.Displayed)
                {
                    try
                    {
                        if (!element.Selected)
                        {
                            element.Click();
                        }
                    }
                    catch (WebDriverTimeoutException)
                    {
                        throw new InvalidOperationException($"Element with locator {locator} was not refound within the given wait time.");
                    }
                }
            }
            return locator;
        }


        /// <summary>
        /// Iterates through all checkboxes on the current page and clicks on each one that is visible and not already checked.
        /// </summary>
        public static void ClickAllCheckBoxes()
        {
            var checkboxes = Driver.FindElements(By.CssSelector("input[type='checkbox']"));

            foreach (IWebElement checkbox in checkboxes)
            {
                var js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("arguments[0].click();", checkbox);
            }
        }


        /// <summary>
        /// Selects an option from a dropdown element based on visible text or partial text.
        /// </summary>
        /// <param name="locator">The By locator for the dropdown element.</param>
        /// <param name="text">The visible text or partial text of the option to be selected.</param>
        /// <param name="usePartialText">Optional. Indicates whether to use partial text for selection. Default is false.</param>
        /// <returns>Returns the original locator.</returns>
        /// <exception cref="NoSuchElementException">Thrown if the dropdown element specified by the locator is not found.</exception>
        /// <exception cref="WebDriverException">Thrown if there is an error in the WebDriver, such as if the option with the given text is not found in the dropdown.</exception>
        public static By SelectDropdownByText(this By locator, string text, bool usePartialText = false)
        {
            if (Driver.FindElements(locator).Count == 0) return locator;

            var dropdown = new SelectElement(Driver.FindElement(locator));

            if (usePartialText)
            {
                foreach (var option in dropdown.Options)
                {
                    if (option.Text.Contains(text))
                    {
                        option.Click();
                        break; // Exit the loop once the first match is found and selected
                    }
                }
            }
            else
            {
                dropdown.SelectByText(text);
            }

            return locator;
        }


        public static By SelectDropdownByIndex(this By locator, string index)
        {
            if (Driver.FindElements(locator).Count == 0) return locator;

            var dropdown = new SelectElement(Driver.FindElement(locator));
            dropdown.SelectByIndex(int.Parse(index));
            return locator;
        }

        public static By SelectDropdownByValue(this By locator, string? value)
        {
            if (Driver.FindElements(locator).Count == 0) return locator;

            var dropdown = new SelectElement(Driver.FindElement(locator));
            dropdown.SelectByValue(value);
            return locator;
        }

        public static By KeepSameWindow(this By locator)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].setAttribute('target', '_self');", Driver.FindElement(locator));
            return locator;
        }

        public static By OpenAndCloseWindow(this By locator)
        {
            string originalWindowHandle = Driver.CurrentWindowHandle;

            locator.SwitchWindow();

            Driver.Close();
            Driver.SwitchTo().Window(originalWindowHandle);
            return locator;


        }

        public static By SwitchWindow(this By locator)
        {
            string originalWindowHandle = Driver.CurrentWindowHandle;

            foreach (string handle in Driver.WindowHandles)
            {
                if (handle != originalWindowHandle)
                {
                    Driver.SwitchTo().Window(handle);
                    break;
                }
            }
            return locator;
        }

    }
}
