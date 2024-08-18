using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Utilities;

namespace Sel.Pages
{
    public class UI_035_WelcomePage
    {
        By btnNext = By.CssSelector("input[id$=StartNextButton]");
        By btnLogOut = By.CssSelector("input[id$=hlNotRegistered2]");
        By btnHome = By.CssSelector("input[id$=ctl00_Main_content_Button2]");


        public UI_035_WelcomePage()
        {
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!)) return;


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
