using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Text;

namespace FBSpecNunit
{
    public class Tests
    {
        //IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            //start_Browser
            {
            }
        }

        [Test]
        public void EncodingPassword()
        {
            //Assert.Pass();
            string password = "Welcome@123";
            var passwordInBytes = Encoding.UTF8.GetBytes(password);
            string encodedPassword = Convert.ToBase64String(passwordInBytes);
            Console.WriteLine("Encoded password is : " + encodedPassword);
            Console.ReadLine();
            //var encodedPasswordInVytes = Convert.F
        }


    }
}