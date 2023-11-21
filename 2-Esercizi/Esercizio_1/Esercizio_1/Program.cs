Console.WriteLine("Inserisci un valore 10 volte:");

List<string> listaNumeri = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Inserisci il valore {i + 1}:");
    string input = Console.ReadLine();
    listaNumeri.Add(input);
}

Console.WriteLine("\nNumeri al contrario:");
listaNumeri.Reverse();
Console.WriteLine(string.Join(Environment.NewLine, listaNumeri));
