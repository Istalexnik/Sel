using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_035_WelcomePage
    {
        By titleWelcome = By.XPath("(//h2[text()='Welcome to DC Networks'])");

        By btnNext = By.Id("ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton");

        By btnLogOut = By.Id("ctl00_hlNotRegistered2");
        By btnHome = By.Id("ctl00_Main_content_Button2");


        public UI_035_WelcomePage()
        {
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }


            //PA workaround  when the user is not logged out
            try
            {
                btnNext.Click();
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                btnLogOut.Click();
                btnHome.Click();

                new UI_005_HomePage();
            }

        }
    }
}
