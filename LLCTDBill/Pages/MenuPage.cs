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
    public class MenuPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl00_Label10")]
        public IWebElement btnDealDetails;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl01_Label10")]
        public IWebElement btnOrderTitleIns;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl02_Label10")]
        public IWebElement btnManageDoc;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl03_Label10")]
        public IWebElement btnPostNote;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl04_Label10")]
        public IWebElement btnRequestFunds;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl05_Label10")]
        public IWebElement btnRequestCancel;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl06_Label10")]
        public IWebElement btnFinalReport;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl07_Label10")]
        public IWebElement btnSubmitToLender;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_HyperLink9")]
        public IWebElement btnViewNotes;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_hlkDealHistory")]
        public IWebElement btnViewDealHistory;

        [FindsBy(How = How.Id, Using = "ctl00_topMenu_TopRightMenu1_mnuTopMenun0")]
        public IWebElement btnHome;

        [FindsBy(How = How.Id, Using = "ctl00_topMenu_TopRightMenu1_mnuTopMenun1")]
        public IWebElement btnMyProfile;

        [FindsBy(How = How.Id, Using = "ctl00_topMenu_TopRightMenu1_mnuTopMenun2")]
        public IWebElement btnContactUs;

        [FindsBy(How = How.Id, Using = "ctl00_topMenu_TopRightMenu1_mnuTopMenun3")]
        public IWebElement btnHelp;

        [FindsBy(How = How.Id, Using = "ctl00_topMenu_TopRightMenu1_lnkBtnLanguage")]
        public IWebElement btnLanguage;

        [FindsBy(How = How.Id, Using = "ctl00_topMenu_TopRightMenu1_lnkBtnSignOut")]
        public IWebElement btnSignOut;

        public void LeftMenuNavigate(string Menu)
        {
            switch (Menu)
            {
                case "Deal Details":
                    UIHelper.ClickOnLink(btnDealDetails);
                    break;
                case "Order Title Insurance":
                    UIHelper.ClickOnLink(btnOrderTitleIns);
                    break;
                case "Manage Documents":
                    UIHelper.ClickOnLink(btnManageDoc);
                    break;
                case "Post a Note":
                    UIHelper.ClickOnLink(btnPostNote);
                    break;
                case "Request for Funds":
                    UIHelper.ClickOnLink(btnRequestFunds);
                    break;
                case "Request a Cancellation":
                    UIHelper.ClickOnLink(btnRequestCancel);
                    break;
                case "Final Report":
                    UIHelper.ClickOnLink(btnFinalReport);
                    break;
                case "Submit to Lender":
                    UIHelper.ClickOnLink(btnSubmitToLender);
                    break;
                case "View Notes":
                    UIHelper.ClickOnLink(btnViewNotes);
                    break;
                case "View Deal History":
                    UIHelper.ClickOnLink(btnViewDealHistory);
                    break;
            }

            UIHelper.WaitForPageLoad(45);
        }

        public void TopMenuNavigate(string Menu)
        {
            switch (Menu)
            {
                case "Home":
                    UIHelper.ClickOnLink(btnHome);
                    break;
                case "My Profile":
                    UIHelper.ClickOnLink(btnMyProfile);
                    break;
                case "Contact Us":
                    UIHelper.ClickOnLink(btnContactUs);
                    break;
                case "Help":
                    UIHelper.ClickOnLink(btnHelp);
                    break;
                case "Français":
                    if (btnLanguage.Text == "Français")
                    {
                        UIHelper.ClickOnLink(btnLanguage);
                    }
                    break;
                case "English":
                    if (btnLanguage.Text == "English")
                    {
                        UIHelper.ClickOnLink(btnLanguage);
                    }
                    break;
                case "Sign Out":
                    UIHelper.ClickOnLink(btnSignOut);
                    break;
            }

            UIHelper.WaitForPageLoad(45);
        }
    }
}
