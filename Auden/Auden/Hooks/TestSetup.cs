using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using BoDi;
using Auden.WebDriver;
using OpenQA.Selenium;
using NUnit.Framework;
using Auden.Config;

namespace Auden.Hooks
{

    [Binding]
    public class TestSetup
    {

        private readonly IObjectContainer _objectContainer;

        public TestSetup(IObjectContainer objectContainer)
        {
            this._objectContainer = objectContainer;
        }



        [AfterTestRun]
        public static void LogTestRunInformationEnd()
        {
        }

        [BeforeScenario]
        public void InitialiseTest()
        {
            WebDriverFactory factory = new WebDriverFactory();
            IWebDriver driver = factory.Create(BrowserType.Chrome);
            driver.Manage().Window.Maximize();
            _objectContainer.RegisterInstanceAs<IWebDriver>(driver);

            User user = new User();
            user.driver = driver;

            _objectContainer.RegisterInstanceAs<User>(user);
        }


        [AfterScenario]
        public void TearDown(IWebDriver driver)
        {

             driver.Close();
             driver.Quit();
        }

    }

}