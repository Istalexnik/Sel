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
    public class UI_110_EmploymentMiscellaneous
    {
        By rbAttendingTrainingNo = By.Id("ctl00_Main_content_ucUIEmploymentStatus_rblAttendingTraining_1");
        
        By rbComissionBasisNo = By.CssSelector("label[for='ctl00_Main_content_ucUIEmploymentStatus_rblCommissionBasis_1']");
        
        By rbRefusedJobNo = By.CssSelector("label[for='ctl00_Main_content_ucUIEmploymentStatus_rblRefusedAJobOffer_1']");
        
        By rbRefusedReferralNo = By.CssSelector("label[for='ctl00_Main_content_ucUIEmploymentStatus_rblRefusedAReferralToWork_1']");
                
        By rbResultOfTradeNo = By.Id("ctl00_Main_content_ucUIEmploymentStatus_rblCertifiedTrade_1");

        By rbProfessionalAthleteNo = By.Id("ctl00_Main_content_ucUIEmploymentStatus_rblWorkedAsProfessionalAthlete_1");

        By rbHeadStartNo = By.CssSelector("label[for='ctl00_Main_content_ucUIEmploymentStatus_rblEmployedBySchool_1']");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_110_EmploymentMiscellaneous()
        {
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!)) return;

            if (!rbAttendingTrainingNo.FindIt()) return; 

            rbAttendingTrainingNo.Click();

            rbComissionBasisNo.Click();

            rbRefusedJobNo.Click();

            rbRefusedReferralNo.Click();

            rbResultOfTradeNo.Click();

            rbProfessionalAthleteNo.Click();

            rbHeadStartNo.Click();

            btnNext.Click();
        }
    }
}
