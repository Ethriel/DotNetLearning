﻿namespace LessonFourInterfacesBasics.Model.Abstraction
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        void DoJob();
    }
}