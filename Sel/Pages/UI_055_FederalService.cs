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
            if (!rbFederalCivilianEmployeeNo.FindIt()) { return; }

            if (!TestData.Type.Contains(3))
            {
                rbFederalCivilianEmployeeNo.Click();
                btnNext.Click();
            } 
            else
            {
                rbFederalCivilianEmployeeYes.Click();
                rbInHostStateYes.IsPresent()?.Click();
                btnOk.IsPresent()?.Click();
                rbInAnotherStateNo.IsPresent()?.Click();
                rbWagesAssignedOtherStateNo.IsPresent()?.Click();
                rbOutsideOfUSNo.IsPresent()?.Click();
                txtSF50.IsPresent()?.SendKeys(TestData.StateAbbreviation);
                btnNext.Click();

                //adding employer
                rbAddFederalEmployerYes.Click();
                btnNext.Click();

                //employer info
               // spanFIC.IsPresent()?.Click();  //not needed? at least for AZ and IA
                inputFIC.SendKeys(Keys.Down + Keys.Down + Keys.Down + Keys.Tab).WaitForElementToBeStaleAndRefind(); ;
                ddDestinationCode.SelectDropdownByIndex("1").WaitForElementToBeStaleAndRefind();
                rbOtherEmploymentNo.IsPresent()?.Click();
                ddStateOfEmployment.SelectDropdownByValue(TestData.StateAbbreviation).WaitForElementToBeStaleAndRefind();
                txtCity.IsPresent()?.SendKeys("City");
                txtCity2.IsPresent()?.SendKeys("City");
                rbForm8Yes.Click();
                rbForm50Yes.Click();
                txtWorkBeginDate.SendKeys(TestData.WorkBeginDate1);
                txtWorkEndDate.SendKeys(TestData.WorkEndDate1);
                txtSearationpDate.IsPresent()?.SendKeys(TestData.WorkEndDate1);
                ddSeparationReason.SelectDropdownByPartialText("Lay");
                rbGovernmentShutdownNo.IsPresent()?.Click();
                ddEmployerCategory.IsPresent()?.SelectDropdownByIndex("1");
                ddOccupation.IsPresent()?.SelectDropdownByIndex("1");
                txtWagesQ1.SendKeys("5000");
                txtWeeksQ1.IsPresent()?.SendKeys("13");
                txtWagesQ2.SendKeys("5000");
                txtWeeksQ2.IsPresent()?.SendKeys("13");
                txtWagesQ3.SendKeys("5000");
                txtWeeksQ3.IsPresent()?.SendKeys("13");
                txtWagesQ4.SendKeys("5000");
                txtWeeksQ4.IsPresent()?.SendKeys("13");
                txtWagesQ5.IsPresent()?.SendKeys("5000");
                txtWagesQ6.IsPresent()?.SendKeys("5000");
                rbDidYouWorkInNEAfterThatNo.IsPresent()?.Click();
                rbDidYouWorkAnywhereAfterThatNo.Click();
                btnNext.Click();

                //adding employer
                rbAddFederalEmployerNo.Click();
                btnNext.Click();
            }


        }

    }
}
