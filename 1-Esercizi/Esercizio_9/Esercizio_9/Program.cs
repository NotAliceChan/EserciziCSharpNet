Console.WriteLine("Inserisci il numero Celsius da convertire in Fahrenheit");

string? num = Console.ReadLine();

if (int.TryParse(num, out int celsius))
{
    int fahrenheit = celsius * 9 / 5 + 32;
    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit + "°F");
}
else
{
    Console.WriteLine("Inserimento non valido");
}