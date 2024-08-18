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
    public class UI_100_EmploymentInformation
    {
        By titleEmploymentInformation = By.XPath("(//h2[text()='Employment Information'])");

        By ddCurrentEmpStatus = By.Id("ctl00_Main_content_ucEmployment_ddlEmployStatus");

        By ddTypeOfBusiness = By.Id("ctl00_Main_content_ucEmployment_ddlTypeBusiness");

        By ddUnempEligibilityStatus = By.Id("ctl00_Main_content_ucEmployment_ddlUnemploymentInsurance");

        By rbLookingForWorkYes = By.CssSelector("label[for='ctl00_Main_content_ucEmployment_rblLookingForWork_0']");

        By rbCovid19No = By.CssSelector("label[for='ctl00_Main_content_ucEmployment_rblCovid19_1']");

        By rbApprenticeshipNo = By.Id("ctl00_Main_content_ucEmployment_rblInterestedInRegisteredApprenticeship_1");

        By rbCertificationsNo = By.Id("ctl00_Main_content_ucEmployment_rblCertifications_1");

        By rbDomesticViolenceNo = By.CssSelector("label[for='ctl00_Main_content_ucEmployment_rblFilingclaimDueToDomesticViolence_1']");

        By rbFarmworkerNo = By.Id("ctl00_Main_content_ucEmployment_rblMigrant_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_100_EmploymentInformation()
        {
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!)) return;

            if (!titleEmploymentInformation.FindIt()) return;

            ddCurrentEmpStatus.SelectDropdownByValue("3");

            //if (new[] { "AZ" }.Any(site => TestData.StateAbbreviation.Contains(site))) { 
            //    btnNext.Click();
            //    return;
            //}


            ddTypeOfBusiness.SelectDropdownByIndex("1");

            ddUnempEligibilityStatus.SelectDropdownByIndex("1");

            if (new[] { "LA" }.Contains(TestData.StateAbbreviation!))
            {
                ddUnempEligibilityStatus.WaitForElementToBeStaleAndRefind();
            }




            rbCovid19No.Click();

            rbApprenticeshipNo.Click();

            rbCertificationsNo.Click();

            rbLookingForWorkYes.WaitForElementToBeClickable().Click();

            rbDomesticViolenceNo.Click();

            rbFarmworkerNo.Click();

            btnNext.Click();

        }
    }
}
