using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Interfaces;
using Measurement_Converter_Library.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Repository
{
    public class ConsoleLoggingRepository : ILoggingRepository, IPreConsoleRepo
    {
        public void Add(LoggingObj DTO)
        {
            ConsoleLogging.WriteCalculationLog(DTO);
        }

        public void AddError(ErrorLoggingObj DTO)
        { 
            ConsoleLogging.WriteErrorLog(DTO);
        }

        public string GetFirstLog()
        {
            throw new NotImplementedException();
        }
    }
}
