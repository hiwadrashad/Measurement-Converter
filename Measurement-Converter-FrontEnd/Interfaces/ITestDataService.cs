using Measurement_Converter_FrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Measurement_Converter_FrontEnd.Interfaces
{
    public interface ITestDataService
    {
        Task<TestModel> Get(string id);

    }
}
