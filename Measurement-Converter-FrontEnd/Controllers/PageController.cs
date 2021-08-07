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

namespace Measurement_Converter_FrontEnd.Controllers
{
    public class PageController : Controller
    {
        // GET: PageController

        public ActionResult MeterToCentimeter()
        {
            ValueInputViewModel VM = new ValueInputViewModel();
            ConversionTypeResult DTO = new ConversionTypeResult();
            VM.DTO = DTO;
            VM.DTO.type = ConversionType.MeterToCentimeter;
            TempData.Put("value", VM);
            return RedirectToAction("ValueinputPage");
        }

        public ActionResult CentimeterToMeter()
        {
            ValueInputViewModel VM = new ValueInputViewModel();
            ConversionTypeResult DTO = new ConversionTypeResult();
            VM.DTO = DTO;
            VM.DTO.type = ConversionType.CentimeterToMeter;
            return View("ValueinputPage", VM);
        }

        public ActionResult CentimeterToMillimeter()
        {
            ValueInputViewModel VM = new ValueInputViewModel();
            ConversionTypeResult DTO = new ConversionTypeResult();
            VM.DTO = DTO;
            VM.DTO.type = ConversionType.CentimeterToMillimeter;
            return View("ValueinputPage", VM);
        }
        public ActionResult MillimeterToCentimeter()
        {
            ValueInputViewModel VM = new ValueInputViewModel();
            ConversionTypeResult DTO = new ConversionTypeResult();
            VM.DTO = DTO;
            VM.DTO.type = ConversionType.MillimeterToCentimeter;
            return View("ValueinputPage", VM);
        }
        public ActionResult MeterToInch()
        {
            ValueInputViewModel VM = new ValueInputViewModel();
            ConversionTypeResult DTO = new ConversionTypeResult();
            VM.DTO = DTO;
            VM.DTO.type = ConversionType.MeterToInch;
            return View("ValueinputPage", VM);
        }
        public ActionResult InchToMeter()
        {
            ValueInputViewModel VM = new ValueInputViewModel();
            ConversionTypeResult DTO = new ConversionTypeResult();
            VM.DTO = DTO;
            VM.DTO.type = ConversionType.InchToMeter;
            return View("ValueinputPage", VM);
        }
        public ActionResult Frontpage()
        {
            return View();
        }

        public ActionResult ValueInputPage()
        {
            ValueInputViewModel VM = TempData.Get<ValueInputViewModel>("value");
            TempData.Put("value", VM);
            return View(VM);
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
            catch (Exception ex)
            {
                return RedirectToAction("Frontpage");
            }
        }
        public ActionResult Endpage()
        {
            return View();
        }

        public ActionResult ShowValuePage()
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
                    VM.DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMeterConversion(VM.DTO.value);
                }
                if (VM.DTO.type == ConversionType.CentimeterToMillimeter)
                {
                    VM.DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMillimeterConversion(VM.DTO.value);
                }
                if (VM.DTO.type == ConversionType.InchToMeter)
                {
                    VM.DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.InchToMeterConversion(VM.DTO.value);
                }
                if (VM.DTO.type == ConversionType.MeterToCentimeter)
                {
                    VM.DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.MeterToCentimeterConversion(VM.DTO.value);
                }
                if (VM.DTO.type == ConversionType.MeterToInch)
                {
                    VM.DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.MeterToInchConversion(VM.DTO.value);
                }
                if (VM.DTO.type == ConversionType.MillimeterToCentimeter)
                {
                    VM.DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.MillimeterToCentimeterConversion(VM.DTO.value);
                }
                return View(VM);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Frontpage");
            }
        }

        public ActionResult WrongValueGivenPage()
        {

            return View();
        }
    }
}
