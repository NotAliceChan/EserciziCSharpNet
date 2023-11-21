using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string percorsoFile = "C:\\Users\\Alice\\Desktop\\CompitiNet\\EserciziCSharpNet\\Esercizi_1_10\\Esercizio_5\\Esercizio_5\\Test.txt";

            string contenutoFile = File.ReadAllText(percorsoFile);

            Console.WriteLine("Verifica Di Testo\n");
            Console.WriteLine(contenutoFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Si è verificato un errore: {ex.Message}");
        }
    }
}
