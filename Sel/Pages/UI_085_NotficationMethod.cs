using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (new[] { "PFL" }.Any(site => TestData.Site.Contains(site)))
            {
                ddUINotices.SelectDropdownByValue("1");
            }
            else
            {
                ddUINotices.SelectDropdownByValue("7");

            }
            chkConsent.IsPresent()?.Click();

            ddOtherNotices.IsPresent()?.SelectDropdownByValue("7");

            ddFromWhereAccessing.IsPresent()?.SelectDropdownByIndex("1");

            dd1099TaxForm.IsPresent()?.SelectDropdownByValue("7");

            rbLaborMSG.IsPresent()?.Click();
            ddReferral.IsPresent()?.SelectDropdownByIndex("1");

            btnNext.Click();
        }
    }
}
