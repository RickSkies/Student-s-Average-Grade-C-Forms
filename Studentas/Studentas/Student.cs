using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentas
{
    class Student
    {
        public string s;
        public int ns;

        public Student(string s, int ns)
        {
            this.s = s;
            this.ns = ns;
        }

        public Student()
        {

        }

        public string GetStudent()
        {
            return s;
        }

        public int GetStudentKiekis()
        {
            return ns;
        }
    }
}
