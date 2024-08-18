using OpenQA.Selenium;
using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_025_IndividualRegistrationType 
    {
        By lnkRegistration = By.CssSelector("a[id$=lnkCompleteHeader]");

        public UI_025_IndividualRegistrationType()
        {
            if (!lnkRegistration.FindIt()) return;

            lnkRegistration.Click();
        }
    }
}
