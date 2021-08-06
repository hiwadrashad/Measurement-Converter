using Measurement_Converter_Library.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class ShowCalculatedPage
    {
        public static void ExecuteShowCalculation(ConversionTypeResult DTO)
        {
            try
            {
                //clear screen
                Console.Clear();
                //label information
                Console.WriteLine("\n");
                Console.WriteLine("The converted value is :");
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("\n");
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.CentimeterToMeter)
                {
                    Console.WriteLine(DTO.value + " " + "Meter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.CentimeterToMillimeter)
                {
                    Console.WriteLine(DTO.value + " " + "Millimeter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.InchToMeter)
                {
                    Console.WriteLine(DTO.value + " " + "Meter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.MeterToCentimeter)
                {
                    Console.WriteLine(DTO.value + " " + "Centimeter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.MeterToInch)
                {
                    Console.WriteLine(DTO.value + " " + "Inch");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.MillimeterToCentimeter)
                {
                    Console.WriteLine(DTO.value + " " + "Centimeter");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Hit enter to continue");
                Console.WriteLine("\n");
                Console.ReadLine();
                Functionality.EndPage.ExecuteEndPage(DTO);
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Functionality.ErrorCatchingPage.ExecuteErrorCatching();
            }
        }

    }
}
