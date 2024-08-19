namespace Sel.Pages
{
    public class UI_055_FederalService
    {
        By rbFederalCivilianEmployeeNo = By.CssSelector("label[for$=rblFederalCivilianEmployee_1]");
        By rbFederalCivilianEmployeeYes = By.CssSelector("label[for$=rblFederalCivilianEmployee_0]");
        By rbInHostStateYes = By.CssSelector("label[for$=rblFederalCivilianEmployeeHostState_0]");
        By btnOk = By.CssSelector("input[id=btn-dialog-save]");
        By rbInAnotherStateNo = By.CssSelector("label[for$=rblFederalCivilianEmployeeAnotherState_1]");
        By rbWagesAssignedOtherStateNo = By.CssSelector("label[for$=rblHasOtherStateWages_1]");
        By rbOutsideOfUSNo = By.CssSelector("label[for$=rblLastOfficialDutyStationOutsideUS_1]");
        By txtSF50 = By.CssSelector("input[id$=txtLastOfficialDutyStationLocation]");
        By btnNext = By.CssSelector("input[id$=StepNextButton]");
        By rbAddFederalEmployerYes = By.CssSelector("label[for$=rbAddNewEmp_0]");
        By rbAddFederalEmployerNo = By.CssSelector("label[for$=rbAddNewEmp_1]");
        By spanFIC = By.CssSelector("span[class=ui-icon-triangle-1-s]");
        By inputFIC = By.CssSelector("input[id=cmbCustomFIC]");
        By ddDestinationCode = By.CssSelector("select[id$=ddlDestCodes]");
        By rbOtherEmploymentNo = By.CssSelector("label[for=rblInterveningEmploymentSinceSeparation_1]");
        By ddStateOfEmployment = By.CssSelector("select[id$=ddlStateOfEmployment]");
        By txtCity = By.CssSelector("input[id$=txtOutofCountryCity]");
        By txtCity2 = By.CssSelector("input[id$=txtCityOfEmployment]");
        By rbForm8Yes = By.CssSelector("label[for$=rblReceiveStandardForm8_0]");
        By rbForm50Yes = By.CssSelector("label[for$=rblReceiveStandardForm50_0]");
        By txtWorkBeginDate = By.CssSelector("input[id$=txtDateBeganWork]");
        By txtWorkEndDate = By.CssSelector("input[id$=txtLastDayWorked]");
        By txtSearationpDate = By.CssSelector("input[id$=txtSeparationDate]");
        By ddSeparationReason = By.CssSelector("select[id$=ddlReasonForSeparation]");
        By rbGovernmentShutdownNo = By.CssSelector("label[for$=rblSepDueToGovShutdown_1]");
        By ddEmployerCategory = By.CssSelector("select[id$=ddlEmployerNAICS]");
        By ddOccupation = By.CssSelector("select[id$=ddlPositionOccGroupCode]");
        By txtWagesQ1 = By.CssSelector("input[id$=txtWagesQuarter1");
        By txtWeeksQ1 = By.CssSelector("input[id$=txtQ1CreditWeeks]");
        By txtWagesQ2 = By.CssSelector("input[id$=txtWagesQuarter2]");
        By txtWeeksQ2 = By.CssSelector("input[id$=txtQ2CreditWeeks]");
        By txtWagesQ3 = By.CssSelector("input[id$=txtWagesQuarter3]");
        By txtWeeksQ3 = By.CssSelector("input[id$=txtQ3CreditWeeks]");
        By txtWagesQ4 = By.CssSelector("input[id$=txtWagesQuarter4]");
        By txtWeeksQ4 = By.CssSelector("input[id$=txtQ4CreditWeeks]");
        By txtWagesQ5 = By.CssSelector("input[id$=txtWagesQuarter5]");
        By txtWagesQ6 = By.CssSelector("input[id$=txtWagesQuarter6]");
        By rbDidYouWorkInNEAfterThatNo = By.CssSelector("label[for$=rblWorkedInStateAfterFederalEmployment_1]");
        By rbDidYouWorkAnywhereAfterThatNo = By.CssSelector("label[for$=rblOtherEmploymentLastNMonths_1]");

        public UI_055_FederalService()
        {
            if (Helper.CheckPause(Enums.PageType.FederalService)) return;

            if (TestData.ClaimType != Enums.ClaimType.UCFE)
            {
                rbFederalCivilianEmployeeNo.Click();
                CheckInputs();
                btnNext.Click();
            }
            else
            {
                rbFederalCivilianEmployeeYes.Click();
                rbInHostStateYes.Click();
                btnOk.Click();
                rbInAnotherStateNo.Click();
                rbWagesAssignedOtherStateNo.Click();
                rbOutsideOfUSNo.Click();
                txtSF50.SendKeys(TestData.StateAbbreviation!);
                CheckInputs();
                btnNext.Click();

                //adding employer
                rbAddFederalEmployerYes.Click();
                CheckInputs();
                btnNext.Click();

                //employer info
                inputFIC.SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Tab);
                ddDestinationCode.SelectDropdownByIndex("1");
                rbOtherEmploymentNo.Click();
                ddStateOfEmployment.SelectDropdownByValue(TestData.StateAbbreviation);
                txtCity.SendKeys("City");
                txtCity2.SendKeys("City");
                rbForm8Yes.Click();
                rbForm50Yes.Click();
                txtWorkBeginDate.SendKeys(TestData.WorkBeginDate1);
                txtWorkEndDate.SendKeys(TestData.WorkEndDate1);
                txtSearationpDate.SendKeys(TestData.WorkEndDate1);
                ddSeparationReason.SelectDropdownByText("Lay", true);
                rbGovernmentShutdownNo.Click();
                ddEmployerCategory.SelectDropdownByIndex("1");
                ddOccupation.SelectDropdownByIndex("1");
                txtWagesQ1.SendKeys("5000");
                txtWeeksQ1.SendKeys("13");
                txtWagesQ2.SendKeys("5000");
                txtWeeksQ2.SendKeys("13");
                txtWagesQ3.SendKeys("5000");
                txtWeeksQ3.SendKeys("13");
                txtWagesQ4.SendKeys("5000");
                txtWeeksQ4.SendKeys("13");
                txtWagesQ5.SendKeys("5000");
                txtWagesQ6.SendKeys("5000");
                rbDidYouWorkInNEAfterThatNo.Click();
                rbDidYouWorkAnywhereAfterThatNo.Click();
                CheckInputs();
                btnNext.Click();

                //adding employer
                rbAddFederalEmployerNo.Click();
                CheckInputs();
                btnNext.Click();
            }
        }
    }
}