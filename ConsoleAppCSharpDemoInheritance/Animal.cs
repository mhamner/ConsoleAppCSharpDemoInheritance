using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInheritance
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void MakeNoise()
        //public void MakeNoise()
        {
            Console.WriteLine("NOISE!");
        }
    }
}
