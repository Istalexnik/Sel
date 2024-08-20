using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sel.Data;
using Sel.Utilities;


namespace Sel.Pages
{
    public class UI_138_IdentificationInformation
    {
        By rbHaveDriverLicenseYes = By.CssSelector("label[for='ctl00_Main_content_ucDrvLicense_rblValidLicense_0']");

        By txtLicenseNumber = By.Id("ctl00_Main_content_ucDrvLicense_txtDrvLicenseNumber");

        By ddStateIssued = By.Id("ctl00_Main_content_ucDrvLicense_ddlStateIssued");

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_138_IdentificationInformation()
        {
            if (!rbHaveDriverLicenseYes.FindIt()) return;

            rbHaveDriverLicenseYes.Click();

            txtLicenseNumber.EnterText("Test");

            ddStateIssued.SelectDropdownByValue(TestData.StateAbbreviation);

            btnNext.Click();
        }
    }
}
