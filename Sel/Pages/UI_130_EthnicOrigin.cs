using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_130_EthnicOrigin
    {
        By rbHispanicNo = By.Id("ctl00_Main_content_ucEthnicity_rblHispanic_1");

        By cbRace = By.Id("ctl00_Main_content_ucEthnicity_chkRaceList_1");

        By rbLimitedEnglishNo = By.Id("ctl00_Main_content_ucEthnicity_rblLangSecondary_1");

        By ddMaritalStatus = By.Id("ctl00_Main_content_ucEthnicity_ddlMaritalStatus");


        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_130_EthnicOrigin()
        {
            rbHispanicNo.Click();

            cbRace.Click();

            rbLimitedEnglishNo.IsPresent()?.Click();

            ddMaritalStatus.IsPresent()?.SelectDropdownByIndex("1");

            btnNext.Click();
        }
    }
}
