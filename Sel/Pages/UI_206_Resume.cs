using OpenQA.Selenium;
using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_206_Resume
    {

        By spUpload = By.CssSelector("span.HPRfont70");

        By txtTitle = By.Id("ctl00_Main_content_txtResumeTitle");

        By btnSave = By.Id("ctl00_Main_content_btnSave");
        By btnNo = By.Id("ctl00_Main_content_ucNcaContentUpdater_btnNo");


        By cbAuthorize = By.Id("ctl00_Main_content_ucUIPayment_cbdebitcardacklongform");




        By btnNext = By.Id("ctl00_Main_content_ucGSIButtons_btnNext");

        public UI_206_Resume()
        {
            if (!spUpload.FindIt()) return;

            spUpload.WaitForElementToBeVisible().Click();

            txtTitle.WaitForElementToBeVisible().SendKeys("Test");

            btnSave.Click();
            btnNo.Click();


            cbAuthorize.Click();

            btnNext.Click();

        }
    }
}
