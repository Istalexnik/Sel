using Sel.Data;
using Sel.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_040_SocialSecurityPage 
    {
        By txtSSN = By.CssSelector("input[id$=txtSSN]");
        By txtSSNReenter = By.CssSelector("input[id$=txtSSNReenter]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");      

        public UI_040_SocialSecurityPage()
        {
            txtSSN.SendKeys(TestData.SSN);
            Thread.Sleep(100);
            txtSSNReenter.SendKeys(TestData.SSN);

            btnNext.Click();

        }
    }
}
