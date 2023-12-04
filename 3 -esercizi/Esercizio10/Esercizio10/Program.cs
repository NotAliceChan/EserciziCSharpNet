using Esercizio10;

class Program
{
    static void Main()
    {
        List<int> RandomNumeri = GeneraNumeriRandomici(1000);

        List<NumeroMetaData> MetaDataLista = RandomNumeri
            .Select(numero => new NumeroMetaData(numero))
            .ToList();


        foreach(var metadata in MetaDataLista)
        {
            Console.WriteLine($"Numero: {metadata.Numero}" +
                $"\nNumero Pari: {metadata.TestualePari()} " +
                $"\nNumero Di Caratteri: {metadata.NumeroDiCaratteri}\n");
        }
    }

    static List<int> GeneraNumeriRandomici(int conta)
    {
        Random random = new Random();
        return Enumerable.Range(1, conta).Select(_ => random.Next(1, 1000)).ToList();
    }   
}