using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_5
{
    internal class ViewMenager
    {
        private LogicMenager logicMenager;

        public ViewMenager()
        {
            logicMenager = new LogicMenager();
        }

        public void WelcomeMenu()
        {
            Console.WriteLine("\nBenvenuto nel gestore del percorso ferroviario");
            Console.WriteLine("[1] - Aggiungi stazione");
            Console.WriteLine("[2] - Rimuovi stazione");
            Console.WriteLine("[3] - Visualizza percorso");
            Console.WriteLine("[4] - Esci");

            Dictionary<char, Action> welcomeMenuActions = new()
        {
            {'1', AggiungiStazione },
            {'2', RimuoviStazione },
            {'3', VisualizzaPercorso },
            {'4', () => Environment.Exit(0) }
        };

            Console.Write("Scelta: ");
            char scelta = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (welcomeMenuActions.TryGetValue(scelta, out var action))
            {
                action.Invoke();
            }
            else
            {
                Console.WriteLine("Scelta non valida. Riprova.");
            }
        }

        private void AggiungiStazione()
        {
            Console.Write("Inserisci il nome della stazione: ");
            string nomeStazione = Console.ReadLine();
            logicMenager.AggiungiStazione(nomeStazione);
        }

        private void RimuoviStazione()
        {
            Console.Write("Inserisci il nome della stazione da rimuovere: ");
            string nomeStazione = Console.ReadLine();
            logicMenager.RimuoviStazione(nomeStazione);
        }

        private void VisualizzaPercorso()
        {
            logicMenager.VisualizzaPercorso();
        }
    }
}
