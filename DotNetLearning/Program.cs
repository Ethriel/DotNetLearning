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

            ICollection<Teacher> teachers = new List<Teacher>() { tch1, tch2, tch3, tch4 };
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

            // Magic
            teachers.Add(
                new Teacher
                {
                    Name = "aboba"
                });
            teachers.Last().AddStudentToTeacher(new Student
            {
                FirstName = "Last student 1",
                LastName = "Last student 1"
            });
            teachers.Last().Students.Last().AddSubjectToStudent(new Subject
            {
                Mark = 1,
                Name = "Last subject"
            });

            Console.WriteLine("LAST TEACHER DEMO");
            Console.WriteLine($"TEACHER {teachers.Last()}");
            Console.WriteLine($"LAST TEACHER, LAST STUDENT {teachers.Last().Students.Last()}");
            Console.WriteLine($"LAST TEACHER, LAST STUDENT, LAST SUBJECT {teachers.Last().Students.Last().Subjects.Last()}");

            // Not magic
            teachers.Add(
                new Teacher
                {
                    Name = "I was added last",
                    Students = new List<Student>()
                    {
                        new Student()
                        {
                            FirstName = "Best 1",
                            LastName = "Student",
                             Subjects = new List<Subject>()
                             {
                                 new Subject()
                                 {
                                     Mark = 1,
                                     Name = "Sbj 1"
                                 },
                                 new Subject()
                                 {
                                     Mark = 2,
                                     Name = "Sbj 2"
                                 }
                             }
                        },
                        new Student()
                        {
                            FirstName = "Best 2",
                            LastName = "Student",
                             Subjects = new List<Subject>()
                             {
                                 new Subject()
                                 {
                                     Mark = 1,
                                     Name = "Sbj 1"
                                 },
                                 new Subject()
                                 {
                                     Mark = 2,
                                     Name = "Sbj 2"
                                 }
                             }
                        }
                    }
                });
        }
    }
}