using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace LLCTDBill.Pages
{
    public class LoginPage : TestBase, IPage
    {
        [FindsBy(How = How.Id, Using = "dataUserName")]
        public IWebElement txtLoginId;

        [FindsBy(How = How.Id, Using = "dataPassword")]
        public IWebElement txtPassword;

        [FindsBy(How = How.Id, Using = "btnSignIn")]
        public IWebElement btnLogin;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_mnuHome_ctl00_Label101")]
        public IWebElement lnkDealstoAccept;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public void LoginToLawyerPortal(string username, string password)
        {
            UIHelper.EnterText(txtLoginId, username);
            UIHelper.EnterText(txtPassword, password);
            UIHelper.ClickOnLink(btnLogin);
            UIHelper.WaitForPageLoad(40);
            Wait.Until(UIHelper.ElementIsClickable(lnkDealstoAccept));
        }
    }
}
