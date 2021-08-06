using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class ErrorCatchingPage
    {
        public static void ExecuteErrorCatching()
        {
            try
            {
                //clearconsole
                Console.Clear();
                //show error message
                Console.WriteLine("\n");
                Console.WriteLine("Something went wrong!");
                Console.WriteLine("\n");
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("\n");
                // give further instructions
                Console.WriteLine("Hit enter to go to the main page");
                Console.ReadLine();
                Measurement_Converter_Console.Functionality.Mainpage.ExecuteMainPage();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Functionality.ErrorCatchingPage.ExecuteErrorCatching();
            }
        }
    }
}
