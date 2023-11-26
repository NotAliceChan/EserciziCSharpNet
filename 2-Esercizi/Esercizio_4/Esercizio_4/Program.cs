using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> mioStack = new Stack<int>();

   
        Push(mioStack, 1);
        Push(mioStack, 2);
        Push(mioStack, 3);


        Peek(mioStack);


        Pop(mioStack);
        Pop(mioStack);

    
        Peek(mioStack);

        Pop(mioStack);
    }

    static void Push(Stack<int> stack, int valore)
    {
        stack.Push(valore);
        Console.WriteLine($"Push: Aggiunto {valore} allo stack.");
    }

    static void Pop(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int valoreRimosso = stack.Pop();
            Console.WriteLine($"Pop: Rimosso {valoreRimosso} dallo stack.");
        }
        else
        {
            Console.WriteLine("Pop: Impossibile fare Pop da uno stack vuoto.");
        }
    }

    static void Peek(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int valoreInCima = stack.Peek();
            Console.WriteLine($"Peek: Elemento in cima allo stack: {valoreInCima}");
        }
        else
        {
            Console.WriteLine("Peek: Lo stack è vuoto.");
        }
    }
}
