using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class EndPage
    {
        public static void ExecuteEndPage(Measurement_Converter_Library.DTOs.ConversionTypeResult DTO)
        {
            try
            {
                //clear screen
                Console.Clear();
                //Label information
                Console.WriteLine("\n");
                Console.WriteLine(" Choose one of the following option to continue, fill in the appropriate number");
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("\n");
                Console.WriteLine("1 : Use same algorithm to calculate a new number");
                Console.WriteLine("\n");
                Console.WriteLine("2 : Go to option menu");
                Console.WriteLine("\n");
                Console.WriteLine("3 : Terminate application");
                Console.WriteLine("\n");
                ConsoleKeyInfo input = Console.ReadKey();
                if (Measurement_Converter_Library.BoundryChecks.FaultCheck.IsInputFaultyEndPage(input.KeyChar))
                {
                    Measurement_Converter_Console.Functionality.Mainpage.ExecuteMainPage();
                }
                if (input.KeyChar == '1')
                {
                    Functionality.FillInValuePage.ExecuteFillinValue(DTO.type);
                }
                if (input.KeyChar == '2')
                {
                    Functionality.Mainpage.ExecuteMainPage();
                }
                if (input.KeyChar == '3')
                {
                    Environment.FailFast("Terminated program");
                }
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Functionality.ErrorCatchingPage.ExecuteErrorCatching(ex);
            }


        }
    }
}
