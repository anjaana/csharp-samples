using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_samples.Interfaces
{
    public static class TryInterfaces
    {
        public static void Do()
        {
            // Declare an interface instance.
            ISampleInterface obj = new ImplementationClass();

            // Call the member.
            obj.SampleMethod();
        }
    }
}
