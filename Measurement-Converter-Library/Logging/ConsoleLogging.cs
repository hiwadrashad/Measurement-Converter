using Measurement_Converter_Library.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Logging
{
    public class ConsoleLogging
    {
        public static void WriteCalculationLog(LoggingObj DTO)
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", DTO.Calculation + " : " + DTO.Date + Environment.NewLine);
        }

        public static void WriteErrorLog(Measurement_Converter_Library.DTOs.ErrorLoggingObj DTO)
        {
            string fullpath = System.IO.Directory.GetCurrentDirectory();
            string mainpath = Path.GetFullPath(Path.Combine(fullpath, @"..\..\..\"));
            File.AppendAllText(mainpath + @"Logs\" + "log.txt", DTO.Error + " : " + DTO.Date + Environment.NewLine);
        }
    }
}
