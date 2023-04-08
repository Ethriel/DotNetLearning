using System.Collections.Generic;
using System.Linq;

namespace TeacherStudent.Model
{
    public class Teacher
    {
        private ICollection<Student> _students; // field
        private string _name;
        public ICollection<Student> Students { get => _students; set => _students = value; } // Property
        public double Rate { get => Students.Sum(st => st.MeansMarks); } // Calculated Property
        public string Name { get => _name; set => _name = value; }

        public Teacher()
        {
            _students = new List<Student>();
            AddBasicStudents();
        }

        public void AddStudentToTeacher(Student student)
        {
            _students ??= new List<Student>();
            _students.Add(student);
        }

        public void AddBasicStudents()
        {
            Students.Add
                (new Student
                {
                    FirstName = "First student",
                    LastName = "Second student"
                }
                );
        }

        public override string ToString()
        {
            return $"Teacher. Name: {Name}, Rate: {Rate}";
        }

        public void Dispose()
        {
            _students = null;
        }
    }
}
