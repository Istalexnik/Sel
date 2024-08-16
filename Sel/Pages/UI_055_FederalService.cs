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

        By rbFederalCivilianEmployeeNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_1']");
        By rbFederalCivilianEmployeeYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployee_0']");
        By rbInHostStateYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeHostState_0']");
        By btnOk = By.Id("btn-dialog-save");
        By rbInAnotherStateNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblFederalCivilianEmployeeAnotherState_1']");
        By rbWagesAssignedOtherStateNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblHasOtherStateWages_1']");
        By rbOutsideOfUSNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_rblLastOfficialDutyStationOutsideUS_1']");
        By txtSF50 = By.Id("ctl00_Main_content_Wizard1_txtLastOfficialDutyStationLocation");
        By btnNext = By.Id("ctl00_Main_content_Wizard1_StepNavigationTemplateContainerID_StepNextButton");

        By rbAddFederalEmployerYes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_0']");
        By rbAddFederalEmployerNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalCivilEmploymentHistory_rbAddNewEmp_1']");

        By spanFIC = By.ClassName("ui-icon-triangle-1-s");
        By inputFIC = By.Id("cmbCustomFIC");
        By ddDestinationCode = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlDestCodes");
        By rbOtherEmploymentNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblInterveningEmploymentSinceSeparation_1']");
        By ddStateOfEmployment = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlStateOfEmployment");
        By txtCity = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtOutofCountryCity");
        By txtCity2 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtCityOfEmployment");
        
        By rbForm8Yes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm8_0']");
        By rbForm50Yes = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblReceiveStandardForm50_0']");
        By txtWorkBeginDate = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtDateBeganWork");
        By txtWorkEndDate = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtLastDayWorked");
        By txtSearationpDate = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtSeparationDate");
        By ddSeparationReason = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlReasonForSeparation");
        By rbGovernmentShutdownNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblSepDueToGovShutdown_1']");
        By ddEmployerCategory = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlEmployerNAICS");
        By ddOccupation = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_ddlPositionOccGroupCode");
        By txtWagesQ1 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter1");
        By txtWeeksQ1 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ1CreditWeeks");
        By txtWagesQ2 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter2");
        By txtWeeksQ2 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ2CreditWeeks");
        By txtWagesQ3 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter3");
        By txtWeeksQ3 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ3CreditWeeks");
        By txtWagesQ4 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter4");
        By txtWeeksQ4 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtQ4CreditWeeks");
        By txtWagesQ5 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter5");
        By txtWagesQ6 = By.Id("ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_txtWagesQuarter6");
        By rbDidYouWorkInNEAfterThatNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblWorkedInStateAfterFederalEmployment_1']");
        By rbDidYouWorkAnywhereAfterThatNo = By.CssSelector("label[for='ctl00_Main_content_Wizard1_ucFederalGovernmentEmployment_rblOtherEmploymentLastNMonths_1']");


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
