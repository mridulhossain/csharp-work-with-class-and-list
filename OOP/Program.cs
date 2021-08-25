using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                 new Student("Guddu Pandit", 413),
                 new Student("Bauji", 414),
                 new Student("Chacha", 415),
                 new Student("Munna vai", 416),
                 new Student("Compounder", 417)

             };

            School school = new School("Class 1",students);

            Console.WriteLine(school.Class);

            Console.WriteLine("---------------------------------");

            foreach (var student in school.GetStudents())
            {
                 Console.WriteLine("---------------------------------");
                 Console.WriteLine("Name - "+student.GetName()+",Roll - "+student.GetRoll());
                 Console.WriteLine("---------------------------------");
            } 
            
        }
    }
}


