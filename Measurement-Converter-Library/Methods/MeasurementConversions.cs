using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Methods
{
    public class MeasurementConversions
    {
        public static double MeterToCentimeterConversion(double value)
        {
            return (value * 100);
        }

        public static double CentimeterToMeterConversion(double value)
        {
            return (value / 100);
        }

        public static double CentimeterToMillimeterConversion(double value)
        {
            return (value * 10);
        }

        public static double MillimeterToCentimeterConversion(double value)
        {
            return (value / 10);
        }

        public static double MeterToInchConversion(double value)
        {
            return (value * 39.37);
        }

        public static double InchToMeterConversion(double value)
        {
            return (value / 39.37);
        }
    }
}
