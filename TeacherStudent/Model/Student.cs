using System.Collections.Generic;
using System.Linq;

namespace TeacherStudent.Model
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private ICollection<Subject> _subjects;

        public string FirstName { get => _firstName; set => _firstName = value; }

        public string LastName { get => _lastName; set => _lastName = value; }

        public ICollection<Subject> Subjects { get => _subjects; set => _subjects = value; }

        public double MeansMarks { get => _subjects.Sum(sj => sj.Mark) / _subjects.Count; }

        public Student()
        {
            _subjects = new List<Subject>();
            AddBasicSubjects();
        }

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subjects = new List<Subject>();
            AddBasicSubjects();
        }

        override public string ToString()
        {
            return $"Student. FirstName: {_firstName}, LastName: {_lastName}";
        }

        public void AddSubjectToStudent(Subject subject)
        {
            _subjects ??= new List<Subject>();
            _subjects.Add(subject);
        }

        public void AddBasicSubjects()
        {
            _subjects.Add
                (new Subject
                {
                    Mark = 1,
                    Name = "first 1"
                }
                );
            _subjects.Add
                (new Subject
                {
                    Mark = 2,
                    Name = "second 2"
                }
                );
        }

        public void AddSubject(string name, double mark)
        {
            _subjects.Add
                (
                new Subject
                {
                    Mark = mark,
                    Name = name
                }
                );
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
