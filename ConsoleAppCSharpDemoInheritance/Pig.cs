using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCSharpDemoInheritance
{
    public class Pig : Animal
    {
        public string FavoriteMudType { get; set; }

        public override void MakeNoise()
        //public new void MakeNoise()
        {
            Console.WriteLine("OINK!");
        }
    }
}
