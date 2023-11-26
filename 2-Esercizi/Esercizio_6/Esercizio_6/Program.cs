using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            string percorsoFile = OttieniPercorsoFileDaUtente();

            string contenutoFile = LeggiContenutoFile(percorsoFile);

            List<string> parole = TokParole(contenutoFile);

            Dictionary<string, int> conteggioParole = CreazioneConteggio(parole);

            VisualizzaRisultati(conteggioParole);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Si è verificato un errore: {ex.Message}");
        }
    }

    static string OttieniPercorsoFileDaUtente()
    {
        Console.Write("inserisci il percorso del file .txt");
        string? percorsoFile = Console.ReadLine();

        if(!File.Exists(percorsoFile)) 
        {
            throw new FieldAccessException("il file non esiste!");
        }

        return percorsoFile;

    }

    static string LeggiContenutoFile(string percorsoFile)
    {
        string contenutoFile;

        using (StreamReader lettore = new StreamReader(percorsoFile))
        {
            contenutoFile = lettore.ReadToEnd();
        }

        return contenutoFile;
    }


    static List<string> TokParole(string testo)
    {
        string[] arrayParole = testo.Split(',', '\n');
        List<string> result = new List<string>();

        foreach (string parola in arrayParole) 
        {
           result.Add(parola.ToLower());    
        }

        return result;
    }


    static Dictionary<string, int> CreazioneConteggio(List<string> parole)
    {
        Dictionary<string, int> conteggioDictionary = new Dictionary<string, int>();

        foreach(string parola in parole)
        {
           if(conteggioDictionary.ContainsKey(parola))
            {
                conteggioDictionary[parola]++;
            }
           else
            {
                conteggioDictionary[parola] = 1;
            }
        }

        return conteggioDictionary;
    }
    static void VisualizzaRisultati(Dictionary<string, int> dizionarioConteggio)
    {
        Console.WriteLine("Risultati:");
        foreach (var coppia in dizionarioConteggio)
        {
            Console.WriteLine($"{coppia.Key}: {coppia.Value} volte");
        }
    }
}