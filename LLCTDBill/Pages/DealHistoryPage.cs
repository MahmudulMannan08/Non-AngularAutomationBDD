using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TechTalk.SpecRun.Common.Helper;

namespace LLCTDBill.Pages
{
    public class DealHistoryPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_DealHistory1_grdDealHistory")]
        public IWebElement tbDealHistory;

        public void VerifyDealHistoryActivity(int rowNumb, string name, string activity)
        {
            Wait.Until(UIHelper.ElementIsClickable(tbDealHistory));

            IList<IWebElement> allRows = tbDealHistory.FindElements(By.TagName("tr"));
            IList<IWebElement> rowColumns = allRows[rowNumb].FindElements(By.TagName("td"));
            Assert.True(rowColumns[0].Text.Equals(name));
            Assert.True(rowColumns[1].Text.Equals(activity + "."));
            Assert.Greater(rowColumns[2].Text.Length, 0);
            Console.WriteLine("Activity Date: ", rowColumns[2].Text);
        }
    }
}
