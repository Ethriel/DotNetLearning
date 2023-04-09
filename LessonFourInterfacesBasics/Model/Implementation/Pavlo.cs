using LessonFourInterfacesBasics.Model.Abstraction;
using System;

namespace LessonFourInterfacesBasics.Model.Implementation
{
    public class Pavlo : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{FirstName} likes to:\nPounce to window\n";
        }

        public void DoJob()
        {
            Console.WriteLine(this);
        }
    }
}
