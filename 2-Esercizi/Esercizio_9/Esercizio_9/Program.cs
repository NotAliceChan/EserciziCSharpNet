using Esercizio_9;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Studente> listaStudenti = new List<Studente>();

        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Inserisci il nome dello studente {i}: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Il nome non può essere vuoto. Riprova.");
                i--; 
                continue; 
            }

            Console.Write($"Inserisci il voto dello studente {i}: ");

            if (int.TryParse(Console.ReadLine(), out int voto))
            {
                Studente studente = new Studente(nome, voto);
                listaStudenti.Add(studente);
            }
            else
            {
                Console.WriteLine("Input non valido. Inserire un numero intero per il voto.");
                i--; 
            }
        }

        double sommaVoti = 0;
        foreach (var studente in listaStudenti)
        {
            sommaVoti += studente.Voto;
        }
        double votoMedio = sommaVoti / listaStudenti.Count;

        Console.WriteLine($"Il voto medio della classe è: {votoMedio}");

        
        Studente studenteMigliore = TrovaStudenteMigliore(listaStudenti);

        Console.WriteLine($"Lo studente con il voto più alto è: {studenteMigliore.Nome} con un voto di {studenteMigliore.Voto}");
    }

    static Studente TrovaStudenteMigliore(List<Studente> studenti)
    {
        Studente migliore = studenti[0];
        foreach (var studente in studenti)
        {
            if (studente.Voto > migliore.Voto)
            {
                migliore = studente;
            }
        }
        return migliore;
    }
}