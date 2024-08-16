using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_210_ImportantAgreement
    {
        By rbIWantToFileThisClaimYes = By.Id("ctl00_Main_content_Wizard1_rblAcceptTerms_0");
        By chkICertify = By.CssSelector("label[for='ctl00_Main_content_Wizard1_chkSelfCertification']");

        By btnNext = By.Id("ctl00_Main_content_Wizard1_StartNavigationTemplateContainerID_StartNextButton");
        public UI_210_ImportantAgreement()
        {
            Thread.Sleep(200);

            chkICertify.IsPresent()?.Click();
            rbIWantToFileThisClaimYes.Click();

            btnNext.Click();
        }
    }
}
