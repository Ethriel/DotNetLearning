using LessonFourInterfacesBasics.Model.Abstraction;
using System;

namespace LessonFourInterfacesBasics.Model.Implementation
{
    public class Danik : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} likes to:\nSuck pistrun\n";
        }

        public void DoJob()
        {
            Console.WriteLine(this);
        }
    }
}
