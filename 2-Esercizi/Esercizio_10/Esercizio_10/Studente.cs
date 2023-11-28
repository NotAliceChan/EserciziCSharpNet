using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esercizio_10;

namespace Esercizio_10
{
    internal class Studente
    {
        public string Nome { get; set; }
        public int Voto { get; set; }


        public Studente(string nome, int voto)
        {
            this.Nome = nome;
            this.Voto = voto;
        }

    }
}
