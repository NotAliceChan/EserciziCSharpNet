using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_9
{
    internal class Studente
    {
        public string Nome { get; set; }
        public int Voto { get; set; }

        public Studente(string Nome, int Voto)
        {
            this.Nome = Nome;
            this.Voto = Voto;
        }
    }
}