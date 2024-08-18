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
    public class UI_180_EmploymentHistoryBeforeFirst
    {
        By titlePartiallyCompletedEmploymentHistory = By.XPath("(//h2[text()='Partially Completed Employment History'])");

        By titlePreviousEmploymentHistory = By.XPath("(//h2[text()='Previous Employment History'])");

        By titleYourEmploymentHistory = By.XPath("(//h2[text()='Your Employment History'])");


        By rbAddEmployerYes = By.Id("ctl00_Main_content_rblAddAnotherEntry_0");
        By rbAddEmployerNo = By.Id("ctl00_Main_content_rblAddAnotherEntry_1");

        By rbDidYouWorkForYes = By.CssSelector("label[for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        By linkEdit = By.Id("ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_lnkEditAction");

        By linkSelect = By.Id("ctl00_Main_content_grdBasePeriodEmployerConfirm_ctl02_lbSelect");

        public UI_180_EmploymentHistoryBeforeFirst()
        {
            if (TestData.Type.Contains(7))
            {
                rbAddEmployerNo.Click();
            }
            else if (TestData.Type.Contains(2) || TestData.Type.Contains(3))
            {
                if (!titlePartiallyCompletedEmploymentHistory.FindIt())
                {
                    linkEdit.Click();
                    return;
                }
            }
            else if (titlePreviousEmploymentHistory.FindIt())
            {
                linkSelect.Click();
                rbDidYouWorkForYes.Click();
            }
            else if (titleYourEmploymentHistory.FindIt())
            {
                rbDidYouWorkForYes.Click();
            }
            else 
            {
                rbAddEmployerYes.Click();
            }

            btnNext.Click();


        }
    }
}
