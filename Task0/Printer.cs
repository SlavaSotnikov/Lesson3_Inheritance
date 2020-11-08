using System;

namespace Task0
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine($"{value}.");
        }
    }
}
