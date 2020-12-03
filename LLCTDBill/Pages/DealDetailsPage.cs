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
    public class DealDetailsPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_lblPageTitle")]
        public IWebElement lblDealDetails;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_LawyerMatterNumber_txtValue")]
        public IWebElement txtFileNo;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_ddlTransactionType_ddlValue")]
        public IWebElement ddlTransactionType;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_ClosingDate_calendar_dateTextBox")]
        public IWebElement txtClosingDate;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_LawyerAppointmentDate_calendar_dateTextBox")]
        public IWebElement txtNotaryDate;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_LenderRepFirstName_txtValue")]
        public IWebElement txtAppearanceFirstName;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_LenderRepLastName_txtValue")]
        public IWebElement txtAppearanceLastName;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_LenderRepTitle_txtValue")]
        public IWebElement txtAppearanceTitle;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_lblCreditAgreementInformation")]
        public IWebElement lblCreditAgrInfo;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_TotalLoanAmount_lblTitle")]
        public IWebElement lblLoanAmount;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_TotalLoanAmount_txtValue")]
        public IWebElement txtLoanAmount;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementName_lblTitle")]
        public IWebElement lblCreditAgrName;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementName_txtValue")]
        public IWebElement txtCreditAgrName;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementDate_lblTitle")]
        public IWebElement lblCreditAgrDate;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementDate_calendar_dateTextBox")]
        public IWebElement txtCreditAgrDate;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_btnSaveTransactionDetails")]
        public IWebElement btnSave;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_btnCancelTransactionDetails")]
        public IWebElement btnCancel;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_td_0_dealContactsControl_chkSelectUnselect")]
        public IWebElement cbSelectAll;

        public void VerifyCreditFieldsEmpty(string CreditAgrInfo, string LoanAmount, string CreditAgrName, string CreditAgrDate)
        {
            Assert.True(lblCreditAgrInfo.Displayed);
            Assert.True(lblLoanAmount.Displayed);
            Assert.True(lblCreditAgrName.Displayed);
            Assert.True(lblCreditAgrDate.Displayed);
            Assert.AreEqual(lblCreditAgrInfo.Text, CreditAgrInfo);
            Assert.AreEqual(lblLoanAmount.Text, LoanAmount);
            Assert.AreEqual(lblCreditAgrName.Text, CreditAgrName);
            Assert.AreEqual(lblCreditAgrDate.Text, CreditAgrDate);

            Assert.AreEqual(txtLoanAmount.GetAttribute("value").Replace(",", ""), TotalLoanAmount);
            //Assert.True(txtLoanAmount.GetAttribute("readonly").IsNotNullOrEmpty());
            Assert.True(!txtLoanAmount.Enabled);
            Assert.AreEqual(txtCreditAgrName.Text, "");
            Assert.AreEqual(txtCreditAgrDate.Text, "");
        }

        public void VerifyCreditFieldsEmptyFR(string CreditAgrInfo, string LoanAmount, string CreditAgrName, string CreditAgrDate)
        {
            Assert.True(lblCreditAgrInfo.Displayed);
            Assert.True(lblLoanAmount.Displayed);
            Assert.True(lblCreditAgrName.Displayed);
            Assert.True(lblCreditAgrDate.Displayed);
            Assert.AreEqual(lblCreditAgrInfo.Text, CreditAgrInfo);
            Assert.AreEqual(lblLoanAmount.Text, LoanAmount);
            Assert.AreEqual(lblCreditAgrName.Text, CreditAgrName);
            Assert.AreEqual(lblCreditAgrDate.Text, CreditAgrDate);

            Assert.AreEqual(txtLoanAmount.GetAttribute("value").Replace(",", ""), TotalLoanAmount);
            //Assert.True(txtLoanAmount.GetAttribute("readonly").IsNotNullOrEmpty());
            Assert.True(!txtLoanAmount.Enabled);
            Assert.AreEqual(txtCreditAgrName.Text, "");
            Assert.AreEqual(txtCreditAgrDate.Text, "");
        }

        public void VerifyCreditFieldsData(string CreditAgrInfo, string LoanAmount, string CreditAgrName, string CreditAgrDate, string TotalLoanAmount, string CreditAgrNameVal, string CreditAgrDateVal)
        {
            Assert.True(lblCreditAgrInfo.Displayed);
            Assert.True(lblLoanAmount.Displayed);
            Assert.True(lblCreditAgrName.Displayed);
            Assert.True(lblCreditAgrDate.Displayed);
            Assert.AreEqual(lblCreditAgrInfo.Text, CreditAgrInfo);
            Assert.AreEqual(lblLoanAmount.Text, LoanAmount);
            Assert.AreEqual(lblCreditAgrName.Text, CreditAgrName);
            Assert.AreEqual(lblCreditAgrDate.Text, CreditAgrDate);

            //Assert.AreEqual(txtLoanAmount.GetAttribute("value"), TotalLoanAmount);
            Assert.AreEqual(txtLoanAmount.GetAttribute("value").Replace(",", ""), TotalLoanAmount);
            Assert.AreEqual(txtCreditAgrName.GetAttribute("value"), CreditAgrNameVal);
            Assert.AreEqual(txtCreditAgrDate.GetAttribute("value"), CreditAgrDateVal);
        }

        public void VerifySharedFieldsData(string ClosingDateUpdate)
        {
            Assert.AreEqual(txtClosingDate.GetAttribute("value"), ConvertStringDateFormat(ClosingDateUpdate, "yyyy-MM-dd", "MM/dd/yyyy"));
        }

        public void VerifyCreditFieldsUnavailable()
        {
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_lblCreditAgreementInformation"));  //lblCreditAgrInfo
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_TotalLoanAmount_lblTitle"));  //lblLoanAmount
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementName_lblTitle"));  //lblCreditAgrName
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementDate_lblTitle"));  //lblCreditAgrDate
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_TotalLoanAmount_txtValue"));  //txtLoanAmount
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementName_txtValue"));  //txtCreditAgrName
            Assert.False(UIHelper.ElementIsPresent("ctl00_mainContentPlaceHolder_td_0_MortgageCreditAgreementDate_calendar_dateTextBox"));  //txtCreditAgrDate
        }

        public void EnterCreditFieldsData(string CreditAgrNameVal, string CreditAgrDateVal)
        {
            UIHelper.SelectRandomComboElement(ddlTransactionType, "Purchase/Sale");
            UIHelper.EnterText(txtCreditAgrName, CreditAgrNameVal);
            UIHelper.EnterText(txtCreditAgrDate, CreditAgrDateVal);

            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
            Assert.AreEqual(driver.FindElement(By.Id("ctl00_mainContentPlaceHolder_lblTransactionDetailsMsg")).Text, MsgSaveSuccess);
            VerifyCreditFieldsData(CreditAgrInfo, LoanAmount, CreditAgrName, CreditAgrDate, TotalLoanAmount, CreditAgrNameVal, CreditAgrDateVal);
        }

        public void EnterTransactionDetailsData()
        {
            UIHelper.SelectRandomComboElement(ddlTransactionType, "Refinance");
            UIHelper.ClickOnLink(btnSave);
            UIHelper.WaitForPageLoad(15);
            Assert.AreEqual(driver.FindElement(By.Id("ctl00_mainContentPlaceHolder_lblTransactionDetailsMsg")).Text, MsgSaveSuccess);
        }
    }
}
