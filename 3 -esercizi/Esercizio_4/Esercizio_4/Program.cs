class Program
{
    static void Main(string[] args)
    {

        List<int> numeriCasuali = GeneraNumeriCasuali(1000);

        var numeriDa1Carattere = numeriCasuali.Where(numero => numero.ToString().Length == 1).ToList();
        var numeriDa2Carattere = numeriCasuali.Where(numero => numero.ToString().Length == 2).ToList();
        var numeriDa3Carattere = numeriCasuali.Where(numero => numero.ToString().Length == 3).ToList();


        Console.WriteLine("\nNumeri da 1 Carattere;");
        StampaNumeri(numeriDa1Carattere);

        Console.WriteLine("\nNumeri da 2 Caratteri;\n");
        StampaNumeri(numeriDa2Carattere);

        Console.WriteLine("\nNumeri da 3 Caratteri;\n");
        StampaNumeri(numeriDa3Carattere);
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