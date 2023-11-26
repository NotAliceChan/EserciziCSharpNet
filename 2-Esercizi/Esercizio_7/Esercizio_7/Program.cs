using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> strings = new HashSet<string>();

        Console.WriteLine("Inserisci il titolo della lista!");
        string titoloLista = Console.ReadLine();

        if (string.IsNullOrEmpty(titoloLista))
        {
            Console.WriteLine("Il titolo della lista non può essere nullo o vuoto. Uscita dal programma.");
            return;
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Inserisci una stringa!");
            strings.Add(Console.ReadLine());
        }

        Console.WriteLine($"\n{titoloLista}\n");

        foreach (var item in strings)
        {
            Console.WriteLine(item);
        }
    }
}
