using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numeri = new List<int> { 2,4,6,8,10,12,14,16,18,20 };

        // controlla se sono tutti pari
        bool tuttiPari = numeri.All(num => num % 2 == 0);

        // controlla se sono alcuni dispari
        bool alcuniDispari = numeri.Any(num => num % 2 != 0);


        if (tuttiPari)
        {
            Console.WriteLine("Tutti gli elementi sono pari");
        }
        else if (alcuniDispari)
        {
            Console.WriteLine("Alcuni elementi sono dispari");
        }
    }
}
