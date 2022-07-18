using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharpNetCore
{
	public class LoginPage : DriverHelper
	{

		IWebElement txtUserName => Driver.FindElement(By.Id("UserName"));
		IWebElement txtPassword => Driver.FindElement(By.Id("Password"));
		IWebElement btnLogin => Driver.FindElement(By.XPath("//input[@value='Log in']"));

		public void EnterUserNameAndPassword(string userName, string password)
        {
			txtUserName.SendKeys(userName);
			txtPassword.SendKeys(password);

        }
		
		public void ClickLogin()
        {
			btnLogin.Click();
        }
	}
}