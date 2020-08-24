
using FBSpecNunit.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FBSpecNunit.Steps
{
    class GmailRepo
    {
        private IWebDriver _driver;
        Support supp = new Support();

        public GmailRepo(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/section/div/div[2]/section/div")]

        public IWebElement SelectLanguage { get; set; }
        public void Language()
        {
            SelectLanguage.Click();
            
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/section/div/div[2]/section/div/ul/li/div[3]/a")]

        public IWebElement SelectEnglish { get; set; }
        public void EnglishLanguage()
        {
            SelectEnglish.Click();
            //SelectLanguage.SendKeys("English");
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/section/div/div[2]/section/div/ul/li/div[4]/a/div")]

        public IWebElement SelectDutch { get; set; }
        public void DutchLanguage()
        {
            SelectDutch.Click();
            //SelectLanguage.SendKeys("English");
        }

        public void languageddl()
        {
            SelectElement dropdown = new SelectElement(_driver.FindElement(By.Id("language")));
            dropdown.SelectByIndex(-1);
        }

        //id=name
        //id=orgName
        //id=singUpEmail
        //class=ui-checkbox
        // //label[@class="ui-checkbox"]
        //button[@type="submit"]

        [FindsBy(How = How.Id, Using = "name")]

        public IWebElement EnterName { get; set; }
        public void Name()
        {
            EnterName.SendKeys("Nisha");
        }

        [FindsBy(How = How.Id, Using = "orgName")]

        public IWebElement EnterOrg { get; set; }
        public void OrgName()
        {
            EnterOrg.SendKeys("Nisha");
        }

        [FindsBy(How = How.Id, Using = "singUpEmail")]

        public IWebElement Enteremail { get; set; }
        public void Email()
        {
            Enteremail.SendKeys("sharma.aditi95@yahoo.com");
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[3]/div/section/div[1]/form/fieldset/div[4]/label/span")]

        public IWebElement SelectCheckbox { get; set; }
        public void IAgree()
        {
            try { SelectCheckbox.Click(); }
            catch (Exception) { SelectCheckbox.Click(); Console.WriteLine("Error"); }
            
        }

        
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[3]/div/section/div[1]/form/fieldset/div[5]/button")]
        
        public IWebElement ClickGetStared { get; set; }
        public void ClickSubmit()
        { 
            ClickGetStared.Click();
        }



        //Get text from an element:

        public void getElementText(By locator)
        {
            String emaildb = _driver.FindElement(By.Id("//input[@id='mail']")).Text;
            Console.WriteLine(emaildb);
        
        
        //Enter text to a field:

        //public void enterTextIntoField(String text, By locator)
        
            IWebElement locatorElement = _driver.FindElement(By.Id("singUpEmail"));
            locatorElement.Click();
            //locatorElement.Clear();
            locatorElement.SendKeys(emaildb);
        }

        public void switchToTab()
        {
            //Switching between tabs using CTRL + tab keys.
            _driver.FindElement(By.CssSelector("body")).SendKeys(Keys.Control + "\t");
            //Switch to current selected tab's content.
            _driver.SwitchTo().DefaultContent();
        }

        [FindsBy(How = How.Id, Using = "login-username")]

        public IWebElement Yahoouser { get; set; }
        public void yahoouname()
        {
            Yahoouser.SendKeys("sharma.aditi95@yahoo.com");
        }

        [FindsBy(How = How.Id, Using = "login-signin")]

        public IWebElement Usernxtbtn { get; set; }
        public void usernxtbtn()
        {
            Usernxtbtn.Click();
        }

        [FindsBy(How = How.Id, Using = "login-passwd")]

        public IWebElement Yahoopwd { get; set; }
        public void yahoopwd()
        {
            //supp.EncodingPassword();
            //Yahoopwd.SendKeys("encodedPassword");
            Yahoopwd.SendKeys("Welcome@123");
            //V2VsY29tZUAxMjM =
        }

        [FindsBy(How = How.Name, Using = "verifyPassword")]

        public IWebElement VerifyPwd { get; set; }
        public void Pwdnxtbtn()
        {
            VerifyPwd.Click();
        }


    }
}
