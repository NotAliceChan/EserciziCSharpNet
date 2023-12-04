using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio10
{
    internal class NumeroMetaData
    {

        public int Numero { get; }
        public bool Pari { get; }
        public int NumeroDiCaratteri { get; }

        public NumeroMetaData(int numero)
        {
            Numero = numero;
            Pari = numero % 2 == 0;
            NumeroDiCaratteri = numero.ToString().Length;
        }


        public string TestualePari()
        {
            return Pari ? "si" : "no";
        }

    }
}
