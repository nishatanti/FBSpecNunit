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
using TechTalk.SpecFlow.Assist;

namespace FBSpecNunit.PageObject
{
    [Binding]
    [TestFixture]
    [Parallelizable(ParallelScope.All)]

    //sealed
    public class ISW_Hotel_Steps
    { 
        private IWebDriver _driver;
        ISW_Htl_Repo isw;//= new ISW_Htl_Repo();

        Support supp = new Support();


        //ye wali additional hai for trial only
        public ISW_Hotel_Steps(IWebDriver driver)
        {
            _driver = driver;
        }

        //public ISW_Hotel_Steps(Hooks1 _hook)
        //{
        //    _driver = _hook.Driver;
        //    isw = new ISW_Htl_Repo(_driver);
        //}

        [Given(@"User is on HoMepage")]
        public void GivenUserIsOnHoMepage()
        {
            isw = new ISW_Htl_Repo(_driver);
            _driver.Navigate().GoToUrl("https://farebuzz.com");
            _driver.Manage().Window.Maximize();

           // _driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
        }

        [When(@"click on hotel tab")]
        public void GivenClickOnHotelTab()
        {
            isw = new ISW_Htl_Repo(_driver);
            isw.hoteltab();
        }

        [When(@"Enter all the details for hotel search")]
        public void WhenEnterAllTheDetailsForHotelSearch()
        {
            isw = new ISW_Htl_Repo(_driver);
            isw.hoteldest();
            isw.hotelcheckindate();
            isw.hotelcheckoutdate();
            isw.hotelroom();
            isw.hotelAdult();
            isw.hotelChild();

            //Thread.Sleep(20000);

        }

        [When(@"Click on search button of hotel")]
        public void WhenClickOnSearchButtonOfHotel()
        {
            isw = new ISW_Htl_Repo(_driver);
            isw.htlsearchbtn();
        }

        [Then(@"User navigate to hotel listing page")]
        public void ThenUserNavigateToHotelListingPage()
            {
            isw = new ISW_Htl_Repo(_driver);
            By xpath = By.XPath("//a[@title='Book Now']");
            supp.ExplicitWaitElement2(30,_driver,xpath);
           //Assert.That(driver.PageSource.Contains"BookNow"),Is.EqualTo(True),"The text BookNow doesnot exist");
            //driver.Close();
            //driver.Quit();
        }
      }
}
