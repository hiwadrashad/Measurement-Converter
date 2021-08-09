using Measurement_Converter_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Factory
{
    public class FactoryConsoleParameter : LoggingFactory , IFactoryConsoleParameter 
    {
        private ILoggingRepository _logginRepository;
        private IPreConsoleRepo _preConsoleRepo;
        public FactoryConsoleParameter(IPreConsoleRepo preMVCRepo)
        {
            _preConsoleRepo = preMVCRepo;
        }
        public override ILoggingRepository FactoryRepo()
        {
            _logginRepository = (ILoggingRepository)_preConsoleRepo;
            return _logginRepository;
        }
    }
}
