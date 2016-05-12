using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;


namespace SeleniumStart.Steps
{
    class InstanceSteps
    {
        IWebDriver driver;
        public void InitBrowser()
        {
           driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser(int time)
        {
            Console.WriteLine("Browser will be closed in " + time + " seconds. Thanks for your patience");            
            Driver.DriverInstance.GetInstance().Dispose();
        }

        public void firstTestingMethod()
        {
            Pages.InstancePage instantPage = new Pages.InstancePage(driver);


        }
    }
}
