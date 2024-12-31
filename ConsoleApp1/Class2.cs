using console_TYPING;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WORLD_OF_TYPING_COPY
{
    internal class Class2
    {
        public static void Options(bool titleRepit)
        {
            /*class2*/
            Console.Clear();
            Console.WriteLine("\n\n\n\n\t\t\t\t\t\t\t\t\t\t         ----------------- MENU -----------------");
            Console.WriteLine("\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\t\t\t\t       Instructions:\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t         !Choose a Difficulty Level:\r\n\r\n\t\t\t\t\t\t\t\t\tDifferent difficulty levels will be displayed to challenge and help you practice.\r\n\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t              !Type the Sentences:\r\n\r\n\t\t\t\t\t\t\t\t       Type the sentences shown on your screen based on the difficulty level you selected.\r\n\t\t\t\t\t\t\t\t\t\t\t\t\n\t\t\t\t\t\t\t\t\t\t\t\t   !Follow Correct Letter Order:\r\n\r\n\t\t\t\t\t\t\t\t        Make sure to type each word accurately, following the correct sequence of letters.      ");
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t                 PRESS 'SPACE BAR' TO PROCEED IN THE PURE TYPING MODE     ");
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\t\t    Press 'ESC'  to  Exit");

            bool condition = true;
            while (titleRepit)
            {
                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
                    {
                        Console.Clear();
                        Class1.Option1();
                    }
                    else if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Program.Main();
                    }
                }
            }
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t  ----------------------------------------------------");
        }
    }
}
