using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_10
{
    public class CelsiusLogicManager
    {
        public void ConvertCelsiusToFahrenheit()
        {
            Console.WriteLine("\nInserisci la temperatura in gradi Celsius: ");
            if (double.TryParse(Console.ReadLine(), out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"{celsius} gradi Celsius corrispondono a {fahrenheit} gradi Fahrenheit.");
            }
            else
            {
                Console.WriteLine("Inserisci un numero valido.");
            }
        }

        public void ConvertFahrenheitToCelsius()
        {
            Console.WriteLine("\nInserisci la temperatura in gradi Fahrenheit: ");
            if (double.TryParse(Console.ReadLine(), out double fahrenheit))
            {
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine($"{fahrenheit} gradi Fahrenheit corrispondono a {celsius} gradi Celsius.");
            }
            else
            {
                Console.WriteLine("Inserisci un numero valido.");
            }
        }
    }
}
