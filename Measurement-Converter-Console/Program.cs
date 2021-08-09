using System;
using Measurement_Converter_FrontEnd.Repository;
using Measurement_Converter_Library.Interfaces;
using Measurement_Converter_Library.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace Measurement_Converter_Console
{
    class Program
    {
        private static readonly ServiceProvider serviceProvider = new ServiceCollection().AddScoped<IPreConsoleRepo,ConsoleLoggingRepository>().AddScoped<IPreMVCRepo,LoggingRepository>().BuildServiceProvider();
        static void Main(string[] args)
        {
            //start application
            Functionality.StartScreen.ExecuteStartScreen();
        }
    }
}
