using System;
using Measurement_Converter_Library.Factory;
using Measurement_Converter_Library.Factory.Parameters;
using Measurement_Converter_Library.Interfaces;
using Measurement_Converter_Library.Repository;
using Microsoft.Extensions.DependencyInjection;
using StructureMap;

namespace Measurement_Converter_Console
{
    class Program
    {

        private static readonly ServiceProvider serviceProvider = new ServiceCollection().AddScoped<IPreConsoleRepo,ConsoleLoggingRepository>().AddScoped<IFactoryMVCParameter, FactoryMVCParameter>().AddScoped<IFactoryConsoleParameter, FactoryConsoleParameter>().AddScoped<ILoggingRepository, LoggingRepository>().AddScoped<IPreMVCRepo,LoggingRepository>().BuildServiceProvider();
        public static void Main(string[] args)
        {
            //start application
            Functionality.StartScreen.ExecuteStartScreen();
        }
    }
}
