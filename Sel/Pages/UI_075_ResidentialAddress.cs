namespace Sel.Pages
{
    public class UI_075_ResidentialAddress
    {
        By rbValidation = By.CssSelector("label[for$=rdoCorrectedResidentialAddress_0]");
        By rbValidation2 = By.CssSelector("label[for=rdoCorrectedMailingAddress_0]");
        By txtAddress1 = By.CssSelector("input[id$=txtAddress1]");
        By ddWard = By.CssSelector("select[id$=ddlAltGeo]");
        By rbAddressConfidentialityProgram = By.CssSelector("label[for=rbACPEnrollment_1]");
        By cbSameAddress = By.CssSelector("label[for$=chkPopulateMailAddress]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_075_ResidentialAddress()
        {
            if (Helper.CheckPause(Enums.PageType.ResidentialAddress)) return;

            rbAddressConfidentialityProgram.Click();
            txtAddress1.EnterText(TestData.Address1 + Keys.Tab);
            ddWard.SelectDropdownByIndex("1");
            rbValidation.Click();
            cbSameAddress.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}