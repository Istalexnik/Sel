using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Data;
using System.Threading;

namespace Sel.Pages
{
    public class UI_075_ResidentialAddress
    {
        By rbValidation = By.CssSelector("label[for='ctl00_Main_content_ucAddress_rdoCorrectedResidentialAddress_0']");
        By rbValidation2 = By.CssSelector("label[for='ctl00_Main_content_ucAddress_rdoCorrectedMailingAddress_0']");
        By txtAddress1 = By.Id("ctl00_Main_content_ucAddress_txtAddress1");
        By ddWard = By.Id("ctl00_Main_content_ucAddress_ddlAltGeo");
        By rbAddressConfidentialityProgram = By.CssSelector("label[for='ctl00_Main_content_ucAddress_rbACPEnrollment_1']");
        By cbSameAddress = By.Id("ctl00_Main_content_ucAddress_chkPopulateMailAddress");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        
        public UI_075_ResidentialAddress()
        {
            Thread.Sleep(200);

            rbAddressConfidentialityProgram.IsPresent()?.Click();

            txtAddress1.WaitForElementToBeClickable().SendKeys(TestData.Address1 + Keys.Tab);

            if (new[] {"IA", "DC", "LA"}.Any(site => TestData.Site.Contains(site)))
            {
                txtAddress1.WaitForElementToBeStaleAndRefind();
            }

            ddWard.IsPresent()?.SelectDropdownByIndex("1");  //.WaitForElementToBeStaleAndRefind()    -- DC UI UAT

            rbValidation.IsPresent()?.Click();   //.WaitForElementToBeStaleAndRefind()  -- DC UI UAT

            cbSameAddress.Click();


            btnNext.WaitForElementToBeClickable().Click();

        }

    }
}
