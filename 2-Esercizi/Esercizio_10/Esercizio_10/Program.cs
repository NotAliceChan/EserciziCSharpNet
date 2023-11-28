using Esercizio_10;
using System;
class Program
{

    static void Main(string[] args)
    {
        List<Studente> studenti = new List<Studente>
        {
            new Studente("Alice", 10),
            new Studente("Willy", 10),
            new Studente("Davide", 8),
            new Studente("Alessio", 4),
            new Studente("Mario", 10)
        };

        int votoPiuAlto = studenti.Max(studente => studente.Voto);

        IEnumerable<Studente> topStudente = studenti.Where(studente => studente.Voto == votoPiuAlto);

        int topStudenti = topStudente.Count();

        Console.WriteLine($"Il voto piu alto: {votoPiuAlto}");

        if(topStudenti == 1)
        {
            Studente studenteConVotoPiuAlto = topStudente.First();
            Console.WriteLine($"Lo studente con il voto più alto è: {studenteConVotoPiuAlto.Nome}");
        }
        else
        {
            Console.WriteLine("I studenti con il voto piu alto sono:");
            foreach (var studente in topStudente)
            {
                Console.WriteLine($"{studente.Nome}: {studente.Voto}");
            }
        }
    }
}
