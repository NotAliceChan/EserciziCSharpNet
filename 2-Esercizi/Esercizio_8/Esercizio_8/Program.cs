using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
     
        List<int> numeriCasuali = GeneraNumeriCasuali(1000, 1, 1000);

  
        TrovaMinimoMassimo(numeriCasuali, out int minimo, out int massimo);

        
        Console.WriteLine($"Valore minimo: {minimo}");
        Console.WriteLine($"Valore massimo: {massimo}");
    }

   
    static List<int> GeneraNumeriCasuali(int lunghezza, int minimo, int massimo)
    {
        Random random = new Random();
        List<int> numeriCasuali = new List<int>();

        for (int i = 0; i < lunghezza; i++)
        {
            numeriCasuali.Add(random.Next(minimo, massimo + 1));
        }

        return numeriCasuali;
    }

    static void TrovaMinimoMassimo(List<int> lista, out int minimo, out int massimo)
    {
        minimo = int.MaxValue;
        massimo = int.MinValue;

        foreach (int numero in lista)
        {
            if (numero < minimo)
                minimo = numero;

            if (numero > massimo)
                massimo = numero;
        }
    }
}
