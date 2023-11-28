class Program
{
    static void Main(string[] args)
    {

        List<int> numeriCasuali = GeneraNumeriCasuali(1000);

        numeriCasuali.Sort();
        Console.WriteLine("Numeri ordinati\n");
        StampaNumeri(numeriCasuali);
        
        Console.WriteLine("\nNumeri al Contrario\n");
        numeriCasuali.Sort((a, b) => b.CompareTo(a));
        StampaNumeri(numeriCasuali);
    }

    static List<int> GeneraNumeriCasuali(int quantita)
    {
        Random random = new Random();
        List<int> numeriCasuali = new();

        for (int i = 0; i < quantita; i++)
        {
            numeriCasuali.Add(random.Next(1, 1000));
        }

        return numeriCasuali;
    }


    static void StampaNumeri(List<int> numeri)
    {
        foreach (var numero in numeri)
        {
            Console.WriteLine($"numero: {numero}");
        }

    }
}