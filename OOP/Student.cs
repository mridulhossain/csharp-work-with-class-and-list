using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Student
    {
        private string Name;
        private int Roll;

        public Student(string name,int roll)
        {
            Name = name;
            Roll = roll;
        }


        public string GetName()
        {
            return Name;
        }

        public int GetRoll()
        {
            return Roll;
        }


    }
}
