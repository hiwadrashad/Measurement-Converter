using Measurement_Converter_Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class FillInValuePage
    {
        public static void ExecuteFillinValue(ConversionType type)
        {
            //clearconsole
            Console.Clear();
            //attend on formatting
            Console.WriteLine("\n");
            Console.WriteLine("Format of input should be US based, example: 10,000.96");
            Console.WriteLine("\n");
            Console.WriteLine("Fill in the value to convert");
            Console.WriteLine("\n");
            string input = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine(input);

        }
    }
}
