using NUnit.Framework;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumStart.Pages
{
    class InstancePage
    {
        IWebDriver driver;

        public InstancePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "")]
        private IWebElement inputLogin;

        private void fillFirstInstancePage()
        {
            inputLogin.Click();
        }
    }
}
