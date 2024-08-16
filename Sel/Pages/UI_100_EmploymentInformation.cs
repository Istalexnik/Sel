using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site))) { return; }

            if (!titleEmploymentInformation.FindIt()) { return; }

            ddCurrentEmpStatus.SelectDropdownByValue("3");

            //if (new[] { "AZ" }.Any(site => TestData.Site.Contains(site))) { 
            //    btnNext.Click();
            //    return;
            //}


            ddTypeOfBusiness.IsPresent()?.SelectDropdownByIndex("1");

            ddUnempEligibilityStatus.IsPresent()?.SelectDropdownByIndex("1");

            if (new[] { "LA" }.Any(site => TestData.Site.Contains(site)))
            {
                ddUnempEligibilityStatus.WaitForElementToBeStaleAndRefind();
            }




            rbCovid19No.IsPresent()?.Click();

            rbApprenticeshipNo.IsPresent()?.Click();

            rbCertificationsNo.IsPresent()?.Click();

            rbLookingForWorkYes.IsPresent()?.WaitForElementToBeClickable().Click();

            rbDomesticViolenceNo.IsPresent()?.Click();

            rbFarmworkerNo.IsPresent()?.Click();

            btnNext.Click();

        }
    }
}
