using Measurement_Converter_Library.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.Controllers
{
    public class PageController : Controller
    {
        // GET: PageController

        public ActionResult MeterToCentimeter()
        {
            return View("ValueinputPage", ConversionType.MeterToCentimeter);
        }
        public ActionResult Frontpage()
        {
            return View();
        }

        public ActionResult ValueInputPage(ConversionType type)
        {
            return View();
        }

        public ActionResult Endpage()
        {
            return View();
        }

        public ActionResult ShowValuePage()
        {
            return View();
        }
    }
}
