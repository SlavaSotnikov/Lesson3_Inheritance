using System;

namespace Task0
{
    class Program
    {
        static void Main()
        {
            Printer print = new Printer(ConsoleColor.White);
            print.Print("Inheritance");

            ColorPrint red = new ColorPrint(ConsoleColor.Red);
            red.Print("Inheritance");

            ColorPrint green = new ColorPrint(ConsoleColor.Green);
            green.Print("Inheritance");

            Console.ReadLine();
        }
    }
}
