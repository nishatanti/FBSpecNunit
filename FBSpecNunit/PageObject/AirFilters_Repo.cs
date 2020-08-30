using FBSpecNunit.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FBSpecNunit.PageObject
{
    class AirFilters_Repo
    {
        private IWebDriver _driver;

        Support supp = new Support();
        //Constructor

        public AirFilters_Repo(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            this._driver = driver;
        }

        [FindsBy(How = How.CssSelector, Using = "#txtAirFrom")]
        public IWebElement txtSource { get; set; }

        public void entersource(string source )
        {
            txtSource.SendKeys(source);
        }

        [FindsBy(How = How.CssSelector,Using = "#txtAirTo")]

        public IWebElement txtDestination { get; set; }
        public void enterdestination (string destination)
        {
            txtDestination.SendKeys(destination);
            txtDestination.SendKeys(Keys.Tab);
        }

        [FindsBy(How = How.Id, Using = "txtAirDepDate")]

        public IWebElement txtDeptDate { get; set; }
        public void enterdeptdate(DateTime deptdate)
        {
            txtDeptDate.Click();
            txtDeptDate.Clear();
            txtDeptDate.SendKeys("09/20/2020");
        }

        [FindsBy(How = How.Id, Using = "txtAirRetDate")]

        public IWebElement txtRetDate { get; set; }
        public void enterretdate(DateTime retndate)
        {
            txtRetDate.Clear();
            txtRetDate.SendKeys("09/25/2020");
            //retndate.Add(10)
            txtRetDate.SendKeys(Keys.Tab);
        }

        [FindsBy(How = How.Id, Using = "ddlAirAdults")]

        public IWebElement ddlAdults { get; set; }
        public void enteradult(int adult)
        {
            ddlAdults.Click();
            ddlAdults.SendKeys("2");
        }

        [FindsBy(How = How.Id, Using = "ddlAirClass")]

        public IWebElement ddlClass { get; set; }
        public void enterClass(string Class)
        {
            ddlClass.SendKeys(Class);
        }

        [FindsBy(How = How.CssSelector, Using = "#div1 > div.btn-main > div > button")]


        public IWebElement btnSearch { get; set; }
        public void clickbtn()
        {
            btnSearch.Click();
        }

        public void GoingSlider() 
        {

            IWebElement slider1 = _driver.FindElement(By.CssSelector("#DivDepart > div > div > div.slider-track > div:nth-child(2)"));
            Actions move = new Actions(_driver);
            move.DragAndDropToOffset(slider1, 90, 0);
            //move.MoveToElement(slider1, 90, 0);
            move.Build().Perform();
            Thread.Sleep(5000);
	    }

       
        //public void display_flighttime()
        //{
            
        //    Boolean Display = _driver.FindElement(By.XPath("(//time[@class='airport__time'])[1]")).Displayed;
        //    Console.WriteLine("Element displayed is :" + Display);
        //}

        [FindsBy(How = How.XPath, Using = "(//time[@class='airport__time'])[1]")]

        public IWebElement Showflighttime { get; set; }
        public void display_flighttime()
        {
            supp.ExplicitWaitElement(10, _driver, Showflighttime);
            Assert.IsTrue(Showflighttime.Displayed);

        }

        [FindsBy(How = How.XPath, Using = "//button[@class='cta-1st select__cta']")]

        public IWebElement ShowButton { get; set; }
        public void selectbutton()
        {
            supp.ExplicitWaitElement(40, _driver, ShowButton);
            Assert.IsTrue(ShowButton.Displayed);
        }


    }
}
