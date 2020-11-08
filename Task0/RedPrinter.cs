using System;

namespace Task0
{
    class RedPrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{value}.");
        }
    }
}
