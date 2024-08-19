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
            if (Helper.CheckPause(Enums.PageType.MilitaryService)) return;

            if (TestData.ClaimType != Enums.ClaimType.UCX)
            {
                rbMilitaryServiceNo.Click();
                CheckInputs();
                btnNext.Click();
            }
            else
            {
                rbMilitaryServiceYes.Click();
                ddWherePhysicallyLocated.SelectDropdownByValue(TestData.StateAbbreviation);
                btnOk.Click();
                rbLocatedInHostStateYes.Click();
                txtAddress.SendKeys(TestData.Address1);
                txtZip.SendKeys(TestData.Zip!);
                txtCity.SendKeys("City");
                CheckInputs();
                btnNext.Click();

                //adding employer
                rbAddMilitaryEmployerYes.Click();
                CheckInputs();
                btnNext.Click();

                //employer info
                rbHaveYouFiledNo.Click();
                rbDD214Yes.Click();
                ddServiceBranch.SelectDropdownByIndex("1");
                txtEntryDate.SendKeys(TestData.WorkBeginDate1);
                txtSeparationDate.SendKeys(TestData.WorkEndDate1);
                ddCharacterOfService.SelectDropdownByIndex("1");
                ddReasonForSeparation.SelectDropdownByIndex("1");
                rbGovernmentShutdownNo.Click();
                ddPayGrade.SelectDropdownByIndex("1");
                txtAccruedDaysOfLeave.SendKeys("0");
                txtLostDays.SendKeys("0");
                rbPhysicalDisabilityNo.Click();
                rbMilitaryRetireeNo.Click();
                rbCompletedFirstTermNo.Click();
                txtYearsAgreed.SendKeys("1");
                txtYearsCompleted.SendKeys("1");
                rbAppliedForEduAllowanceNo.Click();
                rbAppliedForAllowanceNo.Click();
                rbAppliedForAssistanceNo.Click();
                CheckInputs();
                btnNext.Click();

                //adding employer
                rbAddMilitaryEmployerNo.Click();
                CheckInputs();
                btnNext.Click();
            }
        }
    }
}
