using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class FillInValuePage
    {
        public static void ExecuteFillinValue(ConversionType type)
        {
            try
            {
                //clearconsole
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                //attend on formatting
                Console.WriteLine("\n");
                Console.WriteLine("Format of input should be US based, example: 10,000.96");
                Console.WriteLine("\n");
                Console.WriteLine("Fill in the value to convert");
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n");
                string input = Console.ReadLine();
                Console.WriteLine("\n");
                bool isfaulty = Measurement_Converter_Library.BoundryChecks.FaultCheck.IsValueToCalculateFaulty(input);
                if (isfaulty)
                {
                    Measurement_Converter_Console.Functionality.FaultyInputPage.RedirectFaultyInput();
                }
                else
                {
                    ConversionTypeResult DTO = new ConversionTypeResult();
                    DTO.type = type;
                    if (type == ConversionType.CentimeterToMeter)
                    {
                        DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMeterConversion(double.Parse(input, CultureInfo.InvariantCulture));
                    }
                    if (type == ConversionType.CentimeterToMeter)
                    {
                        DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.CentimeterToMeterConversion(double.Parse(input, CultureInfo.InvariantCulture));
                    }
                    if (type == ConversionType.InchToMeter)
                    {
                        DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.InchToMeterConversion(double.Parse(input, CultureInfo.InvariantCulture));
                    }
                    if (type == ConversionType.MeterToCentimeter)
                    {
                        DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.MeterToCentimeterConversion(double.Parse(input, CultureInfo.InvariantCulture));
                    }
                    if (type == ConversionType.MeterToInch)
                    {
                        DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.MeterToInchConversion(double.Parse(input, CultureInfo.InvariantCulture));
                    }
                    if (type == ConversionType.MillimeterToCentimeter)
                    {
                        DTO.value = Measurement_Converter_Library.Methods.MeasurementConversions.MillimeterToCentimeterConversion(double.Parse(input, CultureInfo.InvariantCulture));
                    }

                    ShowCalculatedPage.ExecuteShowCalculation(DTO);
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Functionality.ErrorCatchingPage.ExecuteErrorCatching(ex);
            }


        }
    }
}
