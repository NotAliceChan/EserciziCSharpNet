using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6
{
    internal class Gatto : Animale
    {
        public Gatto(String Name, int Age) : base(Name, Age)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Nome} di {Età} Anni fa meow meow");
        }
    }
}
