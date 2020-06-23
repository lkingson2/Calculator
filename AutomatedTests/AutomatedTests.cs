using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomatedTests
{
    public class AutomatedTests : IDisposable
    {
        private readonly IWebDriver _driver;
        private readonly CalculatorPage _page;
        public AutomatedTests()
        {
            _driver = new ChromeDriver();
            _page = new CalculatorPage(_driver);
            _page.Navigate();
        }


        [Fact]
        public void Test_Addition_UI()
        {
            _page.PopulateNumberA("15");
            _page.PopulateNumberB("15");
            _page.ChooseOperation("Multiplication");
            _page.ClickSubmit();

            Assert.Equal("225", _page.GetResult());
        }

        public void Dispose()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}
