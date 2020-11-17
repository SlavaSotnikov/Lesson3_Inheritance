using System;

namespace Task2
{
    class ExcelentStudent:Student
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentStudent.Study excellent");
        }
        public override void Read()
        {
            Console.WriteLine("ExcelentStudent.Read excellent");
        }
        public override void Write()
        {
            Console.WriteLine("ExcelentStudent.Write excellent");
        }
        public override void Relax()
        {
            Console.WriteLine("ExcelentStudent.Relax excellent");
        }
    }
}
