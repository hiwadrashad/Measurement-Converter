using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Enums;
using Measurement_Converter_Library.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Measurement_Converter_Library.ExtensionMethods;
using Measurement_Converter_Library.Interfaces;

namespace Measurement_Converter_FrontEnd.Controllers
{
    public class PageController : Controller
    {
        // GET: PageController
        private readonly ILoggingRepository _loggingRepository;
        private readonly IResultDataService _resultDataService;

        public PageController(ILoggingRepository loggingRepository, IResultDataService resultDataService)
        {
            _loggingRepository = loggingRepository;
            _resultDataService = resultDataService;
        }
        public ActionResult MeterToCentimeter()
        {
            try
            {
                ValueInputViewModel VM = new ValueInputViewModel();
                ConversionTypeResult DTO = new ConversionTypeResult();
                VM.DTO = DTO;
                VM.DTO.type = ConversionType.MeterToCentimeter;
                TempData.Put("value", VM);
                return RedirectToAction("ValueinputPage");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/"); 
            }
        }

        public ActionResult CentimeterToMeter()
        {
            try
            {
                ValueInputViewModel VM = new ValueInputViewModel();
                ConversionTypeResult DTO = new ConversionTypeResult();
                VM.DTO = DTO;
                VM.DTO.type = ConversionType.CentimeterToMeter;
                return View("ValueinputPage", VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }

        public ActionResult CentimeterToMillimeter()
        {
            try
            {
                ValueInputViewModel VM = new ValueInputViewModel();
                ConversionTypeResult DTO = new ConversionTypeResult();
                VM.DTO = DTO;
                VM.DTO.type = ConversionType.CentimeterToMillimeter;
                return View("ValueinputPage", VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }
        public ActionResult MillimeterToCentimeter()
        {
            try
            {
                ValueInputViewModel VM = new ValueInputViewModel();
                ConversionTypeResult DTO = new ConversionTypeResult();
                VM.DTO = DTO;
                VM.DTO.type = ConversionType.MillimeterToCentimeter;
                return View("ValueinputPage", VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }
        public ActionResult MeterToInch()
        {
            try
            {
                ValueInputViewModel VM = new ValueInputViewModel();
                ConversionTypeResult DTO = new ConversionTypeResult();
                VM.DTO = DTO;
                VM.DTO.type = ConversionType.MeterToInch;
                return View("ValueinputPage", VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }
        public ActionResult InchToMeter()
        {
            try
            {
                ValueInputViewModel VM = new ValueInputViewModel();
                ConversionTypeResult DTO = new ConversionTypeResult();
                VM.DTO = DTO;
                VM.DTO.type = ConversionType.InchToMeter;
                return View("ValueinputPage", VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }
        public ActionResult Frontpage()
        {
            return View();
        }

        public ActionResult ValueInputPage()
        {
            try
            {
                ValueInputViewModel VM = TempData.Get<ValueInputViewModel>("value");
                TempData.Put("value", VM);
                return View(VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }

        [HttpPost]
        public ActionResult ValueInputPage(ValueInputViewModel VM, string placeholder = "")
        {
            try
            {
                VM.DTO = TempData.Get<ValueInputViewModel>("value").DTO;
                TempData.Put("value", VM);
                return RedirectToAction("ShowValuePage");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }
        public ActionResult Endpage()
        {
            try
            {
                ValueInputViewModel VM = TempData.Get<ValueInputViewModel>("value");
                TempData.Put("value", VM);
                return View();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }

        public async Task<ActionResult> ShowValuePage()
        {
            try
            {
                ValueInputViewModel VM = TempData.Get<ValueInputViewModel>("value");
                if (Measurement_Converter_Library.BoundryChecks.FaultCheck.IsValueToCalculateFaulty(VM.StringValue))
                {
                    return View("WrongValueGivenPage");
                }
                VM.DTO.value = double.Parse(VM.StringValue, CultureInfo.InvariantCulture);
                if (VM.DTO.type == ConversionType.CentimeterToMeter)
                {


                    VM.DTO.value = (await _resultDataService.Get(Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMeterConversion(VM.DTO.value))).value;
                }
                if (VM.DTO.type == ConversionType.CentimeterToMillimeter)
                {
                    VM.DTO.value = (await _resultDataService.Get(Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMillimeterConversion(VM.DTO.value))).value;

                }
                if (VM.DTO.type == ConversionType.InchToMeter)
                {

                    VM.DTO.value = (await _resultDataService.Get(Measurement_Converter_Library.Methods.MeasurementConversions.InchToMeterConversion(VM.DTO.value))).value;;
                }
                if (VM.DTO.type == ConversionType.MeterToCentimeter)
                {
                   VM.DTO.value = (await _resultDataService.Get(Measurement_Converter_Library.Methods.MeasurementConversions.MeterToCentimeterConversion(VM.DTO.value))).value;;
                }
                if (VM.DTO.type == ConversionType.MeterToInch)
                {
                    VM.DTO.value = (await _resultDataService.Get(Measurement_Converter_Library.Methods.MeasurementConversions.MeterToInchConversion(VM.DTO.value))).value;;
                }
                if (VM.DTO.type == ConversionType.MillimeterToCentimeter)
                {
                    VM.DTO.value = (await _resultDataService.Get(Measurement_Converter_Library.Methods.MeasurementConversions.MillimeterToCentimeterConversion(VM.DTO.value))).value;;
                }
                TempData.Put("value", VM);
                return View(VM);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }

        /// <summary>
        /// Logging is turned of for this example
        /// </summary>
        /// <param name="placeholder"></param>
        /// <returns></returns>

        [HttpPost]
        public ActionResult ShowValuePage(string placeholder = "")
        {
            try
            {

                ValueInputViewModel VM = TempData.Get<ValueInputViewModel>("value");

                //logging commented out

                //LoggingObj log = new LoggingObj();
                //log.Calculation = VM.DTO.value + " " + VM.DTO.type;
                //log.Date = DateTime.Now.ToString();
                //_loggingRepository.Add(log);

                TempData.Put("value", VM);
                return View("Endpage");
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }

        }

        public ActionResult WrongValueGivenPage()
        {
            try
            {
                return View();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                return Redirect("~/");
            }
        }
    }
}
