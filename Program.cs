//*****************************************************************************
//** Console Beep                                                            **
//** Simple program to create a beep.                                        **
//*****************************************************************************


using System;

namespace BiosBeepApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bios Beep Application");
            Console.WriteLine("Press '1' to beep once");
            Console.WriteLine("Press '2' to beep twice");
            Console.WriteLine("Press '3' to beep thrice");
            Console.WriteLine("Press 'q' to quit");

            bool running = true;

            while (running)
            {
                var key = Console.ReadKey(true).KeyChar;

                switch (key)
                {
                    case '1':
                        Console.Beep(); // Default beep
                        break;
                    case '2':
                        Console.Beep();
                        System.Threading.Thread.Sleep(500); // 500 ms delay
                        Console.Beep();
                        break;
                    case '3':
                        Console.Beep();
                        System.Threading.Thread.Sleep(500); // 500 ms delay
                        Console.Beep();
                        System.Threading.Thread.Sleep(500); // 500 ms delay
                        Console.Beep();
                        break;
                    case 'q':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please press '1', '2', '3', or 'q'.");
                        break;
                }
            }

            Console.WriteLine("Exiting application...");
        }
    }
}
