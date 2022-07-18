using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharpNetCore
{
	public class Tests : DriverHelper
	{
		[SetUp]
		public void Setup()
		{
			Console.WriteLine("Setup");

			Driver = new ChromeDriver();
			
		}

		[Test]
		public void Test1()
		{
			//Driver.Navigate().GoToUrl("https://www.executeautomation.com/");
			Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

			var autoComplete = Driver.FindElement(By.Id("ContentPlaceHolder1_Meal"));
			autoComplete.SendKeys("Tomato");
			
			autoComplete.SendKeys(Keys.Enter);

			var checkBox = Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']"));
			checkBox.Click();

			CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");

			Console.WriteLine("Test1");
			Assert.Pass();
		}

		[Test]
		public void LoginTest()
        {
			Driver.Navigate().GoToUrl("http://eaapp.somee.com/");

			HomePage homePage = new HomePage();
			LoginPage loginPage = new LoginPage();

			homePage.ClickLogin();
			loginPage.EnterUserNameAndPassword("admin", "password");
			loginPage.ClickLogin();
			Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button did not displayed");

		}
	}
}