namespace Sel.Pages
{
    public class UI_085_NotficationMethod
    {
        By ddUINotices = By.CssSelector("select[id$=ddlPrefDelMethods]");
        By chkConsent = By.CssSelector("label[for$=cbElectronicCommunicationConsent]");
        By ddOtherNotices = By.CssSelector("select[id$=ddlDeterminationNotificationMethod]");
        By ddFromWhereAccessing = By.CssSelector("select[id$=ddlSiteAccess]");
        By dd1099TaxForm = By.CssSelector("select[id$=ddl1099GNotificationMethod]");
        By rbLaborMSG = By.CssSelector("label[for$=rblSignUpMessageLaborService_1]");
        By ddReferral = By.CssSelector("select[id$=ddlWebsiteReferral]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_085_NotficationMethod()
        {
            if (Helper.CheckPause(Enums.PageType.NotficationMethod)) return;

            ddUINotices.SelectDropdownByValue("7");
            chkConsent.Click();
            ddOtherNotices.SelectDropdownByValue("7");
            ddFromWhereAccessing.SelectDropdownByIndex("1");
            dd1099TaxForm.SelectDropdownByValue("7");
            rbLaborMSG.Click();
            ddReferral.SelectDropdownByIndex("1");
            CheckInputs();
            btnNext.Click();
        }
    }
}