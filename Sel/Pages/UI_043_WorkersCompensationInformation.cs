using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_043_WorkersCompensationInformation
    {
        By rbReceivedWorkCompNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucWorkersCompensation_rblWCReceived_1']");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        public UI_043_WorkersCompensationInformation()
        {
            if (!rbReceivedWorkCompNo.FindIt()) { return; }

            rbReceivedWorkCompNo.Click();

            btnNext.Click();
        }
    }
}
