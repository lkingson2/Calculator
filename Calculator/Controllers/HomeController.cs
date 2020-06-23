using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Calculator.Models;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorModel model)
        {
            ModelState.Clear();
            switch (model.operation)
            {
                case Operation.Addition:
                    model.Result = model.NumberA + model.NumberB;
                    break;
                case Operation.Subtraction:
                    model.Result = model.NumberA - model.NumberB;
                    break;
                case Operation.Multiplication:
                    model.Result = model.NumberA * model.NumberB;
                    break;
                case Operation.Division:
                    if(model.NumberB != 0)
                    {
                        model.Result = model.NumberA / model.NumberB;
                    }
                    break;
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
