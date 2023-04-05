using System.Collections.Generic;

namespace TeacherStudent.Model
{
    public class Teacher
    {
        public ICollection<Student> Students;

        public Teacher()
        {
            Students = new List<Student>();
        }
    }
}
