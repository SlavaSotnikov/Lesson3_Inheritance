using System;

namespace Task0
{
    class Program
    {
        static void Main()
        {            
            RedPrinter red = new RedPrinter();
            GreenPrinter green = new GreenPrinter();
            YellowPrinter yellow = new YellowPrinter();

            Printer[] print = new Printer[3];
            print[0] = red;
            print[1] = green;
            print[2] = yellow;

            for (int i = 0; i < print.Length; i++)
            {
                print[i].Print("Inheritance & Polymorphism");
            }
            Console.ReadLine();
        }
    }
}
