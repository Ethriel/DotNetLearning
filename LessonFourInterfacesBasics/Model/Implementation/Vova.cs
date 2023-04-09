using LessonFourInterfacesBasics.Model.Abstraction;
using System;

namespace LessonFourInterfacesBasics.Model.Implementation
{
    public class Vova : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} likes to:\nPenetrate young boys in programming\n";
        }

        public void DoJob()
        {
            Console.WriteLine(this);
        }
    }
}
