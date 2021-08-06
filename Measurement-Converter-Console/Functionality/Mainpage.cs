using Measurement_Converter_Library.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class Mainpage
    {

        public static void ExecuteMainPage()
        {
            //clear screen
            Console.Clear();
            //give instructions
            Console.WriteLine("\n");
            Console.WriteLine("Type number of choicen option");
            //give options
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
                Console.WriteLine("something went wrong");
            }
            if (input.KeyChar == '1')
            {
                Console.WriteLine("786987");
                //FillInValuePage.ExecuteFillinValue(ConversionType.CentimeterToMeter);
                //Console.WriteLine(item2);
                //ConversionType.CentimeterToMeter;
            }
        }
    }
}
