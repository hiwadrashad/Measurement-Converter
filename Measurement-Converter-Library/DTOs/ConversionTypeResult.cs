using Measurement_Converter_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.DTOs
{
    [Serializable]
    public class ConversionTypeResult
    {
        public ConversionType type { get; set; }
        public double value { get; set; }
    }
}
