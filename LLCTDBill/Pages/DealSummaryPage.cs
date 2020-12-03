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

namespace LLCTDBill.Pages
{
    public class DealSummaryPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_topMenu_DealSummary1_lblLenderRef")]
        public IWebElement txtLenderRefNo;

        public void VerifyDealSummary()
        {
            Assert.AreEqual(txtLenderRefNo.Text, WebService.MortgageNo);
        }
    }
}
