using FBSpecNunit.Steps;
using FBSpecNunit.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FBSpecNunit.PageObject
{
    [Binding]
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
        ////sealed
    public  class LoginSteps 
    {
        Support supp = new Support();
        private IWebDriver _driver;
        loginRepo lrepo  ;

        //public LoginSteps(Hooks1 _hook)
        //{
        //    _driver = _hook.Driver;
        //    lrepo = new loginRepo(_driver);
        //}

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"User should be on homepage")]
        public void GivenUserShouldBeOnHomepage()
        {
            try
            {
                lrepo = new loginRepo(_driver);
                _driver.Navigate().GoToUrl("https://www.farebuzz.com");
                _driver.Manage().Window.Maximize();
                lrepo.signinlink();
            }
            catch (Exception)
            {
                supp.Screenshot(_driver);
            }
        }

        [Given(@"Enter username and password")]
        public void GivenEnterUsernameAndPassword()
        {
            try
            {
                lrepo = new loginRepo(_driver);
                lrepo.userid();
                lrepo.password();

            }
            catch (Exception)
            {
                supp.Screenshot(_driver);
            }
        }

        [When(@"Click on SignIn button")]
        public void WhenClickOnSignInButton()
        {
            try
            {
                lrepo = new loginRepo(_driver);
                lrepo.signinbtn();
            }
            catch (Exception )
            {
                supp.Screenshot(_driver);
            }
        }

        [Then(@"User is sucessfully login")]
        public void ThenUserIsSucessfullyLogin()
        {
            try
            {
                lrepo = new loginRepo(_driver);
                lrepo.loginmenu();
            }
            catch (Exception )
            {
                supp.Screenshot(_driver);
            }
        }


        [When(@"Click on Travelagent tab")]
        public void WhenClickOnTravelagentTab()
        {
            lrepo = new loginRepo(_driver);
            lrepo.travelagenttab();
        }


        [When(@"Enter Username and Password")]
        public void WhenEnterUsernameAndPassword(Table table)
        {
            
            dynamic data = table.CreateDynamicInstance();
            lrepo.UserNameT((string)data.UserName);
            lrepo.PasswordT((string)data.Password);
        }
        
            

       [When(@"Click on btob SignIn button")]
        public void WhenClickOnBtobSignInButton()
        {
            lrepo.loginbutton();
        }

        [Then(@"User is sucessfully login for btob")]
        public void ThenUserIsSucessfullyLoginForBtob()
        {
            try
            {
                lrepo.loginmenu();
            }
            catch (Exception)
            {
                supp.Screenshot(_driver);
            }
        }


    }
}
