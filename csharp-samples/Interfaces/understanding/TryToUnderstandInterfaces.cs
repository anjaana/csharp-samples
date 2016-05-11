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
            var mySickDog = new Dog();

            hospital.SickDog = mySickDog;
            hospital.HealSickPatient();

            var mySickCat = new Cat();
            hospital.SickCat = mySickCat;

            hospital.HealSickPatient();
        }
    }
}
