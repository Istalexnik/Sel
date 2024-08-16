using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            if (!titleMilitaryService.FindIt()) { return; }

            rbSpouseNo.IsPresent()?.Click();

            if (!TestData.Type.Contains(2))
            {
                rbVeteranNo.IsPresent()?.Click();
            }

            rbServed180DaysNo.IsPresent()?.Click();

            ddClassifiedDisabledVeteran.IsPresent()?.SelectDropdownByIndex("1");

            if (TestData.Type.Contains(2))
            {
                ddWoundedYes.IsPresent()?.Click();
                ddTAPNo.Click();
                dd24Or12OfdischargeNo.IsPresent()?.Click();
                Thread.Sleep(500);
                btnNext.WaitForElementToBeClickable(25);

            }


                    btnNext.Click();
 

           
        }
    }
}
