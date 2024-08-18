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
    class UI_193_YourEmploymentHistoryAfterFirst
    {
        By titleYourEmploymentHistory = By.XPath("(//h2[text()='Your Employment History'])");

        By rbDidYouWorkForYes = By.CssSelector("label[for='ctl00_Main_content_rblBasePeriodEmployerConfirm_0']");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_193_YourEmploymentHistoryAfterFirst()
        {
            if (!titleYourEmploymentHistory.FindIt()) return;

            rbDidYouWorkForYes.Click();

            btnNext.Click();

            new UI_190_EmployerPage(TestData.Employer2!, TestData.WorkBeginDate2, TestData.WorkEndDate2);
        }
    }
}
