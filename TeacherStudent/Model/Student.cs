using System.Collections.Generic;
using System.Linq;

namespace TeacherStudent.Model
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public ICollection<Subject> Subjects;

        public Student()
        {
            Subjects = new List<Subject>();
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Subjects = new List<Subject>();
        }

        override public string ToString()
        {
            return $" FirstName: {FirstName}, LastName: {LastName}";
        }

        public double GetMeanMarks()
        {
            //var result = 0.0;
            //var subjectsSum = Subjects.Sum(sj => sj.mark);
            //var subjectMarksMean = subjectsSum / Subjects.Count;
            //result = subjectMarksMean;

            //return result;

            return Subjects.Sum(sj => sj.mark) / Subjects.Count;
        }
    }
}
