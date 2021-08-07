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
        public ActionResult Frontpage()
        {
            return View();
        }

        public ActionResult ValueInputPage()
        {
            return View();
        }

        public ActionResult Endpage()
        {
            return View();
        }
    }
}
