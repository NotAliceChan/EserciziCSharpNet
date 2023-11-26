HashSet<string> strings = new HashSet<string>();



for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Inserisci un valore");
    strings.Add(Console.ReadLine());
}


foreach (string s in strings)
{
    strings.Add(s);
}

