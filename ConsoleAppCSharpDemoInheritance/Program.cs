using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Name = "Joe the Horse";
            animal.MakeNoise();

            Pig pig = new Pig();
            pig.Name = "Oinky the Pig";
            pig.MakeNoise();

            //This is where virtual and override really come in
            Animal pig2 = new Pig();
            pig2.Name = "Mr. Bacon";
            pig2.MakeNoise();

            Console.ReadKey();
        }
    }
}
