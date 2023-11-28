class Program
{
    static void Main(string[] args)
    {

        List<int> numeriCasuali = GeneraNumeriCasuali(1000);

        var numeriDispari = numeriCasuali.Where(numero => numero % 2 != 0);

        Console.WriteLine("\nNumeri dispari:");
        StampaNumeri(numeriDispari.ToList());

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