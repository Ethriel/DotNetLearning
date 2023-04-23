using LessonFive.InterfacesInteraction.Abstraction.BaseInterfaces;
using LessonFive.InterfacesInteraction.Abstraction.ChildInterfaces;
using LessonFive.InterfacesInteraction.Implementation;
using System;
using System.Collections.Generic;

namespace LessonFive
{
    public class MetalWorkerHandler
    {
        public void ProcessMetalForming()
        {
            #region Base_Implementation
            var metalWorkerBase = new MetalWorker();
            metalWorkerBase.TemperaturePrepare();
            metalWorkerBase.LoadMetal();
            metalWorkerBase.MeltMetal();
            metalWorkerBase.DeformMetal();
            #endregion

            #region Extended_Implementation
            IMetalWorkFirst metalWorkerExtended = new MetalWorker();
            metalWorkerExtended.TemperaturePrepare();
            (metalWorkerExtended as IMetalWorkSecond).LoadMetal();
            (metalWorkerExtended as IMetalWorkThird).MeltMetal();
            (metalWorkerExtended as IMetalWorkFourth).DeformMetal();
            #endregion
        }

        public void LessonFourFirstMetalWorker()
        {
            Console.WriteLine("FIRST WORKER");
            IMetalWorkFourth worker = new MetalWorker();
            worker.TemperaturePrepare();
            worker.LoadMetal();
            worker.MeltMetal();
            worker.DeformMetal();
        }

        public void LessonFourSecondtMetalWorker()
        {
            Console.WriteLine("SECOND WORKER");
            IMetalWorkFourth worker = new MetalWorkerSecond();
            worker.TemperaturePrepare();
            worker.LoadMetal();
            worker.MeltMetal();
            worker.DeformMetal();
        }
        #region
        public void LessonFourMetalWorkers()
        {
            Console.WriteLine("FIRST");

            ICollection<IMetalWorkFirst> metalWorkersFirst = new List<IMetalWorkFirst>();
            metalWorkersFirst.Add(GetMetalWorkerFourthFirst());
            metalWorkersFirst.Add(GetMetalWorkerThirdFirst());
            metalWorkersFirst.Add(GetMetalWorkerSecondFirst());
            metalWorkersFirst.Add(GetMetalWorkerFirstFirst());

            foreach (var ml in metalWorkersFirst)
            {
                Console.WriteLine(ml);
            }

            Console.WriteLine("SECOND");

            ICollection<IMetalWorkFirst> metalWorkersSecond = new List<IMetalWorkFirst>();
            metalWorkersSecond.Add(GetMetalWorkerFourthSecond());
            metalWorkersSecond.Add(GetMetalWorkerThirdSecond());
            metalWorkersSecond.Add(GetMetalWorkerSecondSecond());
            metalWorkersSecond.Add(GetMetalWorkerSecondFirst());

            foreach (var ml in metalWorkersSecond)
            {
                Console.WriteLine(ml);
            }
        }

        public IMetalWorkFourth GetMetalWorkerFourthFirst()
        {
            IMetalWorkFourth metalWorker = new MetalWorker();

            return metalWorker;
        }

        public IMetalWorkFourth GetMetalWorkerFourthSecond()
        {
            IMetalWorkFourth metalWorker = new MetalWorkerSecond();

            return metalWorker;
        }

        public IMetalWorkThird GetMetalWorkerThirdFirst()
        {
            IMetalWorkThird metalWorker = new MetalWorker();

            return metalWorker;
        }

        public IMetalWorkThird GetMetalWorkerThirdSecond()
        {
            IMetalWorkThird metalWorker = new MetalWorkerSecond();

            return metalWorker;
        }

        public IMetalWorkSecond GetMetalWorkerSecondFirst()
        {
            IMetalWorkSecond metalWorker = new MetalWorker();

            return metalWorker;
        }

        public IMetalWorkSecond GetMetalWorkerSecondSecond()
        {
            IMetalWorkSecond metalWorker = new MetalWorkerSecond();

            return metalWorker;
        }

        public IMetalWorkFirst GetMetalWorkerFirstFirst()
        {
            IMetalWorkFourth metalWorker = new MetalWorker();

            return metalWorker;
        }

        public IMetalWorkFirst GetMetalWorkerFirstSecond()
        {
            IMetalWorkFirst metalWorker = new MetalWorkerSecond();

            return metalWorker;
        }
        #endregion
    }
}
