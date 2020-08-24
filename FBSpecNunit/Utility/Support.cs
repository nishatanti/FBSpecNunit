using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FBSpecNunit.Utility
{
    class Support 
    {
        private IWebDriver _driver;

        //public Support(Hooks1 _hook)
        //{
        //    _driver = _hook.Driver;
        //}

        public Support(IWebDriver driver)
        {
            _driver = driver;
        }

        public Support()
        {

        }

        public void ExplicitWaitElement(int time, IWebDriver driver, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public void ExplicitWaitElement2(int time, IWebDriver driver, By Locator)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(time));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(Locator));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(Locator));
        }



        public void Screenshot(IWebDriver driver)
        {
            Console.WriteLine("TEST FAILED");
            //ITakesScreenshot 
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot
                screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile("D://specflow project//practiceproject//FBlogin2//Screenshot//TEST.png", ScreenshotImageFormat.Png);
            //D:/specflow project/practiceproject/FBlogin2/Screenshot

        }

        public void EncodingPassword()
        {
            string password = "Welcome@123";
            var passwordInBytes = Encoding.UTF8.GetBytes(password);
            string encodedPassword = Convert.ToBase64String(passwordInBytes);
            Console.WriteLine(encodedPassword);
            //Console.WriteLine("Encoded password is : " + encodedPassword);
            //Console.ReadLine();

        }

    }
}
