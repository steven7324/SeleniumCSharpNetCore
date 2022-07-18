using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharpNetCore
{
	public class CustomControl : DriverHelper
	{
		public static void ComboBox(string controlName, string value)
		{
			var comboBox = Driver.FindElement(By.Id("ContentPlaceHolder1_AllMealsCombo-awed"));

			comboBox.Clear();
			comboBox.SendKeys("Almond");

			ExpectedConditions.ElementToBeClickable(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']"));
			IWebElement comboBoxValues = Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']"));
			comboBoxValues.Click();

		}
	}
}
