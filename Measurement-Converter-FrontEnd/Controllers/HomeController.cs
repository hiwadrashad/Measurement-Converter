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
        private readonly IResultDataService _resultDataService;

        public HomeController(ILogger<HomeController> logger, ITestDataService dataService, ILoggingRepository loggingRepository, IResultDataService resultDataService)
        {
            _logger = logger;
            _testDataService = dataService;
            _loggingRepository = loggingRepository;
            _resultDataService = resultDataService;
        }

        public IActionResult Index()
        {
            ConversionTypeResult item = new ConversionTypeResult();
            item.value = 0;
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ConversionTypeResult item)
        {
            LoggingObj log = new LoggingObj();
            log.Calculation = "testthis";
            _loggingRepository.Add(log);

            item.value = (await _resultDataService.Get(100)).value;
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
