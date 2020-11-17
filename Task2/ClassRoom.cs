using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassRoom
    {
        readonly Student[] students = new Student[4];
               
        public ClassRoom(Student s0, Student s1, Student s2, Student s3)
        {
            students[0] = s0;
            students[1] = s1;
            students[2] = s2;
            students[3] = s3;
        }
        public void Study()
        {
            foreach (Student s in students)
            {
                s.Study();
            }
        }
        public void Write()
        {
            foreach (Student s in students)
            {
                s.Write();
            }
        }
        public void Read()
        {
            foreach (Student s in students)
            {
                s.Read();
            }
        }
        public void Relax()
        {
            foreach (Student s in students)
            {
                s.Relax();
            }
        }
    }
}
