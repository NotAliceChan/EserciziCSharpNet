using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_7
{
    internal class Class1
    {
        public int CallPublic = 1;
        private int Callprivate = 2;
        protected int Callprotected = 3;
        internal int Callinternal = 4;

        public void publcall()
        {
            Console.WriteLine($"Questa è una Chiamata pubblica: {CallPublic}");
        }
        public void priCall()
        {
            Console.WriteLine($"Questa è una Chiamata privata: {Callprivate}");
        }
        public void intCall()
        {
            Console.WriteLine($"Questa è una Chiamata interna: {Callinternal}");
        }
        public void protCall()
        {
            Console.WriteLine($"Questa è una Chiamata protetta: {Callprotected}");
        }

        public Class1(int CallPublic, int Callprivate, int Callprotected, int Callinternal)
        {
            this.CallPublic = CallPublic;
            this.Callprivate = Callprivate;
            this.Callprotected = Callprotected;
            this.Callinternal = Callinternal;
        }

        public Class1()
        {

        }
    }
}