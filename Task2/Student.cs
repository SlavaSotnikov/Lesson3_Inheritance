using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public virtual void Study()
        {
            Console.WriteLine("Student.Study well");
        }
        public virtual void Read()
        {
            Console.WriteLine("Student.Read well");
        }
        public virtual void Write()
        {
            Console.WriteLine("Student.Write well");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Student.Write well");
        }
    }
}
