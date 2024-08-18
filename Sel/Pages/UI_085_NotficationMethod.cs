using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Utilities;

namespace Sel.Pages
{
    public class UI_085_NotficationMethod
    {
        By ddUINotices = By.Id("ctl00_Main_content_ucNotificationMethod_ddlPrefDelMethods");
        By chkConsent = By.CssSelector("label[for='ctl00_Main_content_ucNotificationMethod_cbElectronicCommunicationConsent']");
        By ddOtherNotices = By.Id("ctl00_Main_content_ucNotificationMethod_ddlDeterminationNotificationMethod");
        By ddFromWhereAccessing = By.Id("ctl00_Main_content_ucSiteAccess_ddlSiteAccess");
        By dd1099TaxForm = By.Id("ctl00_Main_content_ucNotificationMethod_ddl1099GNotificationMethod");
        By rbLaborMSG = By.CssSelector("label[for='ctl00_Main_content_ucNotificationMethod_rblSignUpMessageLaborService_1']");
        By ddReferral = By.Id("ctl00_Main_content_ucSiteAccess_ddlWebsiteReferral");
        
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_085_NotficationMethod()
        {
            if (new[] { "PFL" }.Contains(TestData.StateAbbreviation!))
            {
                ddUINotices.SelectDropdownByValue("1");
            }
            else
            {
                ddUINotices.SelectDropdownByValue("7");

            }
            chkConsent.Click();

            ddOtherNotices.SelectDropdownByValue("7");

            ddFromWhereAccessing.SelectDropdownByIndex("1");

            dd1099TaxForm.SelectDropdownByValue("7");

            rbLaborMSG.Click();
            ddReferral.SelectDropdownByIndex("1");

            btnNext.Click();
        }
    }
}
