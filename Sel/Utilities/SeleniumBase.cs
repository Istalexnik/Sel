using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Sel.Utilities
{
    public static class SeleniumBase
    {
        public static IWebDriver? driver;

        public static void RunSeleniumTest(string url)
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }

            var edgeOptions = new EdgeOptions();
            edgeOptions.AddArguments(new List<string>
            {
               "no-sandbox",
               "--start-maximized",
               "--no-first-run",
               "--no-default-browser-check",
               "--disable-infobars",
               "--guest",
               "--disable-sync",
               "--disable-features=EdgeSidebar,msEdgeWelcomePage,msEdgeTabsWelcomePage,EdgeSpotlight,EdgeStartupBoost,AutofillServerCommunication,PasswordManagerOnboarding,PasswordManagerReauthentication",
               "--disable-background-networking",
               "--disable-extensions",
               "--disable-default-apps"
            });
            edgeOptions.AddExcludedArgument("enable-automation");
            edgeOptions.AcceptInsecureCertificates = true;


            var edgeDriverService = EdgeDriverService.CreateDefaultService();
            edgeDriverService.HideCommandPromptWindow = true;

            using (driver = new EdgeDriver(edgeDriverService, edgeOptions))
            {
                driver.Navigate().GoToUrl(url);

                ClaimCreation claimCreation = new ClaimCreation();
                claimCreation.CreateClaim();


                //QuitDriver();
            }
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
                driver.Dispose();
                driver = null;
            }

        }
    }
}
