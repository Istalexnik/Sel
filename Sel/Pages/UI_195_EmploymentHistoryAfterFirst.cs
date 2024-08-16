using Sel.Data;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sel.Pages
{
    public class UI_195_EmploymentHistoryAfterFirst
    {
        By linkEdit = By.Id("ctl00_Main_content_ucIndEmpHistory_grdIndEmpHistory_ctl02_lnkEditAction");

        By rbAddEmployerYes = By.Id("ctl00_Main_content_rblAddAnotherEntry_0");

        By rbAddEmployerNo = By.Id("ctl00_Main_content_rblAddAnotherEntry_1");

        By btnNext = By.Id("ctl00_Main_content_btnNext");
        public UI_195_EmploymentHistoryAfterFirst()
        {

            if (TestData.Type.Contains(3) && TestData.Type.Contains(2))
            {
                btnNext.Click();
                new UI_190_EmployerPage(TestData.Employer2!, TestData.WorkBeginDate2, TestData.WorkEndDate2);

            }
            else if(TestData.useTwoEmployers)
            {
                rbAddEmployerYes.Click();

                btnNext.Click();

                new UI_185_EmployerSearch(TestData.Employer2!);

                new UI_190_EmployerPage(TestData.Employer2!, TestData.WorkBeginDate2, TestData.WorkEndDate2);
            }

                rbAddEmployerNo.Click();

                btnNext.Click();
     
        }
    }
}
