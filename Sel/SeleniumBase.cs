using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Windows;
using Sel.Enums;

namespace Sel
{
    public static class SeleniumBase
    {
        public static IWebDriver? driver;

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

            ClaimCreation claimCreation = new ClaimCreation();
            claimCreation.CreateClaim();

            foreach (var page in pausePages)
            {
                PauseOnPage(page);
            }

            //QuitDriver();
        }

        private static void PauseOnPage(PageType page)
        {
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
