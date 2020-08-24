using FBSpecNunit.Steps;
using FBSpecNunit.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace FBSpecNunit.PageObject
{
    [Binding]
    public  class gmailSteps
    {
        private IWebDriver _driver;
        GmailRepo gmailr;
        String tempemail = null;

        Support supp = new Support();

        public gmailSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"User is on Signup Page")]
        public void GivenUserIsOnSignupPage()
        {
            gmailr = new GmailRepo(_driver);
            _driver.Navigate().GoToUrl("http://jt-dev.azurewebsites.net/#/SignUp");
            //_driver.Manage().Window.Maximize();

        }

        [Given(@"Select language from dropdown")]
        public void GivenSelectLanguageFromDropdown()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.Language();
            gmailr.EnglishLanguage();

        }

        [When(@"Enter name and organisation")]
        public void WhenEnterNameAndOrganisation()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.Name();
            gmailr.OrgName();
        }

        [When(@"Enter email address")]
        public void WhenEnterEmailAddress()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.Email();
        }

        [When(@"Click on I agree option")]
        public void WhenClickOnIAgreeOption()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.IAgree();
        }

        [When(@"Click  on signup button")]
        public void WhenClickOnSignupButton()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.ClickSubmit();
        }

        [Then(@"A validation message appear on the page")]
        public void ThenAValidationMessageAppearOnThePage()
        {
            //div[@class='alert alert-danger alert-custom']
            Boolean Display=_driver.FindElement(By.XPath("//*[@id='content']/div/div[3]/div/section/div[1]/form/div")).Displayed;
            Console.WriteLine("Element displayed is :" + Display);
        }

        [When(@"Click on language dropdown")]
        public void WhenClickOnLanguageDropdown()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.Language();
        }

        [When(@"Select Dutch language from dropdown")]
        public void WhenSelectDutchLanguageFromDropdown()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.DutchLanguage();
        }

        [Then(@"All the details of page comes in dutch language")]
        public void ThenAllTheDetailsOfPageComesInDutchLanguage()
        {
            Boolean Display = _driver.FindElement(By.XPath("/html/body/div[1]/div[2]/section/div/div[3]/div/section/div[1]")).Displayed;
            Console.WriteLine("Element displayed is :" + Display);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [When(@"Select English language from dropdown")]
        public void WhenSelectEnglishLanguageFromDropdown()
        {
            gmailr.EnglishLanguage();
        }

        [Then(@"All the details of page comes in English language")]
        public void ThenAllTheDetailsOfPageComesInEnglishLanguage()
        {
            
            Boolean Display = _driver.FindElement(By.XPath("//*[@id='content']/div/div[3]/div/section/div[1]")).Displayed;
            Console.WriteLine("Element displayed is :" + Display);
            _driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(5);
           
        }

        [Given(@"User is on Gmail Page")]
        public void GivenUserIsOnGmailPage()
        {
            gmailr = new GmailRepo(_driver);
            // _driver.Navigate().GoToUrl("https://accounts.google.com/signin/v2/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&service=mail&sacu=1&rip=1&flowName=GlifWebSignIn&flowEntry=ServiceLogin");
            _driver.Navigate().GoToUrl("https://accounts.google.com/signin");
            //_driver.Manage().Window.Maximize();
        }

       

        [Then(@"jabatalk mail should be display in inbox")]
        public void ThenJabatalkMailShouldBeDisplayInInbox()
        {
            Console.WriteLine(  "hello");
        }

        [Given(@"User is on Email Page")]
        public void GivenUserIsOnEmailPage()
        {
            gmailr = new GmailRepo(_driver);
            _driver.Navigate().GoToUrl("https://temp-mail.org/en/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }

        [When(@"search for jabatalks keyword")]
        public void WhenSearchForJabatalksKeyword()
        {
            gmailr = new GmailRepo(_driver);
            Assert.That(_driver.PageSource.Contains("Jabatalks"),Is.EqualTo(true),"The text jabatalks doesnot exist");
        }

        [Then(@"Inbox should display result of search")]
        public void ThenInboxShouldDisplayResultOfSearch()
        {
            gmailr = new GmailRepo(_driver);
            supp.Screenshot(_driver);
        }


        

        [Given(@"copy email address")]
        public void GivenCopyEmailAddress()
        {
           //IWebElement tempemail = _driver.FindElement(By.XPath("//input[@id='mail']"));
            tempemail = _driver.FindElement(By.Id("/html/body/div[2]/div/div/div[2]/div[1]/form/div[1]/div/input")).Text;
            Console.WriteLine(tempemail);
        }

        [Given(@"User is on Signup Page one")]
        public void GivenUserIsOnSignupPageOne()
        {
             gmailr = new GmailRepo(_driver);
            _driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "t");
            _driver.Navigate().GoToUrl("http://jt-dev.azurewebsites.net/#/SignUp");
        }

        [When(@"Enter email address one")]
        public void WhenEnterEmailAddressOne()
        {
            IWebElement locatorElement = _driver.FindElement(By.Id("singUpEmail"));
            locatorElement.Click();
            //locatorElement.Clear();
            locatorElement.SendKeys(tempemail);
        }


        [Then(@"Move to Email page")]
        public void ThenMoveToEmailPage()
        {
            gmailr.switchToTab();
            Thread.Sleep(5000);
        }

        [Given(@"User is on yahoomail page")]
        public void GivenUserIsOnYahoomailPage()
        {
            gmailr = new GmailRepo(_driver);
            _driver.Navigate().GoToUrl("https://login.yahoo.com/");
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
        }

        [When(@"Enter username and passwordd")]
        public void WhenEnterUsernameAndPasswordd()
        {
            gmailr = new GmailRepo(_driver);
           
            gmailr.yahoouname();
            gmailr.usernxtbtn();
            gmailr.yahoopwd();
            
        }

        [When(@"click next btn")]
        public void WhenClickNextBtn()
        {
            gmailr = new GmailRepo(_driver);
            gmailr.Pwdnxtbtn();
            Thread.Sleep(5000);
            By xpath = By.Id("header-mail-button");
            supp.ExplicitWaitElement2(15, _driver, xpath);
            _driver.FindElement(By.Id("header-mail-button")).Click();
           
        }

        [Then(@"Yahoomail is open sucessfully")]
        public void ThenYahoomailIsOpenSucessfully()
        {
            gmailr = new GmailRepo(_driver);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Boolean Display = _driver.FindElement(By.XPath("//input[@id='ybarAccountMenu']")).Displayed;
            Console.WriteLine("Element displayed is :" + Display);
           
        }


    }
}
