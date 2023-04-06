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
        }

        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _subjects = new List<Subject>();
        }

        override public string ToString()
        {
            return $" FirstName: {_firstName}, LastName: {_lastName}";
        }
    }
}
