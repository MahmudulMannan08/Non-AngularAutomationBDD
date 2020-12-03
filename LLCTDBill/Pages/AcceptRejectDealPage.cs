using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace LLCTDBill.Pages
{
    public class AcceptRejectDealPage : TestBase, IPage
    {
        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_AcceptDeal1_xelFileNumber_txtValue")]
        public IWebElement txtLawyerNotaryFileNo;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_AcceptDeal1_btnAccept")]
        public IWebElement btnAccept;

        [FindsBy(How = How.Id, Using = "ctl00_leftMenu_menu_ctl01_Label10")]
        public IWebElement menubtnDeclineDeal;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_DeclineDeal1_btnSubmit")]
        public IWebElement btnSubmit;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_DeclineDeal1_txtReason")]
        public IWebElement tbReasonforDecline;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_lblPageTitle")]
        public IWebElement lblDealDetails;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_AcceptDeal1_dealContactsControl_chkSelectUnselect")]
        public IWebElement cbSelectAllEmailRec;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public void AcceptRejectDeal(string action)
        {
            if (action == "Accept")
            {
                UIHelper.EnterText(txtLawyerNotaryFileNo, UIHelper.RandomNumber(6));
                UIHelper.SetCheckbox(cbSelectAllEmailRec, "ON");
                UIHelper.ClickOnLink(btnAccept);
                Wait.Until(UIHelper.ElementHasText(lblDealDetails, "Deal Details"));
            }

            if (action == "Reject")
            {
                UIHelper.ClickOnLink(menubtnDeclineDeal);
                Wait.Until(UIHelper.ElementIsClickable(btnSubmit));
                UIHelper.EnterText(tbReasonforDecline, "Declining deal from automated script");
                UIHelper.ClickOnLink(btnSubmit);
            }
        }
    }
}
