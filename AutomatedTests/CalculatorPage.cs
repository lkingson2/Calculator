using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace AutomatedTests
{
    public class CalculatorPage
    {
        private readonly IWebDriver _driver;
        private const string URI = "https://localhost:5001";

        private IWebElement NumberA => _driver.FindElement(By.Id("number-a"));
        private IWebElement NumberB => _driver.FindElement(By.Id("number-b"));
        private SelectElement OperationList => new SelectElement(_driver.FindElement(By.Id("operation")));
        private IWebElement Result => _driver.FindElement(By.Id("result"));
        private IWebElement Submit => _driver.FindElement(By.Id("submit"));

        public string Title => _driver.Title;
        public string Source => _driver.PageSource;

        public CalculatorPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate() => _driver.Navigate()
                .GoToUrl(URI);

        public void PopulateNumberA(String number) => NumberA.SendKeys(number);
        public void PopulateNumberB(String number) => NumberB.SendKeys(number);
        public void ChooseOperation(String operation) => OperationList.SelectByText(operation);
        public String GetResult() => Result.GetAttribute("value");
        public void ClickSubmit() => Submit.Click();
    }
}
