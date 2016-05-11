using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_samples.Interfaces.understanding
{
    public class Cat : IInjectable
    {
        public string Name { get; set; }

        public void TakeInjection()
        {
            Console.WriteLine("Injection is done");
        }
    }
}
