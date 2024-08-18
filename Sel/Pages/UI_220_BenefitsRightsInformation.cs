using OpenQA.Selenium;
using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_220_BenefitsRightsInformation
    {
                                 

        By rbIWantToPrintLater = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblBRIPrintView_1']");

        By btnNext = By.Id("ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton");

        public UI_220_BenefitsRightsInformation()
        {
       
        if (!rbIWantToPrintLater.FindIt()) return;

            rbIWantToPrintLater.Click();

            btnNext.Click();
        }
    }
}
