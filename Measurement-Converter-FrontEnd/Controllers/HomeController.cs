using Measurement_Converter_FrontEnd.DataService;
using Measurement_Converter_FrontEnd.Interfaces;
using Measurement_Converter_FrontEnd.Models;
using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITestDataService _testDataService;
        private readonly ILoggingRepository _loggingRepository;

        public HomeController(ILogger<HomeController> logger, ITestDataService dataService, ILoggingRepository loggingRepository)
        {
            _logger = logger;
            _testDataService = dataService;
            _loggingRepository = loggingRepository;
        }

        public IActionResult Index()
        {
            TestModel item = new TestModel();
            item.Name = "";
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Index(TestModel item)
        {
            LoggingObj log = new LoggingObj();
            log.Calculation = "testthis";
            _loggingRepository.Add(log);
            var returnedlog = _loggingRepository.GetFirstLog();
            item.Name = returnedlog;
            item.Name = (await _testDataService.Get("something")).Name;
            return View(item);
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
