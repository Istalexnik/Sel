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
    public class UI_145_UnemploymentCompensation
    {
        By btnNext = By.Id("ctl00_Main_content_btnRegistrationCompleteUIEmploymentHistory");
        public UI_145_UnemploymentCompensation()
        {
            if (new[] { "PFL" }.Any(site => TestData.StateAbbreviation!.Contains(site))) return;

            btnNext.Click();
        }
    }
}
