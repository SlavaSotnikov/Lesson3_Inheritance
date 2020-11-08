using System;

namespace Task0
{
    class YellowPrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{value}.");
        }
    }
}
