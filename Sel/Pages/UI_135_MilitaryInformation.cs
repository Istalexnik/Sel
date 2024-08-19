using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Sel.Utilities;

namespace Sel.Pages
{
    public class UI_135_MilitaryInformation
    {
        By titleMilitaryService = By.XPath("(//h2[text()='Military Service'])");

        By rbSpouseNo = By.Id("ctl00_Main_content_ucVeteran_rblSpouseEligiblePerson_1");
       
        By rbVeteranNo = By.Id("ctl00_Main_content_ucVeteran_rblMilitaryService_1");

        By rbServed180DaysNo = By.Id("ctl00_Main_content_ucVeteran_rblServedConsecutiveDaysInActiveDuty_1");

        By ddClassifiedDisabledVeteran = By.Id("ctl00_Main_content_ucVeteran_ddlClassifiedAsDisabledVeteran");

        By ddWoundedYes = By.Id("ctl00_Main_content_ucVeteran_rblWounded_0");

        By ddTAPNo = By.Id("ctl00_Main_content_ucVeteran_rblTAPWorkshop_1");

        By dd24Or12OfdischargeNo = By.Id("ctl00_Main_content_ucVeteran_rblTransitioningServiceMember_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");


        public UI_135_MilitaryInformation()
        {
            if (!titleMilitaryService.FindIt()) return;

            rbSpouseNo.Click();

            if (TestData.ClaimType != Enums.ClaimType.Regular)
            {
                rbVeteranNo.Click();
            }

            rbServed180DaysNo.Click();

            ddClassifiedDisabledVeteran.SelectDropdownByIndex("1");

            if (TestData.ClaimType == Enums.ClaimType.UCX)
            {
                ddWoundedYes.Click();
                ddTAPNo.Click();
                dd24Or12OfdischargeNo.Click();
                Thread.Sleep(500);
                btnNext.WaitForElementToBeClickable(25);

            }


                    btnNext.Click();
 

           
        }
    }
}
