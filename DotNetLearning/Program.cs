﻿using LessonEight.Serialization;
using LessonFourInterfacesBasics.Model.Abstraction;
using LessonFourInterfacesBasics.Model.Implementation;
using LessonSix.FileWork;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using TeacherStudent.Model;

namespace DotNetLearning
{
    public class Program
    {
        static void Main(string[] args)
        {
            var serializationClass = new SerializationClass();
            var teacher = new Teacher();
            var serializedTeacher = serializationClass.SerializeObject(teacher);
            var teacher2 = serializationClass.DeSerializeObject(serializedTeacher);
            Console.WriteLine(teacher2);
        }

        static void TeachersStudentsLesson()
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

        static void LessonFourDemo()
        {
            ICollection<IPerson> people = new List<IPerson>();
            IPerson oleh = new Oleh { FirstName = "Oleh", Age = 18 };
            IPerson pavlo = new Pavlo { FirstName = "Pavlo", Age = 18 };
            IPerson danik = new Danik { FirstName = "Danik", Age = 18 };
            IPerson vova = new Vova { FirstName = "Vova", Age = 30 };
            people.Add(oleh);
            people.Add(pavlo);
            people.Add(danik);
            people.Add(vova);

            foreach (var person in people)
            {
                person.DoJob();
            }
        }
    }
}