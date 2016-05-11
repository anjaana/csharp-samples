using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_samples.Interfaces.understanding
{
    public static class TryToUnderstandInterfaces
    {
        public static void Do()
        {
            var hospital = new Hospital();
            IInjectable mySickDog = new Dog();

            hospital.SickPatient = mySickDog;
            hospital.HealSickPatient();

            IInjectable mySickCat = new Cat();
            hospital.SickPatient = mySickCat;

            hospital.HealSickPatient();
        }
    }
}
