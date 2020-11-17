using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Student s1 = new GoodStudent();
            Student s2 = new BadStudent();
            Student s3 = new ExcelentStudent();
            Student s4 = new Student();

            ClassRoom group = new ClassRoom(s1, s2, s3, s4);

            group.Study();
            Console.WriteLine(new string('-', 30));
            group.Read();
            Console.WriteLine(new string('-', 30));
            group.Write();
            Console.WriteLine(new string('-', 30));
            group.Relax();            

            Console.ReadKey();
        }
    }
}
