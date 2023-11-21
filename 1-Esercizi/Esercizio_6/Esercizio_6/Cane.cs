using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_6
{
    internal class Cane : Animale
    {

        public Cane(String Name, int Age) : base(Name, Age)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"{Nome} di {Età} Anni fa bau bau");
        }
    }
}

