using LessonFive.InterfacesInteraction.Abstraction.ChildInterfaces;
using System;

namespace LessonFive.InterfacesInteraction.Implementation
{
    public class MetalWorker : IMetalWorkFourth
    {
        public void TemperaturePrepare()
        {
            Console.WriteLine("First worker: Preparing temperature...");
        }

        public void LoadMetal()
        {
            Console.WriteLine("First worker: Loading metal...");
        }

        public void MeltMetal()
        {
            Console.WriteLine("First worker: Melting metal...");
        }

        public void DeformMetal()
        {
            Console.WriteLine("First worker: Forming metal...");
        }

        public override string ToString()
        {
            return $"My type is: {this.GetType().Name}";
        }
    }
}
