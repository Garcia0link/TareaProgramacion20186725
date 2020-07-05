using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador_Csharp
{
    class Sujeto
    {
        private List<IObervador> obervadores = new List<IObervador>();

        private string mensaje;

        private Random rnd = new Random();

        private int n;

        public int N { get => n; set => n = value; }

        public void Suscribir(IObervador suscrito)
        {
            obervadores.Add(suscrito);
        }

        public void Desuscribir(IObervador suscrito)
        {
            obervadores.Remove(suscrito);

        }

        public void Notificar()
        {
            foreach(IObervador o in obervadores)
            {
                o.Update(mensaje);
            }

            


        }

        public void Trabajo()
        {
            n = rnd.Next(10);

            if (n%2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---Nuevo estado valido---");
                mensaje = string.Format($"El nuevo valor es {n}");
                Notificar();
            }

        }
    }
}
