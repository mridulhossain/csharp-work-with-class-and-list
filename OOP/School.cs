using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class School
    {
        public string Class;
        public readonly List<Student> _students = new List<Student>();

        public School(string Class,List<Student> students)
        {
            this.Class = Class;
            _students = students; 
        }


        public List<Student> GetStudents()
        {
            return _students;
        }

    }
}
