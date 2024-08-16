using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_225_ClaimConfirmation
    {

        By btnNext = By.Id("ctl00_Main_content_btnNext");

        public UI_225_ClaimConfirmation()
        {
            btnNext.Click();
        }
    }
}
