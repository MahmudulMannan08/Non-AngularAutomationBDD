using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LLCTDBill.Pages
{
    public class OutlookLoginPage : TestBase, IPage
    {
        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement txtUserName;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement txtPassword;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit'][@value='Sign in']")]
        public IWebElement btnSignIn;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public void LogintoOutlook(string username, string password)
        {
            Thread.Sleep(30000);
            UIHelper.EnterText(txtUserName, username);
            UIHelper.EnterText(txtPassword, password);
            UIHelper.ClickOnLink(btnSignIn);
            UIHelper.WaitForPageLoad(30);
        }
    }
}
