class Program
{

    static void Main(string[] args)
    {
        List<double> numeriDouble = new List<double> { 0.1, 0.3, 0.5, 0.7, 1.0, 1.12 };

        double somma = numeriDouble.Sum();

        double media = numeriDouble.Average();

        int numeroElementi = numeriDouble.Count();

        Console.WriteLine($"\nLa somma è: {somma}");

        Console.WriteLine($"\nLa Media è: {media}");

        Console.WriteLine($"\nil totali di numeri nella lista sono: {numeroElementi}");


    }
}