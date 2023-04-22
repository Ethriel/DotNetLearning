using LessonFive.InterfacesInteraction.Abstraction.ChildInterfaces;
using System;

namespace LessonFive.InterfacesInteraction.Implementation
{
    public class MetalWorkerSecond : IMetalWorkFourth
    {
        public void TemperaturePrepare()
        {
            Console.WriteLine("Second worker: Preparing temperature...");
        }

        public void LoadMetal()
        {
            Console.WriteLine("Second worker: Loading metal...");
        }

        public void MeltMetal()
        {
            Console.WriteLine("Second worker: Melting metal...");
        }

        public void DeformMetal()
        {
            Console.WriteLine("Second worker: Forming metal...");
        }

        public override string ToString()
        {
            return $"My type is: {this.GetType().Name}";
        }
    }
}
