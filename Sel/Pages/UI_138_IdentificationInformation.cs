namespace Sel.Pages
{
    public class UI_138_IdentificationInformation
    {
        By rbHaveDriverLicenseYes = By.CssSelector("label[for$=rblValidLicense_0]");
        By txtLicenseNumber = By.CssSelector("input[id$=txtDrvLicenseNumber]");
        By ddStateIssued = By.CssSelector("select[id$=ddlStateIssued]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_138_IdentificationInformation()
        {
            if (Helper.CheckPause(Enums.PageType.IdentificationInformation)) return;

            rbHaveDriverLicenseYes.Click();
            txtLicenseNumber.EnterText("Test");
            ddStateIssued.SelectDropdownByValue(TestData.StateAbbreviation);
            CheckInputs();
            btnNext.Click();
        }
    }
}