class Program
{
    static void Main(string[] args)
    {

        int input1;
        int input2;

        Console.Write("Inserisci il primo numero: ");
        if (!int.TryParse(Console.ReadLine(), out input1))
        {
            Console.WriteLine("Input non valido. Assicurati di inserire un valore numerico valido.");
            return;
        }

        Console.Write("Inserisci il secondo numero: ");
        if (!int.TryParse(Console.ReadLine(), out input2))
        {
            Console.WriteLine("Input non valido. Assicurati di inserire un valore numerico valido.");
            return;
        }

        List<double> numeriDouble = new List<double> { 0.1, 0.3, 0.5, 0.7, 1.0, 1.12 };

        if (input1 < 0 || input2 >= numeriDouble.Count || input1 > input2 + 1)
        {
            Console.WriteLine("Input 1 o Input 2 non validi");
            return;
        }

        List<double> indexList = numeriDouble.GetRange(input1, input2 - input1 + 1);

        double somma = indexList.Sum();
        double media = indexList.Average();
        int numeroElementi = indexList.Count();

        Console.WriteLine($"\nLa somma è: {somma}");
        Console.WriteLine($"\nLa Media è: {media}");
        Console.WriteLine($"\nil totali di numeri nella lista sono: {numeroElementi}");
    }
}
