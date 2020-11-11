using System;

namespace Task0
{
    class Printer
    {
        public ConsoleColor color;
        public Printer()
        {

        }
        public Printer(ConsoleColor color)
        {
            this.color = color;
        }
        public void Print(string value)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{value}.");
        }
    }
}
