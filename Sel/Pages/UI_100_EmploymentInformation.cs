namespace Sel.Pages
{
    public class UI_100_EmploymentInformation
    {
        By ddCurrentEmpStatus = By.CssSelector("select[id$=ddlEmployStatus]");
        By ddTypeOfBusiness = By.CssSelector("select[id$=ddlTypeBusiness]");
        By ddUnempEligibilityStatus = By.CssSelector("select[id$=ddlUnemploymentInsurance]");
        By rbLookingForWorkYes = By.CssSelector("label[for$=rblLookingForWork_0]");
        By rbCovid19No = By.CssSelector("label[for$=rblCovid19_1]");
        By rbApprenticeshipNo = By.CssSelector("label[for$=rblInterestedInRegisteredApprenticeship_1]");
        By rbCertificationsNo = By.CssSelector("label[for$=rblCertifications_1]");
        By rbDomesticViolenceNo = By.CssSelector("label[for$=rblFilingclaimDueToDomesticViolence_1]");
        By rbFarmworkerNo = By.CssSelector("label[for$=rblMigrant_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_100_EmploymentInformation()
        {
            if (Helper.CheckPause(Enums.PageType.EmploymentInformation)) return;
            ddCurrentEmpStatus.SelectDropdownByValue("3");
            ddTypeOfBusiness.SelectDropdownByIndex("1");
            ddUnempEligibilityStatus.SelectDropdownByIndex("1");
            rbCovid19No.Click();
            rbApprenticeshipNo.Click();
            rbCertificationsNo.Click();
            rbLookingForWorkYes.Click();
            rbDomesticViolenceNo.Click();
            rbFarmworkerNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}