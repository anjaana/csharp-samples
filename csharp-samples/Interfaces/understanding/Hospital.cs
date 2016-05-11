using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_samples.Interfaces.understanding
{
    public class Hospital
    {
        public IInjectable SickPatient { get; set; }

        public void HealSickPatient()
        {
            if (SickPatient != null)
            {
                MakeInjection(SickPatient);
            }

            SickPatient = null;
        }

        private void MakeInjection(IInjectable patient)
        {
            patient.TakeInjection();
        }

        private void GivePill()
        {
            // something
        }
    }
}
