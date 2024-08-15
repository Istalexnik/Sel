using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System.Windows;
using Sel.Enums;

namespace Sel
{
    public static class SeleniumHelper
    {
        private static IWebDriver? driver;

        public static void RunSeleniumTest(string url, List<PageType> pausePages)
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }

            var edgeDriverService = EdgeDriverService.CreateDefaultService();
            edgeDriverService.HideCommandPromptWindow = true;

            driver = new EdgeDriver(edgeDriverService, new EdgeOptions());
            driver.Navigate().GoToUrl(url);

            foreach (var page in pausePages)
            {
                PauseOnPage(page);
            }

            // Continue with the rest of your test logic...
        }

        private static void PauseOnPage(PageType page)
        {
            // Implement logic to navigate to the specific page if necessary
            // For simplicity, assume the page is already loaded
            MessageBox.Show($"Paused on {page}. Make any changes you need and click OK to continue.", "Pause", MessageBoxButton.OK);
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}
