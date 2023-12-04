using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    internal class MyQueue<T>
    {

        private LinkedList<T> items = new LinkedList<T> ();


        public void Enqueue(T item)
        {
            items.AddLast(item);
        }

        public T Dequeue()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("La coda è vuota");
            }

            T item = items.First.Value;
            items.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("La Coda è Vuota");
            }

            return items.First.Value;
        }

    }
}
