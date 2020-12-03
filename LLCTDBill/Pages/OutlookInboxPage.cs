using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace LLCTDBill.Pages
{
    public class OutlookInboxPage : TestBase
    {
        [FindsBy(How = How.Id, Using = "txtS")]
        public IWebElement txtSearchMailbox;

        [FindsBy(How = How.Id, Using = "imgS")]
        public IWebElement btnSearchMailbox;

        [FindsBy(How = How.Id, Using = "divBdy")]
        public IWebElement txtEmailBody;

        public bool SearchOutlookMailbox(IWebDriver driver, string mortgageNumber, string subject)
        {
            UIHelper.EnterText(txtSearchMailbox, mortgageNumber);
            UIHelper.ClickOnLink(btnSearchMailbox);
            UIHelper.WaitForPageLoad(30);

            var mailCount = driver.FindElements(By.Id("divSubject")).Count;
            IList<IWebElement> allMaiList = driver.FindElements(By.Id("divSubject"));

            for (int i = 0; i < mailCount;)
            {
                if (allMaiList[i].Text.Contains(subject))
                {
                    return true;
                }
                else
                {
                    i++;

                    if (i == mailCount)
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public bool VerifyEmailContent(string verify)
        {
            if (txtEmailBody.Text.Contains(verify))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
