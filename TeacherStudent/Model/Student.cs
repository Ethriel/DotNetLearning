using System.Collections.Generic;

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
    }
}
