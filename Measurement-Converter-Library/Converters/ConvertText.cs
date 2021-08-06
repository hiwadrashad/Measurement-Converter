using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.Converters
{
    public class ConvertText
    {
        public static double ConvertStringToEligableDouble(string input)
        {
            string item = "100000.78";
            double item2 = double.Parse(item, CultureInfo.InvariantCulture); 
            return 10.10 ;
        }
    }
}
