using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Library.BoundryChecks
{
    public class FaultCheck
    {
        //check if input is a proper value for the main page
        public static bool IsInputFaultyMainPage(char input)
        {
            List<char> CharsTocheck = new List<char>() { '1', '2', '3', '4', '5', '6', '7' };
            foreach (var character in CharsTocheck)
            {
                if (input == character)
                {
                    return false;
                }
            }
            return true;
        }

        //check if input is a proper value for the end page

        public static bool IsInputFaultyEndPage(char input)
        {
            List<char> CharsTocheck = new List<char>() { '1', '2', '3' };
            foreach (var character in CharsTocheck)
            {
                if (input == character)
                {
                    return false;
                }
            }
            return true;
        }

        //check if input is a proper value for the given number to convert

        public static bool IsValueToCalculateFaulty(string input)
        {

            if (!(Double.TryParse(input, out double result)))
            {
                return true;
            }
            double parsedvalue = double.Parse(input, CultureInfo.InvariantCulture);
            if (parsedvalue < 0)
            {
                return true;
            }
            return false;
        }
    }
}
