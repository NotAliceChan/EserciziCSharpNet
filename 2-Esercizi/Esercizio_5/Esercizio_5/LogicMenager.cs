using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5
{
    internal class LogicMenager
    {
        private LinkedList<StazioneFerroviaria> percorsoFerroviario;

        public LogicMenager()
        {
            percorsoFerroviario = new LinkedList<StazioneFerroviaria>();
        }

        public void AggiungiStazione(string nomeStazione)
        {
            StazioneFerroviaria nuovaStazione = new StazioneFerroviaria(nomeStazione);
            percorsoFerroviario.AddLast(nuovaStazione);
            Console.WriteLine($"Stazione '{nomeStazione}' aggiunta al percorso.");
        }

        public void RimuoviStazione(string nomeStazione)
        {
            StazioneFerroviaria stazioneDaRimuovere = percorsoFerroviario.FirstOrDefault(stazione => stazione.Nome == nomeStazione);

            if (stazioneDaRimuovere != null)
            {
                percorsoFerroviario.Remove(stazioneDaRimuovere);
                Console.WriteLine($"Stazione '{nomeStazione}' rimossa dal percorso.");
            }
            else
            {
                Console.WriteLine($"Stazione '{nomeStazione}' non trovata nel percorso.");
            }
        }
        public void VisualizzaPercorso()
        {
            Console.WriteLine("Percorso ferroviario:");
            foreach (var stazione in percorsoFerroviario)
            {
                Console.WriteLine($"{ stazione.Nome}\n");
            }
        }
    }
}
