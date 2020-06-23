using System;
using Xunit;
using Calculator.Models;
using Calculator.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace UnitTests
{
    public class UnitTest
    {
        [Fact]
        public void TestAddition()
        {
            CalculatorModel test = new CalculatorModel();
            HomeController hc = new HomeController();
            test.NumberA = 10;
            test.NumberB = 25;
            test.operation = Operation.Addition;
            var result = hc.Index(test) as ViewResult;
            var model = result.Model as CalculatorModel;
            Assert.Equal(35, model.Result);
        }
        [Fact]
        public void TestMultiplication()
        {
            CalculatorModel test = new CalculatorModel();
            HomeController hc = new HomeController();
            test.NumberA = 10;
            test.NumberB = 25;
            test.operation = Operation.Multiplication;
            var result = hc.Index(test) as ViewResult;
            var model = result.Model as CalculatorModel;
            Assert.Equal(250, model.Result);
        }
        [Fact]
        public void TestSubtraction()
        {
            CalculatorModel test = new CalculatorModel();
            HomeController hc = new HomeController();
            test.NumberA = 10;
            test.NumberB = 25;
            test.operation = Operation.Subtraction;
            var result = hc.Index(test) as ViewResult;
            var model = result.Model as CalculatorModel;
            Assert.Equal(-15, model.Result);
        }
        [Fact]
        public void TestDivision()
        {
            CalculatorModel test = new CalculatorModel();
            HomeController hc = new HomeController();
            test.NumberA = 100;
            test.NumberB = 25;
            test.operation = Operation.Division;
            var result = hc.Index(test) as ViewResult;
            var model = result.Model as CalculatorModel;
            Assert.Equal(4, model.Result);
        }
        [Fact]
        public void TestNegatives()
        {
            CalculatorModel test = new CalculatorModel();
            HomeController hc = new HomeController();
            test.NumberA = -43;
            test.NumberB = 23;
            test.operation = Operation.Addition;
            var result = hc.Index(test) as ViewResult;
            var model = result.Model as CalculatorModel;
            Assert.Equal(-20, model.Result);
        }
    }
}
