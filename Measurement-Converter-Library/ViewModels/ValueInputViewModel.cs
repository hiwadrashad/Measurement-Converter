using Measurement_Converter_Library.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.ViewModels
{
    [Serializable]
    public class ValueInputViewModel
    {
        public ConversionTypeResult DTO { get; set; }
        public string StringValue { get; set; }
    }
}
