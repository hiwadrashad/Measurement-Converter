using Measurement_Converter_FrontEnd.Repository;
using Measurement_Converter_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Factory.Parameters
{
    public class FactoryMVCParameter : LoggingFactory, IFactoryMVCParameter
    {
        private ILoggingRepository _logginRepository;
        private IPreMVCRepo _preMVCRepo;
        public FactoryMVCParameter(IPreMVCRepo preMVCRepo)
        {
            _preMVCRepo = preMVCRepo;
        }
        public override ILoggingRepository FactoryRepo()
        {
            _logginRepository = (ILoggingRepository)_preMVCRepo;
            return _logginRepository;
        }
    }
}
