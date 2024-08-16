using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Data;
using static Sel.SeleniumExtensions;
using System.Threading;

namespace Sel.Pages
{
    public class UI_215_AcknowledgmentPage
    {
        By txtName = By.Id("ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignName");
       By txtDate = By.Id("ctl00_Main_content_Wizard1_ucAcknowledgements_txtBRISignDate");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");
        By btnNext2 = By.Id("ctl00_Main_content_Wizard1_FinishNavigationTemplateContainerID_FinishCompleteButton");
        
        public UI_215_AcknowledgmentPage()
        {
            ClickAllCheckBoxes();
            txtName.IsPresent()?.SendKeys($"{TestData.FirstName} {TestData.LastName}");
            txtDate.IsPresent()?.SendKeys(DateTime.Today.AddDays(-1).ToString("MM/dd/yyyy"));

            if (new[] { "PA", "PR", "LA" }.Any(site => TestData.Site.Contains(site)))
            {
                btnNext2.Click();
            }
            else
            {

                    btnNext.Click();

            }

        }
    }
}
