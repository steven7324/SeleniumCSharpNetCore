using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharpNetCore
{
	public class HomePage : DriverHelper
	{
		IWebElement lnkLogin => Driver.FindElement(By.Id("loginLink"));
		IWebElement lnkLogOff => Driver.FindElement(By.XPath("//a[text()='Log off']"));
		public void ClickLogin() => lnkLogin.Click();

		public bool IsLogOffExist() => lnkLogOff.Displayed;


	}
}