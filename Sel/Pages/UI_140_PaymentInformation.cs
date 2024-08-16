using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_140_PaymentInformation
    {
        By rbPaymentMethodDC = By.Id("ctl00_Main_content_ucUIPayment_rblPaymentMethod_1");
        
        By cbAcknowledg = By.Id("ctl00_Main_content_ucUIPayment_cbdebitcardack");

        By cbAcknowledgLong = By.Id("ctl00_Main_content_ucUIPayment_cbdebitcardacklongform");

        By chkIUnderstand = By.CssSelector("label[for='ctl00_Main_content_ucUIPayment_cbdirectdepositack']");

        By btnOk = By.Id("btn-dialog-ok");

        By linkDisclosure = By.Id("predisclosurepdf");

        By chkPreferredPaymentMethod = By.CssSelector("label[for='ctl00_Main_content_ucUIPayment_cbDebitCard']");

        By chkDisclosured = By.CssSelector("label[for='ctl00_Main_content_ucUIPayment_cbAcknowledgeDebitOnPage']");
     
        By chkConsent1099 = By.CssSelector("label[for='ctl00_Main_content_ucUIPayment_cb1099GConsent_0']");

        By rbPaperWeeklyCertsNo = By.CssSelector("label[for='ctl00_Main_content_ucUIPayment_rblWeeklyCert_1']");

        By rbFederalTaxYes = By.Id("ctl00_Main_content_ucPaymentDeductions_rblFederalTaxWithheld_0");
        
        By rbStateTaxYes = By.Id("ctl00_Main_content_ucPaymentDeductions_rblStateTaxWithheld_0");
        
        By rbSnapNo = By.Id("ctl00_Main_content_ucPaymentDeductions_rblSNAPOverpayment_1");
 
        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_140_PaymentInformation()
        {
            rbPaymentMethodDC.Click();

            cbAcknowledg.IsPresent()?.Click();

            cbAcknowledgLong.IsPresent()?.Click();

            chkIUnderstand.IsPresent()?.Click();

            btnOk.IsPresent()?.Click();

            linkDisclosure.IsPresent()?.Click().OpenAndCloseWindow();

            chkPreferredPaymentMethod.IsPresent()?.Click();

            chkDisclosured.IsPresent()?.Click();

            chkConsent1099.IsPresent()?.Click();

            rbPaperWeeklyCertsNo.IsPresent()?.Click();

            rbFederalTaxYes.IsPresent()?.Click();

            rbStateTaxYes.IsPresent()?.Click();

            rbSnapNo.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}
