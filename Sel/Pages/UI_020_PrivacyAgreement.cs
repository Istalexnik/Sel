using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_020_PrivacyAgreement
    {
        By btnAgree = By.Id("ctl00_Main_content_ucPrivacyAgreement_btnAgree");


        public UI_020_PrivacyAgreement()
        {
            if (!btnAgree.FindIt()) { return; }

            btnAgree.Click();
        }
    }
}
