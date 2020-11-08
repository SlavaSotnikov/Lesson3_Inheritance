using System;

namespace Task0
{
    class GreenPrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{value}.");
        }
    }
}
