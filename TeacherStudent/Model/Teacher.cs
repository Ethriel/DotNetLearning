using System.Collections.Generic;
using System.Linq;

namespace TeacherStudent.Model
{
    public class Teacher
    {
        private ICollection<Student> _students; // field
        public ICollection<Student> Students { get => _students; set => _students = value; } // Property
        public double Rate { get => Students.Sum(st => st.MeansMarks); } // Calculated Property

        public Teacher()
        {
            _students = new List<Student>();
        }
    }
}
