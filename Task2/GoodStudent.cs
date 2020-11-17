using System;

namespace Task2
{
    class GoodStudent:Student
    {
        public override void Study()
        {
            Console.WriteLine("GoodStudent.Study well");
        }
        public override void Read()
        {
            Console.WriteLine("GoodStudent.Read excellent");
        }
        public override void Write()
        {
            Console.WriteLine("GoodStudent.Write well");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodStudent.Relax well");
        }
    }
}
