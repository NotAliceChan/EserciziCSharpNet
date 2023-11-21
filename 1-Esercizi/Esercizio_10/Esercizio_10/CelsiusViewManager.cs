using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_10
{
    public class CelsiusViewManager
    {
        private CelsiusLogicManager logicManager;

        public CelsiusViewManager()
        {
            logicManager = new CelsiusLogicManager();
        }

        public void WelcomeMenu()
        {
            Console.WriteLine("\nBenvenuto nel convertitore di gradi Celsius e Fahrenheit");
            Console.WriteLine("[1] - Converti da Celsius a Fahrenheit");
            Console.WriteLine("[2] - Converti da Fahrenheit a Celsius");

            Dictionary<char, Action> welcomeMenuActions = new()
        {
            {'1', logicManager.ConvertCelsiusToFahrenheit },
            {'2', logicManager.ConvertFahrenheitToCelsius },
            // Aggiungi altre opzioni se necessario
        };

            char choice = GetMenuChoice();
            if (welcomeMenuActions.ContainsKey(choice))
            {
                welcomeMenuActions[choice].Invoke();
            }
            else
            {
                Console.WriteLine("Scelta non valida. Riprova.");
            }
        }

        private char GetMenuChoice()
        {
            Console.WriteLine("Inserisci il numero corrispondente all'azione desiderata: ");
            char choice;
            while (!char.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Inserisci un carattere valido.");
            }
            return choice;
        }
    }
}