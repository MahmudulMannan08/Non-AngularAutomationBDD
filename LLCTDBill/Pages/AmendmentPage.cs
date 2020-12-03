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
    public class AmendmentPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rptLenMortgage_ctl00_lblFieldNameM")]
        public IWebElement lblLNField1;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rptLenMortgage_ctl01_lblFieldNameM")]
        public IWebElement lblLNField2;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rptLenMortgage_ctl02_lblFieldNameM")]
        public IWebElement lblLNField3;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rptLenMortgage_ctl00_lblLenderUpdatedValueM")]
        public IWebElement txtLNField1;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rptLenMortgage_ctl01_lblLenderUpdatedValueM")]
        public IWebElement txtLNField2;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rptLenMortgage_ctl02_lblLenderUpdatedValueM")]
        public IWebElement txtLNField3;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_btnContinue")]
        public IWebElement btnContinue;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_lblClosingDate")]
        public IWebElement lblClosingDate;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_lblLawClosingDate")]
        public IWebElement txtClosingDateCurrent;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_lblLenClosingDate")]
        public IWebElement txtClosingDateUpdate;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rbnClosingDate_0")]
        public IWebElement btnAccept;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_rbnClosingDate_1")]
        public IWebElement btnDecline;

        public void VerifyLenderFieldAmendments(int NumberofAmends, string[] UpdateValue)
        {
            for (int i = 0; i < NumberofAmends; i++)
            {
                if (UpdateValue[i].Contains("-"))
                {
                    DateTime date = Convert.ToDateTime(UpdateValue[i]);
                    UpdateValue[i] = ConvertDateFormat(date, "MMM dd/yyyy");
                }

                Assert.True(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_rptLenMortgage_ctl0" + i.ToString() + "_lblFieldNameM"));

                Assert.True(driver.FindElement(By.Id("ctl00_mainContentPlaceHolder_rptLenMortgage_ctl0" + i.ToString() + "_lblLenderUpdatedValueM")).Text.Replace(",", "").Replace("$", "").Equals(UpdateValue[i]));
            }
        }

        public void VerifySharedFieldAmendments(string CurrentValue, string UpdateValue, string Action)
        {
            CurrentValue = ConvertStringDateFormat(CurrentValue, "yyyy-MM-dd", "MMM dd/yyyy");
            UpdateValue = ConvertStringDateFormat(UpdateValue, "yyyy-MM-dd", "MMM dd/yyyy");

            Assert.True(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_lblClosingDate"));
            Assert.True(txtClosingDateCurrent.Text.Equals(CurrentValue));
            Assert.True(txtClosingDateUpdate.Text.Equals(UpdateValue));

            switch (Action)
            {
                case "Accept":
                    UIHelper.ClickOnLink(btnAccept);
                    break;
                case "Decline":
                    UIHelper.ClickOnLink(btnDecline);
                    break;
            }
            UIHelper.WaitForPageLoad(25);
        }

        public void AcknowledgeAmendment()
        {
            UIHelper.ClickOnLink(btnContinue);
            UIHelper.WaitForPageLoad(45);
        }
    }
}
