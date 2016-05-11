using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_samples.Interfaces.understanding
{
    public class Hospital
    {
        public Dog SickDog { get; set; }
        public Cat SickCat { get; set; }

        public void HealSickPatient()
        {
            if (SickCat != null)
            {
                MakeInjectionForCat(SickCat);
            }

            if (SickDog != null)
            {
                MakeInjectionForDog(SickDog);
            }

            SickCat = null;
            SickDog = null;
        }

        private void MakeInjectionForDog(Dog dog)
        {
            dog.TakeInjection();
        }

        private void MakeInjectionForCat(Cat cat)
        {
            cat.TakeInjection();
        }

        private void GivePill()
        {
            // something
        }
    }
}
