using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace FBSpecNunit.Utility
{
    [Binding]
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
   //sealed removed
    public class Hooks1 
    {

        //IWebDriver driver;
        
        private readonly IObjectContainer _objectcontainer;

        private IWebDriver _driver;

        public Hooks1(IObjectContainer objectcontainer)
        {
            _objectcontainer = objectcontainer;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
               

                Console.WriteLine("LAUNCH URL");
                _driver = new ChromeDriver();
                _objectcontainer.RegisterInstanceAs<IWebDriver>(_driver);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("TEST PASS");
            _driver.Close();
            _driver.Quit();
        }
        public IWebDriver Driver => _driver;
    }
}
