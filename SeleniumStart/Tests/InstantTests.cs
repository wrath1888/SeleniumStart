using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace SeleniumStart.Tests
{
    class InstantTests
    {
        private Steps.InstanceSteps steps = new Steps.InstanceSteps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            //steps.CloseBrowser();
        }
    }
}
