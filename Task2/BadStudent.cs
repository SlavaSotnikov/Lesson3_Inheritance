using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BadStudent:Student
    {
        public override void Study()
        {
            Console.WriteLine("BadStudent.Study badly");
        }
        public override void Read()
        {
            Console.WriteLine("BadStudent.Read badly");
        }
        public override void Write()
        {
            Console.WriteLine("BadStudent.Write badly");
        }
        public override void Relax()
        {
            Console.WriteLine("BadStudent.Relax excellent");
        }
    }
}
