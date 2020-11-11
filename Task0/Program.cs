using System;

namespace Task0
{
    class Program
    {
        static void Main()
        {
            ColorPrint red = new ColorPrint(ConsoleColor.Red);
            red.Print("Inheritance");

            ColorPrint green = new ColorPrint(ConsoleColor.Green);
            green.Print("Inheritance");

            Printer printer = red;
            printer.Print("Inheritance");

            /*Printer red = new Printer(ConsoleColor.Red);
            red.Print("Inheritance");

            Printer green = new Printer(ConsoleColor.Green);
            green.Print("Inheritance");
            */
            Console.ReadLine();
        }
    }
}
