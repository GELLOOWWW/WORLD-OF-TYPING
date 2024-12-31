using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WORLD_OF_TYPING_COPY;
using System.Threading;

namespace console_TYPING
{
    internal class Program
    {
        public static void Main()
        {
            /*System.Threading.Thread.Sleep(1000);
            InputSimulator.F11();*/
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("                                                ██╗    ██╗ ██████╗ ██████╗ ██╗     ██████╗      ██████╗ ███████╗    ████████╗██╗   ██╗██████╗ ██╗███╗   ██╗ ██████╗     \r\n                                                 ██║    ██║██╔═══██╗██╔══██╗██║     ██╔══██╗    ██╔═══██╗██╔════╝    ╚══██╔══╝╚██╗ ██╔╝██╔══██╗██║████╗  ██║██╔════╝     \r\n                                                 ██║ █╗ ██║██║   ██║██████╔╝██║     ██║  ██║    ██║   ██║█████╗         ██║    ╚████╔╝ ██████╔╝██║██╔██╗ ██║██║  ███╗    \r\n                                                 ██║███╗██║██║   ██║██╔══██╗██║     ██║  ██║    ██║   ██║██╔══╝         ██║     ╚██╔╝  ██╔═══╝ ██║██║╚██╗██║██║   ██║    \r\n                                                 ╚███╔███╔╝╚██████╔╝██║  ██║███████╗██████╔╝    ╚██████╔╝██║            ██║      ██║   ██║     ██║██║ ╚████║╚██████╔╝    \r\n                                                  ╚══╝╚══╝  ╚═════╝ ╚═╝  ╚═╝╚══════╝╚═════╝      ╚═════╝ ╚═╝            ╚═╝      ╚═╝   ╚═╝     ╚═╝╚═╝  ╚═══╝ ╚═════╝");



            Console.ResetColor();
            Console.WriteLine("\n");

            Console.WriteLine(@"                                                                BOOST YOUR TYPING ABILITIES WITH EASY, ENJOYABLE, AND HIGHLY PRODUCTIVE TYPING EXERCISES. 
          
                                                        START A THRILLING ADVENTURE WHERE EVERY KEYSTROKE MATTERS, WHETHER YOU'RE COMPETING OR JUST PRACTICING.

                                                                                           ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("                                                                                                 (Press ENTER to PROCEED)");

            Console.ResetColor();
            bool titleRepit = true;

            while (titleRepit)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        Class2.Options(titleRepit);
                        titleRepit = false;
                    }
                }
            }
        }
    }
}