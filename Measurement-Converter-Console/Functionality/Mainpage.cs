using Measurement_Converter_Library.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Measurement_Converter_Console.Functionality
{
    public class Mainpage
    {

        public static void ExecuteMainPage()
        {
            try
            {
                //clear screen
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                //give instructions
                Console.WriteLine("\n");
                Console.WriteLine("Type number of choicen option");
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                //give options
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("\n");
                Console.WriteLine("1 : Meter to centimeter");
                Console.WriteLine("\n");
                Console.WriteLine("2 : Centimeter to meter");
                Console.WriteLine("\n");
                Console.WriteLine("3 : Centimeter to millimeter");
                Console.WriteLine("\n");
                Console.WriteLine("4 : Millimeter to centimeter");
                Console.WriteLine("\n");
                Console.WriteLine("5 : Meter to inch");
                Console.WriteLine("\n");
                Console.WriteLine("6 : Inch to meter");
                Console.WriteLine("\n");
                Console.WriteLine("7 : Close application");
                //read value and pass to appropriate method
                Console.WriteLine("\n");
                ConsoleKeyInfo input = Console.ReadKey();
                if (Measurement_Converter_Library.BoundryChecks.FaultCheck.IsInputFaultyMainPage(input.KeyChar))
                {
                    Measurement_Converter_Console.Functionality.FaultyInputPage.RedirectFaultyInput();
                }
                if (input.KeyChar == '1')
                {
                    FillInValuePage.ExecuteFillinValue(ConversionType.MeterToCentimeter);
                }
                if (input.KeyChar == '2')
                {
                    FillInValuePage.ExecuteFillinValue(ConversionType.CentimeterToMeter);
                }
                if (input.KeyChar == '3')
                {
                    FillInValuePage.ExecuteFillinValue(ConversionType.CentimeterToMillimeter);
                }
                if (input.KeyChar == '4')
                {
                    FillInValuePage.ExecuteFillinValue(ConversionType.MillimeterToCentimeter);
                }
                if (input.KeyChar == '5')
                {
                    FillInValuePage.ExecuteFillinValue(ConversionType.MeterToInch);
                }
                if (input.KeyChar == '6')
                {
                    FillInValuePage.ExecuteFillinValue(ConversionType.InchToMeter);
                }
                if (input.KeyChar == '7')
                {
                    Environment.Exit(0);
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
