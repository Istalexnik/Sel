namespace Sel.Pages
{
    public class UI_140_PaymentInformation
    {
        By rbPaymentMethodDC = By.CssSelector("label[for$=rblPaymentMethod_1]");
        By cbAcknowledg = By.CssSelector("label[for$=cbdebitcardack]");
        By cbAcknowledgLong = By.CssSelector("label[for$=cbdebitcardacklongform]");
        By chkIUnderstand = By.CssSelector("label[for$=cbdirectdepositack]");
        By btnOk = By.CssSelector("button[id=btn-dialog-ok]");
        By linkDisclosure = By.CssSelector("a[id=predisclosurepdf]");
        By chkPreferredPaymentMethod = By.CssSelector("label[for$=cbDebitCard]");
        By chkDisclosured = By.CssSelector("label[for$=cbAcknowledgeDebitOnPage]");
        By chkConsent1099 = By.CssSelector("label[for$=cb1099GConsent_0]");
        By rbPaperWeeklyCertsNo = By.CssSelector("label[for$=rblWeeklyCert_1]");
        By rbFederalTaxYes = By.CssSelector("label[id$=rblFederalTaxWithheld_0]");
        By rbStateTaxYes = By.CssSelector("label[for$=rblStateTaxWithheld_0]");
        By rbSnapNo = By.CssSelector("label[for$=rblSNAPOverpayment_1]");
        By btnNext = By.CssSelector("input[id$=btnNext]");

        public UI_140_PaymentInformation()
        {
            if (Helper.CheckPause(Enums.PageType.IdentificationInformation)) return;

            rbPaymentMethodDC.Click();
            cbAcknowledg.Click();
            cbAcknowledgLong.Click();
            chkIUnderstand.Click();
            btnOk.Click();
            linkDisclosure.Click().OpenAndCloseWindow();
            chkPreferredPaymentMethod.Click();
            chkDisclosured.Click();
            chkConsent1099.Click();
            rbPaperWeeklyCertsNo.Click();
            rbFederalTaxYes.Click();
            rbStateTaxYes.Click();
            rbSnapNo.Click();
            CheckInputs();
            btnNext.Click();
        }
    }
}