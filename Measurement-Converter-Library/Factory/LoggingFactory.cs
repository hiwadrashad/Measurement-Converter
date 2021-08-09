using Measurement_Converter_Library.DTOs;
using Measurement_Converter_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Factory
{
    public abstract class LoggingFactory
    {
        public abstract ILoggingRepository FactoryRepo();


        public void Log(LoggingObj DTO)
        { 
            var Repo = FactoryRepo();
            Repo.Add(DTO);
        }

        public void ErrorLog(ErrorLoggingObj DTO)
        {
            var Repo = FactoryRepo();
            Repo.AddError(DTO);
        }

    }
}
