namespace Sel.Pages
{
    public class UI_020_PrivacyAgreement
    {
        By btnAgree = By.CssSelector("input[id$=btnAgree]");

        public UI_020_PrivacyAgreement()
        {
            if (Helper.CheckPause(Enums.PageType.PrivacyAgreement)) return;

            btnAgree.Click();
        }
    }
}