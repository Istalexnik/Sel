using OpenQA.Selenium;
using Sel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_143_VerifyYourIdentity
    {
        By titleYourIdentity = By.XPath("(//h2[text()='Verify Your Identity'])");
        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_143_VerifyYourIdentity()
        {
            if (!titleYourIdentity.FindIt()) return;

            btnNext.Click();

            //problem in GUS that th epage shows twice
            btnNext.Click();
        }
    }
}
