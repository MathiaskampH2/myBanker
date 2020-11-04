using System;
using System.Runtime.InteropServices;

namespace myBanker
{

    /// <summary>
    /// Gui class´s purpose is to print out a Gui menu from main.
    /// </summary>
    public class Gui
    {
        public void PrintGui()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("                 Card Terminal               ");
            Console.WriteLine("=============================================");

            Console.WriteLine("Please choose which card you want to be made for you");

            Console.WriteLine("1. Debit Card ");
            Console.WriteLine("2. Maestro Card");
            Console.WriteLine("3. Visa Electron Card");
            Console.WriteLine("4. Visa Card");
            Console.WriteLine("5. Master Card");
            Console.WriteLine("6. Exit");
        }
    }
}