using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_060_MilitaryService
    {
        By rbMilitaryServiceNo = By.CssSelector("label[for$=rblMilitaryService_1]");
        By rbMilitaryServiceYes = By.CssSelector("label[for$=rblMilitaryService_0]");
        By ddWherePhysicallyLocated = By.CssSelector("select[id$=ctl00_Main_content_Wizard1_ddlPhysicalLocation]");
        By btnOk = By.CssSelector("input[id$=btn-dialog-ok]");
        By rbLocatedInHostStateYes = By.CssSelector("label[for$=rblPhysicallyInState_0]");
        By txtAddress = By.CssSelector("input[id$=txtMilitaryAddress1]");
        By txtZip = By.CssSelector("input[id$=txtMilitaryZip]");
        By txtCity = By.CssSelector("input[id$=txtMilitaryCity]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");

        By rbAddMilitaryEmployerYes = By.CssSelector("label[for$=rbAddNewEmp_0]");
        By rbAddMilitaryEmployerNo = By.CssSelector("label[for$=rbAddNewEmp_1]");

        By rbHaveYouFiledNo = By.CssSelector("label[for$=rblFiledInStateAfterSeparation_1]");
        By rbDD214Yes = By.CssSelector("label[for$=rblMember4OfDD214_0]");
        By ddServiceBranch = By.CssSelector("select[id$=ddlServiceBranch]");
        By txtEntryDate = By.CssSelector("input[id$=txtServiceEntryDate]");
        By txtSeparationDate = By.CssSelector("input[id$=txtServiceSeparationDate]");
        By ddCharacterOfService = By.CssSelector("select[id$=ddlDischargeStatus]");
        By ddReasonForSeparation = By.CssSelector("select[id$=ddlReasonForSeparation]");
        By rbGovernmentShutdownNo = By.CssSelector("label[for$=rblSepDueToGovShutdown_1]");
        By ddPayGrade = By.CssSelector("select[id$=ddlPayGrade]");
        By txtAccruedDaysOfLeave = By.CssSelector("input[id$=txtAccuredDaysOfLeave]");
        By txtLostDays = By.CssSelector("input[id$=txtLostDays]");
        By rbPhysicalDisabilityNo = By.CssSelector("label[for$=rblDischargePhysicalDisability_1]");
        By rbMilitaryRetireeNo = By.CssSelector("label[for$=rblMilitaryRetiree_1]");
        By rbCompletedFirstTermNo = By.CssSelector("label[for$=rblCompletedFirstFullTermDuty_1]");
        By txtYearsAgreed = By.CssSelector("input[id$=txtYearsOfServiceAgreedTo]");
        By txtYearsCompleted = By.CssSelector("input[id$=ctl00_Main_content_Wizard1_ucMilitaryService_txtYearsOfServiceCompleted]");

        By rbAppliedForEduAllowanceNo = By.CssSelector("label[for$=rblReceivingAnEducationalAllowance_1]");
        By rbAppliedForAllowanceNo = By.CssSelector("label[for$=rblSubsistenceVocRehabTraining_1]");
        By rbAppliedForAssistanceNo = By.CssSelector("label[for$=rblWarOrphanWidowsEducationAllowance_1]");

        public UI_060_MilitaryService()
        {
            if (!rbMilitaryServiceNo.FindIt()) { return; }

            if (!TestData.Type.Contains(2))
            {
                rbMilitaryServiceNo.Click();
                btnNext.Click();
            }
            else
            {
                rbMilitaryServiceYes.Click();
                ddWherePhysicallyLocated.IsPresent()?.SelectDropdownByValue(TestData.StateAbbreviation);
                btnOk.IsPresent()?.Click();
                rbLocatedInHostStateYes.IsPresent()?.Click();
                txtAddress.IsPresent()?.SendKeys(TestData.Address1);
                txtZip.IsPresent()?.SendKeys(TestData.Zip);
                txtCity.IsPresent()?.SendKeys("City");
                //Thread.Sleep(20000);
                btnNext.Click();

                //adding employer
                rbAddMilitaryEmployerYes.Click();
                btnNext.Click();

                //employer info
                rbHaveYouFiledNo.Click();
                rbDD214Yes.Click();
                ddServiceBranch.SelectDropdownByIndex("1");
                txtEntryDate.SendKeys(TestData.WorkBeginDate1);
                txtSeparationDate.SendKeys(TestData.WorkEndDate1);
                ddCharacterOfService.SelectDropdownByIndex("1");
                ddReasonForSeparation.IsPresent()?.SelectDropdownByIndex("1");
                rbGovernmentShutdownNo.IsPresent()?.Click();
                ddPayGrade.SelectDropdownByIndex("1");
                txtAccruedDaysOfLeave.SendKeys("0");
                txtLostDays.IsPresent()?.SendKeys("0");
                rbPhysicalDisabilityNo.Click();
                rbMilitaryRetireeNo.Click();
                rbCompletedFirstTermNo.Click();
                txtYearsAgreed.IsPresent()?.SendKeys("1");
                txtYearsCompleted.IsPresent()?.SendKeys("1");

                rbAppliedForEduAllowanceNo.IsPresent()?.Click();
                rbAppliedForAllowanceNo.Click();
                rbAppliedForAssistanceNo.IsPresent()?.Click();
                btnNext.Click();

                //adding employer
                rbAddMilitaryEmployerNo.Click();
                btnNext.Click();
            }

        }
    }
}
