using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Measurement_Converter_Console.Functionality
{
    public class StartScreen
    {
        public static void ExecuteStartScreen()
        {
            try
            {
                //clearconsole
                Console.Clear();
                // set culture settings
                Measurement_Converter_Library.Settings.Cultures.SetCulture();
                //title
                Console.WriteLine(@"   _____                                                                  __    _________                                   __                ");
                Console.WriteLine(@"  /     \   ____ _____    ________ __   ___________  _____   ____   _____/  |_  \_   ___ \  ____   _______  __ ____________/  |_  ___________ ");
                Console.WriteLine(@" /  \ /  \_/ __ \\__  \  /  ___/  |  \_/ __ \_  __ \/     \_/ __ \ /    \   __\ /    \  \/ /  _ \ /    \  \/ // __ \_  __ \   __\/ __ \_  __ \");
                Console.WriteLine(@"/    Y    \  ___/ / __ \_\___ \|  |  /\  ___/|  | \/  Y Y  \  ___/|   |  \  |   \     \___(  <_> )   |  \   /\  ___/|  | \/|  | \  ___/|  | \/");
                Console.WriteLine(@"\____|__  /\___  >____  /____  >____/  \___  >__|  |__|_|  /\___  >___|  /__|    \______  /\____/|___|  /\_/  \___  >__|   |__|  \___  >__|   ");
                Console.WriteLine(@"        \/     \/     \/     \/            \/            \/     \/     \/               \/            \/          \/                 \/       ");
                Console.WriteLine("\n");
                // go to other page
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Hit enter to start program");
                Console.ReadLine();
                Functionality.Mainpage.ExecuteMainPage();
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
