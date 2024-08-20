namespace Sel.Pages
{
    public class UI_080_PhoneNumber
    {
        By txtPhone1 = By.CssSelector("input[id$=txtPrimePhone1]");
        By txtPhone2 = By.CssSelector("input[id$=ctl00_Main_content_ucPhone_txtPrimePhone2]");
        By txtPhone3 = By.CssSelector("input[id$=ctl00_Main_content_ucPhone_txtPrimePhone3]");
        By ddPhoneType = By.CssSelector("select[id$=ddlPrimePhoneType]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_080_PhoneNumber()
        {
            if (Helper.CheckPause(Enums.PageType.PhoneNumber)) return;
            txtPhone1.EnterText(TestData.Phone.Substring(0, 3));
            txtPhone2.EnterText(TestData.Phone.Substring(3, 3));
            txtPhone3.EnterText(TestData.Phone.Substring(6, 4));
            ddPhoneType.SelectDropdownByIndex("1");
            CheckInputs();
            btnNext.Click();
        }
    }
}