using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> animali = new List<string> {"cane", "gatto", "topo", "tigre"};

        // Caso 1: SingleOrDefault - Unico elemento presente
        string animale1 = "cane";
        Console.WriteLine($"Test di SingleOrDefault per '{animale1}': {TestSingleOrDefault(animali, animale1)}");

        // Caso 2: SingleOrDefault - Nessun elemento presente
        string animale2 = "leone";
        Console.WriteLine($"Test di SingleOrDefault per '{animale2}': {TestSingleOrDefault(animali, animale2)}");

        // Caso 3: SingleOrDefault - Duplicati presenti
        string animale3 = "gatto";
        Console.WriteLine($"Test di SingleOrDefault per '{animale3}': {TestSingleOrDefault(animali, animale3)}");

        // Caso 4: FirstOrDefault - Unico elemento presente
        string animale4 = "topo";
        Console.WriteLine($"Test di FirstOrDefault per '{animale4}': {TestFirstOrDefault(animali, animale4)}");

        // Caso 5: FirstOrDefault - Nessun elemento presente
        string animale5 = "panda";
        Console.WriteLine($"Test di FirstOrDefault per '{animale5}': {TestFirstOrDefault(animali, animale5)}");
    }

    static bool TestSingleOrDefault(List<string> animali, string animale)
    {
        try
        {
            string risultato = animali.SingleOrDefault(a => a.Equals(animale, StringComparison.OrdinalIgnoreCase));
            return risultato != null;
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine($"Errore: Più di un '{animale}' presente nella lista.");
            return false;
        }
    }

    static bool TestFirstOrDefault(List<string> animali, string animale)
    {
        string risultato = animali.FirstOrDefault(a => a.Equals(animale, StringComparison.OrdinalIgnoreCase));
        return risultato != null;
    }
}
