using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Data;
using System.Threading;


namespace Sel.Pages
{
    public class UI_190_EmployerPage
    {
                               
        By txtEmployerName = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEmpName");

        By spanEmployerName = By.Id("ctl00_Main_content_ucIndEmpHistory_lbl_txtEmpName");

        By txtEmployerNameOnCheckStub = By.Id("ctl00_Main_content_ucIndEmpHistory_txtNameOnCheckStub");

        By txtSuggestions = By.Id("ac_results");

        By txtPhone1 = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone1");

        By txtPhone2 = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone2");

        By txtPhone3 = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEmployerPhone3");

        By rbDCGovermentAgencyNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblAgency_1']");

        By rbEarnAtLeastYes = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblEmployerLiable_0']");

        By rbLastEmployerYes = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblLastEmployer_0']");

        By rbTemporaryEmployerNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblIsThisEmployerTempOrAgency_1']");

        By txtJobTitle = By.Id("ctl00_Main_content_ucIndEmpHistory_txtJobTitle");

        By ddEmployerType = By.Id("ctl00_Main_content_ucIndEmpHistory_cboEmpType");

        By ddFullOrPartTime = By.Id("ctl00_Main_content_ucIndEmpHistory_cboFullPartTime");

        By ddScheduleOfWork = By.Id("ctl00_Main_content_ucIndEmpHistory_ddlScheduleOfWork");

        By ddHours = By.Id("ctl00_Main_content_ucIndEmpHistory_ddlWholeHours");

        By txtGrossSalary = By.Id("ctl00_Main_content_ucIndEmpHistory_txtSalary");

        By ddSalaryBasedUpon = By.Id("ctl00_Main_content_ucIndEmpHistory_cboSalaryBase");

        By rbComissionBasedNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblSalaryCommission_1");

        By txtWorkBeginDate = By.Id("ctl00_Main_content_ucIndEmpHistory_txtStartDate");

        By rbCurrentlyEmployedNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblCurrentlyEmployed_1");

        By txtearningsThisWeek = By.Id("ctl00_Main_content_ucIndEmpHistory_txtGrossEarningsThisWeek");

        By txtHoursThisWeek = By.Id("ctl00_Main_content_ucIndEmpHistory_txtHoursWorkedThisWeek");

        By ddSeparationReason = By.Id("ctl00_Main_content_ucIndEmpHistory_cboSeparationReason");
        
        By ddSeparationCategory = By.Id("ctl00_Main_content_ucIndEmpHistory_ddlLeaveReasonSubType");

        By ddReasonOfLayoff = By.Id("ctl00_Main_content_ucIndEmpHistory_ddlLackOfWorkEvent");

        By rbVoluntiryLayoffNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblVoluntaryLayoff_1']");

        By txtWorkEndDate = By.Id("ctl00_Main_content_ucIndEmpHistory_txtEndDate");

        By rbRecallNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblIntendToRecall_1");

        By rbFamilyResponsobilitiesNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblFamilyResponsibilities_1']");

        By rbEducationalNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblEducationalInstitution_1");
        
        By rbSchoolBusNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblSchoolBusCompanyEmp_1']");

        By rbOfficerRelativeNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblCorporateOfficer_1");

        By rbTransferOutOfCountryNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblTransferOutOfCountry_1");

        By rbSpouseOfEmployerNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblSpouseorChildofEmployer_1']");

        By rbLackOfTransportationNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_rblLackOfTransportation_1']");

        By ifrJobDuties = By.XPath("//iFrame[contains(@title, 'ctl00_Main_content_ucIndEmpHistory_txtJobDuties_txtWYSIWYGEditor')]");

        By txtJobDuties = By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr cke_show_borders']");
        
        By rbSeveranceNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Severance_rdoPayType_1");

        By rbVacationNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Vacation_rdoPayType_1");

        By rbHolidayPayNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Holiday_rdoPayType_1");

        By rbSickPayNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Sick_rdoPayType_1");

        By rbBonusPayNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_Bonus_rdoPayType_1");

        By rbWarnPaymentNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_WARN_rdoPayType_1']");
        
        By rbWagesInLieuNo = By.CssSelector("label[for='ctl00_Main_content_ucIndEmpHistory_ucBenefitPaymentForm_InLieu_rdoPayType_1']");

        By rbPensionNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblPension_1");

        By rb401KNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rbl401k_1");

        By rbMilitaryDisabilityNo = By.Id("ctl00_Main_content_ucIndEmpHistory_ucPensionRetirement_rblMilitaryDisabilityCompensation_1");

        By rbWorkersCompensationAreNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rblWCReceived_1");

