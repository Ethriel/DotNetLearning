using System.Collections.Generic;
using System.Linq;

namespace TeacherStudent.Model
{
    public class Teacher
    {
        public ICollection<Student> Students;
        public double Rate;

        public Teacher()
        {
            Students = new List<Student>();
        }

        public double GetRate()
        {
            //Rate = Students.Sum(st => st.GetMeanMarks());

            //return Rate;

            return Students.Sum(st => st.GetMeanMarks());
        }
    }
}
