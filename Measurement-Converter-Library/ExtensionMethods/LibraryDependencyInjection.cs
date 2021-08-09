using Measurement_Converter_Library.Interfaces;
using Measurement_Converter_Library.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.ExtensionMethods
{
    public static class LibraryDependencyInjection
    {

            public static void AddDI(this IServiceCollection services)
            {
                services.AddScoped<IPreMVCRepo, LoggingRepository>();
                services.AddScoped<IPreConsoleRepo, ConsoleLoggingRepository>();
            }
        
    }
}