        By rbWorkersCompensationDidNo = By.Id("ctl00_Main_content_ucIndEmpHistory_rdoWCNewReceived_1");

        By btnNext = By.Id("ctl00_Main_content_ucWizardButtons_btnSave");

        By btnConfirm = By.XPath("//button[@id='btn-dialog-save']");


        public UI_190_EmployerPage(string employer, string beginDate, string endDate)
        {
            //workaround because page is not loaded yet but the phone is already searched for(needs some investigation)
            txtPhone1.WaitForElementToBeVisible();

            if (txtEmployerName.IsClickable() && string.IsNullOrEmpty(txtEmployerName.WaitForElementToBeClickable().GetText()))
            {
                txtEmployerName.EnterText(employer, txtSuggestions).WaitForElementToBeStaleAndRefind();
            }



            txtPhone1.Clear().SendKeys(TestData.Phone.Substring(0, 3));

            txtPhone2.Clear().SendKeys(TestData.Phone.Substring(3, 3));

            txtPhone3.Clear().SendKeys(TestData.Phone.Substring(6, 4));

            rbDCGovermentAgencyNo.IsPresent()?.Click();

            rbLastEmployerYes.WaitForElementToBeClickable().Click();

            Thread.Sleep(4000);

            rbEarnAtLeastYes.IsPresent()?.WaitForElementToBeClickable().Click();

            Thread.Sleep(4000);

            rbTemporaryEmployerNo.IsPresent()?.JSClick();

            if (string.IsNullOrEmpty(txtEmployerNameOnCheckStub.WaitForElementToBeClickable().GetText()))
            {
                txtEmployerNameOnCheckStub.SendKeys(spanEmployerName.Text());
            }

            txtJobTitle.EnterText2(TestData.JobTitle, txtSuggestions).WaitForElementToBeStaleAndRefind();

            ddEmployerType.SelectDropdownByIndex("1");

            ddFullOrPartTime.SelectDropdownByIndex("1");

            ddScheduleOfWork.IsPresent()?.SelectDropdownByIndex("1");

            ddHours.SelectDropdownByIndex("1");

            txtGrossSalary.SendKeys("40");

            ddSalaryBasedUpon.SelectDropdownByIndex("1");

            rbComissionBasedNo.Click();

            txtWorkBeginDate.SendKeys(beginDate);

            rbCurrentlyEmployedNo.Click();

            txtearningsThisWeek.SendKeys("0");

            txtHoursThisWeek.IsPresent()?.SendKeys("0");

            try
            {
                ddSeparationReason.SelectDropdownByPartialText("Lay").WaitForElementToBeStaleAndRefind();
            }
            catch(WebDriverTimeoutException)
            {
              //UCFE doesn't have refresh after separation entry so just catch the exception and move on
            }
            //if (!TestData.Type.Contains(3))
            //{
            //    ddSeparationReason.WaitForElementToBeStaleAndRefind();
            //}



            ddSeparationCategory.IsPresent()?.SelectDropdownByPartialText("Lay").WaitForElementToBeStaleAndRefind();
            
            ddReasonOfLayoff.IsPresent()?.SelectDropdownByValue("1");

            rbVoluntiryLayoffNo.IsPresent()?.Click();
            
            txtWorkEndDate.SendKeys(endDate);

            rbRecallNo.IsPresent()?.Click();

            rbFamilyResponsobilitiesNo.IsPresent()?.Click();

            rbEducationalNo.Click();

            rbSchoolBusNo.IsPresent()?.Click();

            rbOfficerRelativeNo.IsPresent()?.Click();

            rbTransferOutOfCountryNo.Click();

            rbSpouseOfEmployerNo.IsPresent()?.Click();

            rbLackOfTransportationNo.IsPresent()?.Click();

            ifrJobDuties.SendTextToIFrame(txtJobDuties, "Test");

            rbSeveranceNo.Click();

            rbVacationNo.IsPresent()?.Click();

            rbHolidayPayNo.IsPresent()?.Click();

            rbSickPayNo.IsPresent()?.Click();

            rbBonusPayNo.IsPresent()?.Click();

            rbWarnPaymentNo.IsPresent()?.Click();

            rbWagesInLieuNo.IsPresent()?.Click();

            rbPensionNo.Click();

            rb401KNo.IsPresent()?.Click();

            rbMilitaryDisabilityNo.IsPresent()?.Click();

            rbWorkersCompensationAreNo.IsPresent()?.Click();

            rbWorkersCompensationDidNo.IsPresent()?.Click();

           //Thread.Sleep(30000);

            btnNext.Click();

            btnConfirm.LoopAndClickAllVisible();

            new UI_193_YourEmploymentHistoryAfterFirst();
        }
    }
}
