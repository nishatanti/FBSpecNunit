using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FBSpecNunit.Steps
{
    class ISW_Htl_Repo 
    {
		private IWebDriver _driver;

        public ISW_Htl_Repo(IWebDriver driver)
        {
			this._driver = driver;
			PageFactory.InitElements(driver, this);
        }
	
		[FindsBy(How =How.XPath,Using = "//li[@id='li2']")]

		public IWebElement Click_Hoteltab { get; set; }
		public void hoteltab()
        {
			Click_Hoteltab.Click();
        }

		[FindsBy(How = How.Id, Using = "txtHotDest")]

		public IWebElement Enter_Hotel_Destination { get; set; }
		public void hoteldest()
		{
			//Enter_Hotel_Destination.SendKeys(destination);
			Enter_Hotel_Destination.SendKeys("LAX");
			Thread.Sleep(5000);
			Enter_Hotel_Destination.SendKeys(Keys.Tab);
		}

		[FindsBy(How = How.Id, Using = "txtHotInDate")]

		public IWebElement Enter_Htl_CheckIn { get; set; }
		public void hotelcheckindate()
		{
			//Enter_Htl_CheckIn.Click();
			//Enter_Htl_CheckIn.SendKeys(checkin);
			Enter_Htl_CheckIn.SendKeys("8/24/2020");
		}

		[FindsBy(How = How.Id, Using = "txtHotOutDate")]

		public IWebElement Enter_Htl_CheckOut { get; set; }
		public void hotelcheckoutdate()
		{
			Enter_Htl_CheckOut.Clear();
			Enter_Htl_CheckOut.SendKeys("8/30/2020");
		

		}
		[FindsBy(How = How.Id, Using = "ddlHotelRooms")]

		public IWebElement Enter_Room { get; set; }
		public void hotelroom()
		{
			Enter_Room.Click();
			Enter_Room.SendKeys("1");
			Enter_Room.SendKeys(Keys.Tab);
		}

		[FindsBy(How = How.Id, Using = "ddlHotR1Adults")]

		public IWebElement Enter_Adult { get; set; }
		public void hotelAdult()
		{
			Enter_Adult.Click();
			Enter_Adult.SendKeys("1");
			
		}

		[FindsBy(How = How.Id, Using = "ddlHotR1Children")]

		public IWebElement Enter_Child { get; set; }
		public void hotelChild()
		{
			Enter_Child.Click();
			Enter_Child.SendKeys("1");
			Enter_Child.SendKeys(Keys.Tab);
			//Enter_Child.SendKeys(Keys.Tab);
			//Enter_Child.SendKeys(Keys.Tab);
			//Enter_Child.SendKeys(Keys.Tab);
			//Enter_Child.SendKeys(Keys.Tab);
			
		}

		[FindsBy(How = How.XPath, Using = "//button[@onclick=' searchHot()']")]

		public IWebElement Click_htlsearchbtn { get; set; }
		public void htlsearchbtn()
        {
			try
			{
				Click_htlsearchbtn.Click();
				Console.WriteLine("hi");
			}
			catch (Exception)
            {
				Click_htlsearchbtn.Click();
			}
		}

	}
}
