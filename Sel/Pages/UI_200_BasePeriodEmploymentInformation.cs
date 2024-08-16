using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_200_BasePeriodEmploymentInformation
    {
        By rbAgreeWithWages = By.Id("ctl00_Main_content_ddlCorrectEmpsAndWages_0");

        By btnNext = By.Id("ctl00_Main_content_btnNextMonetaryReview");
        public UI_200_BasePeriodEmploymentInformation()
        {
            if (!btnNext.FindIt()) { return; }

            rbAgreeWithWages.IsPresent()?.Click();

            btnNext.Click();
        }
    }
}
