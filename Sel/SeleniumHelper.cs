using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace Sel
{
    public static class SeleniumHelper
    {
        public static void RunSeleniumTest(string url)
        {
            var edgeDriverService = EdgeDriverService.CreateDefaultService();
            edgeDriverService.HideCommandPromptWindow = true;  // Hides the console window

            using (var driver = new EdgeDriver(edgeDriverService, new EdgeOptions()))
            {
                driver.Navigate().GoToUrl(url);



            }
        }
    }
}
