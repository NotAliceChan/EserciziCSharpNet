Console.WriteLine("inserisci la parola da far girare");

string? userWord = Console.ReadLine();

if (string.IsNullOrWhiteSpace(userWord))
{
    Console.WriteLine("Input non valido. La stringa inserita è nulla.");
    return;
}

char[] frasedaInvertire = userWord.ToCharArray();
Array.Reverse(frasedaInvertire);
string fraseInvertita = new string(frasedaInvertire);

Console.WriteLine("Parola invertita: " + fraseInvertita);