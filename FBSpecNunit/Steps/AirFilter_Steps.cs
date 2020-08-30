using FBSpecNunit.PageObject;
using FBSpecNunit.Utility;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace FBSpecNunit.Steps
{
    [Binding]
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public class AirFilter_Steps
    {
        private IWebDriver _driver;

        AirFilters_Repo airfilter ;
        Support supp = new Support();

        public AirFilter_Steps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"User is On HomePage")]
        public void GivenUserIsOnHomePage()
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("Https://www.farebuzz.com");
            _driver.Manage().Window.Maximize();
        }

        [Given(@"Enter all the details of ISW")]
        public void GivenEnterAllTheDetailsOfISW(Table table)
        {
            airfilter = new AirFilters_Repo(_driver);
            dynamic data = table.CreateDynamicInstance();
            airfilter.entersource((string)data.Source);
            airfilter.enterdestination((string)data.Destination);
            airfilter.enterdeptdate((DateTime)data.DeptDate);
            airfilter.enterretdate((DateTime)data.ReturnDate);
            airfilter.enteradult((int)data.Adult);
            airfilter.enterClass((string)data.Class);           
        }

        [Given(@"Click on search button")]
        public void GivenClickOnSearchButton()
        {
            airfilter = new AirFilters_Repo(_driver);
            airfilter.clickbtn();
        }

        [Given(@"User is navigated to listing page")]
        public void GivenUserIsNavigatedToListingPage()
        {
            airfilter = new AirFilters_Repo(_driver);
            airfilter.selectbutton();
        }

        [When(@"Click on going slider from left")]
        public void WhenClickOnGoingSliderFromLeft()
        {
            airfilter = new AirFilters_Repo(_driver);
            airfilter.GoingSlider();
        }

        [Then(@"Slider selected time will appear in the contract")]
        public void ThenSliderSelectedTimeWillAppearInTheContract()
        {
            airfilter = new AirFilters_Repo(_driver);
            airfilter.display_flighttime();
        }

    }
}
