using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
//using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;

namespace LLCTDBill.Pages
{
    public class HomePage : TestBase, IPage
    {
        public static MenuPage menuPage;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_mnuHome_ctl00_Label101")]
        public IWebElement lnkDealstoAccept;

        [FindsBy(How = How.LinkText, Using = "Closing")]
        public IWebElement lnkClosing;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_grdNew_grdDealSummary")]
        public IWebElement tbDealstoAccept;

        [FindsBy(How = How.Id, Using = "ctl00_ltrTitle")]
        public IWebElement lblHome;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_searchBox_ddlSearchOption")]
        public IWebElement ddlSearchFilter;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_searchBox_QuickSearch")]
        public IWebElement txtSearch;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_searchBox_btnSearch")]
        public IWebElement btnSearch;

        [FindsBy(How = How.Id, Using = "ctl00_mainContentPlaceHolder_grdAccepted_grdDealSummary")]
        public IWebElement tbDealSummary;

        public string Url
        {
            get
            {
                return "";
            }
        }

        public void SearchPendingDeal(string LRNNo)
        {
            UIHelper.ClickOnLink(lnkDealstoAccept);
            UIHelper.ClickOnLink(lnkClosing);
            //Thread.Sleep(1500);
            UIHelper.WaitForPageLoad(10);
            UIHelper.ClickOnLink(lnkClosing);
            Thread.Sleep(2500);
            //UIHelper.WaitForPageLoad(10);
            UIHelper.SearchGridAndVerify(driver, tbDealstoAccept, LRNNo, 3);
            //tbDealstoAccept.FindElements(By.TagName("tr"))[4].FindElements(By.TagName("td"))[0].Click();
            UIHelper.WaitForPageLoad(30);
        }

        public void SearchDeal(string FCTURN)
        {
            UIHelper.ClickOnLink(ddlSearchFilter);
            UIHelper.SelectRandomComboElement(ddlSearchFilter, "Lender Reference Number");
            UIHelper.EnterText(txtSearch, FCTURN);
            UIHelper.ClickOnLink(btnSearch);
            UIHelper.WaitForPageLoad(30);
        }

        public void VerifyRedirectionToHomepage(string Menu)
        {
            menuPage = UIHelper.PageInit<MenuPage>(driver);
            menuPage.LeftMenuNavigate(Menu);
            Assert.True(driver.FindElement(By.Id("ctl00_ltrTitle")).Text.Equals("Home"));
        }

        public void VerifyDealAmendmentIcon(string LenderRefNo)
        {
            var itemCount = tbDealSummary.FindElements(By.TagName("tr")).Count();
            IList<IWebElement> allOptions = tbDealSummary.FindElements(By.TagName("tr"));
            IList<IWebElement> OptionParts = allOptions[1].FindElements(By.TagName("td"));

            if (OptionParts[0].Text.Contains("No records matching your search criteria were found. Please modify your search parameters and try again or try using Advanced Search."))
            {
                Console.WriteLine("No such deals available");
            }

            else
            {
                for (int i = 1; i < itemCount; )
                {
                    IList<IWebElement> Columns = allOptions[i].FindElements(By.TagName("td"));
                    if (Columns[4].Text.Contains(LenderRefNo))
                    {
                        IWebElement linkElement = Columns[0].FindElement(By.TagName("img"));
                        Assert.True(linkElement.Displayed);
                        //Assert.True(linkElement.GetAttribute("src").Equals("Images/LLC_amendment_icon.gif"));
                        UIHelper.ClickOnLink(linkElement);
                        UIHelper.WaitForPageLoad(45);
                        break;
                    }
                    else
                    {
                        i++;
                    }

                    if (i == itemCount)
                    {
                        Console.WriteLine("Could not find the deal");
                    }
                }
            }
        }
    }
}
