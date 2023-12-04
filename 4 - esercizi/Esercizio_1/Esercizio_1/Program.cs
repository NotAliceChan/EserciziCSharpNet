using Esercizio_1;

class Program
{
    static void Main()
    {

        MyQueue<int> myQueue = new MyQueue<int>();

        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);

        Console.WriteLine("Elemento in testa alla coda: " + myQueue.Peek());

        int dequeuedItem = myQueue.Dequeue();
        Console.WriteLine("Elemento rimosso dalla coda: " + dequeuedItem);

        Console.WriteLine("Nuovo elemento in testa alla coda: " + myQueue.Peek());
    }
}
