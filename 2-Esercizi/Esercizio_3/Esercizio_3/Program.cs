using System;
using System.Collections.Generic;

class Program
{
    static Queue<string> listaSong = new Queue<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nOpzioni:");
            Console.WriteLine("1. Accoda");
            Console.WriteLine("2. Togli Da Coda");
            Console.WriteLine("3. Visualizza in Anteprima");
            Console.WriteLine("4. Esci");


            string scelta = Console.ReadLine();

            switch (scelta)
            {
                case "1":
                    Console.Write("\nInserisci una stringa da accodare: ");
                    string elemento = Console.ReadLine();

                    if (!string.IsNullOrEmpty(elemento))
                    {
                        Accoda(elemento);
                        Console.WriteLine($"\n'{elemento}' accodato nella coda.");
                    }
                    else
                    {
                        Console.WriteLine("\nErrore: La stringa da accodare non può essere vuota.");
                    }
                    break;

                case "2":
                    string elementoDeaccodato = TogliDaCoda();
                    Console.WriteLine($"\nElemento deaccodato: {elementoDeaccodato}");
                    break;

                case "3":
                    string risultatoAnteprima = VisualizzaAnteprima();
                    Console.WriteLine($"\nRisultato anteprima: {risultatoAnteprima}");
                    break;

                case "4":
                    Console.WriteLine("\nUscita dal programma.");
                    return;

                default:
                    Console.WriteLine("\nScelta non valida. Inserisci un'opzione valida");
                    break;
            }
        }
    }

    static void Accoda(string elemento)
    {
        listaSong.Enqueue(elemento);
    }

    static string TogliDaCoda()
    {
        if (listaSong.Count > 0)
        {
            return listaSong.Dequeue();
        }
        else
        {
            return "\nLa lista è gia vuota.";
        }
    }

    static string VisualizzaAnteprima()
    {
        if (listaSong.Count > 0)
        {
            return listaSong.Peek();
        }
        else
        {
            return "\nLa lista è vuota.";
        }
    }
}
