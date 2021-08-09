using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Factory;
using Measurement_Converter_Library.Interfaces;
using Measurement_Converter_Library.ServiceLocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class ShowCalculatedPage
    {
        private readonly IFactoryConsoleParameter _factoryConsolParameter;
        public ShowCalculatedPage(IFactoryConsoleParameter factoryConsoleParameter)
        {
            _factoryConsolParameter = factoryConsoleParameter;
        }

        public static void ExecuteShowCalculation(ConversionTypeResult DTO)
        {
            try
            {
                //clear screen
                Console.Clear();
                //label information
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                Console.WriteLine("The converted value is :");
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n");
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.CentimeterToMeter)
                {
                    LoggingObj log = new LoggingObj();
                    log.Calculation = DTO.value + " " + "Meter" + " : " + DTO.type;
                    log.Date = DateTime.Now.ToString();
                    Measurement_Converter_Library.Interfaces.IFactoryServiceLocator factoryServiceLocator = FactoryServiceLocator.GetFactoryService();
                    var FactorySL = factoryServiceLocator.GetService<IPreConsoleRepo>();
                    FactorySL.Add(log);
                    Measurement_Converter_Library.Logging.ConsoleLogging.WriteCalculationLog(log);
                    Console.WriteLine(DTO.value + " " + "Meter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.CentimeterToMillimeter)
                {
                    LoggingObj log = new LoggingObj();
                    log.Calculation = DTO.value + " " + "Millimeter" + " : " + DTO.type;
                    log.Date = DateTime.Now.ToString();
                    Measurement_Converter_Library.Interfaces.IFactoryServiceLocator factoryServiceLocator = FactoryServiceLocator.GetFactoryService();
                    var FactorySL = factoryServiceLocator.GetService<IPreConsoleRepo>();
                    FactorySL.Add(log);
                    Console.WriteLine(DTO.value + " " + "Millimeter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.InchToMeter)
                {
                    LoggingObj log = new LoggingObj();
                    log.Calculation = DTO.value + " " + "Meter" + " : " + DTO.type;
                    log.Date = DateTime.Now.ToString();
                    Measurement_Converter_Library.Interfaces.IFactoryServiceLocator factoryServiceLocator = FactoryServiceLocator.GetFactoryService();
                    var FactorySL = factoryServiceLocator.GetService<IPreConsoleRepo>();
                    FactorySL.Add(log); Console.WriteLine(DTO.value + " " + "Meter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.MeterToCentimeter)
                {
                    LoggingObj log = new LoggingObj();
                    log.Calculation = DTO.value + " " + "Centimeter" + " : " + DTO.type;
                    log.Date = DateTime.Now.ToString();
                    Measurement_Converter_Library.Interfaces.IFactoryServiceLocator factoryServiceLocator = FactoryServiceLocator.GetFactoryService();
                    var FactorySL = factoryServiceLocator.GetService<IPreConsoleRepo>();
                    FactorySL.Add(log); Console.WriteLine(DTO.value + " " + "Centimeter");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.MeterToInch)
                {
                    LoggingObj log = new LoggingObj();
                    log.Calculation = DTO.value + " " + "Inch" + " : " + DTO.type;
                    log.Date = DateTime.Now.ToString();
                    Measurement_Converter_Library.Interfaces.IFactoryServiceLocator factoryServiceLocator = FactoryServiceLocator.GetFactoryService();
                    var FactorySL = factoryServiceLocator.GetService<IPreConsoleRepo>();
                    FactorySL.Add(log); Console.WriteLine(DTO.value + " " + "Inch");
                }
                if (DTO.type == Measurement_Converter_Library.Enums.ConversionType.MillimeterToCentimeter)
                {
                    LoggingObj log = new LoggingObj();
                    log.Calculation = DTO.value + " " + "Centimeter" + " : " + DTO.type;
                    log.Date = DateTime.Now.ToString();
                    Measurement_Converter_Library.Interfaces.IFactoryServiceLocator factoryServiceLocator = FactoryServiceLocator.GetFactoryService();
                    var FactorySL = factoryServiceLocator.GetService<IPreConsoleRepo>();
                    FactorySL.Add(log); Console.WriteLine(DTO.value + " " + "Centimeter");
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
                Functionality.ErrorCatchingPage.ExecuteErrorCatching(ex);
            }
        }

    }
}
