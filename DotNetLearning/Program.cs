using System;
using System.Collections.Generic;
using System.Linq;
using TeacherStudent.Model;

namespace DotNetLearning
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tch1 = new Teacher
            {
                Name = "T1",
            };
            var tch2 = new Teacher
            {
                Name = "T2",
            };
            var tch3 = new Teacher
            {
                Name = "T3",
            };
            var tch4 = new Teacher
            {
                Name = "T4",
            };
            var teachers = new List<Teacher>() { tch1, tch2, tch3, tch4 };
            var iteration = 1;
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"{iteration}: {teacher.Rate}");
                iteration++;
            }

            var tch5 = new Teacher
            {
                Name = "T5",
            };
            var st = new Student();
            var st2 = new Student();
            st.AddSubject("prgm", 10.0);
            st2.AddSubject("prgm2", 9.0);
            tch5.Students.Add(st);
            tch5.Students.Add(st2);
            teachers.Add(tch5);

            foreach (var teacher in teachers)
            {
                Console.WriteLine(teacher);
            }

            var filteredTeachers = teachers.OrderByDescending(t => t.Rate);
            Console.WriteLine("FILTERED");
            foreach (var teacher in filteredTeachers)
            {
                Console.WriteLine(teacher);
            }
        }
    }
}