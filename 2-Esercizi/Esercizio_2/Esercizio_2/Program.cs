using System;
using System.Collections;

class Program
{
    static void Main()
    {

        ArrayList arrayList = new ArrayList();

        arrayList.Add(24);
        arrayList.Add("Ciao");
        arrayList.Add(true);

        Console.WriteLine("Contenuto della lista!\n");
        
        foreach (var i in arrayList) 
        {
            Console.WriteLine(i);
        }
    }
}