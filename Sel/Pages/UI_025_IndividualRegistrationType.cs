using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_025_IndividualRegistrationType 
    {
        By lnkRegistration = By.Id("ctl00_Main_content_lnkCompleteHeader");

        public UI_025_IndividualRegistrationType()
        {
            if (!lnkRegistration.FindIt()) { return; }

            lnkRegistration.JSClick();
        }
    }
}
