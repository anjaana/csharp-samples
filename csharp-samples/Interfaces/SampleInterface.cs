using System;

namespace csharp_samples.Interfaces
{
    interface ISampleInterface
    {
        void SampleMethod();
    }

    // интерфейс либо наследуется либо реализовуется(по сути одно и тоже)
    class ImplementationClass : ISampleInterface
    {
        public string SomeField { get; set; }
        // Явная реализация интерфейса
        void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("I am SampleInterface realization.");
        }

        // не явная реализация интерфейса
        //public void SampleMethod()
        //{
        //    Console.WriteLine("I am SampleInterface realization.");
        //}
    }
}
