using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador_Csharp
{
    class Observador : IObervador
    {

        private string Nombre;
        private Sujeto Sujeto;

        public Observador(string Pnombre, Sujeto Psujeto)
        {
            Nombre = Pnombre;
            Sujeto = Psujeto;

            Sujeto.Suscribir(this);
        }



        public void Update (string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"push, {Nombre}-{mensaje}");

        }

        public void UpdatePull()
        {
            int n = Sujeto.N;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"pull, {Nombre}-{n}"); 
        }
    }
}
