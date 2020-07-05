using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaAlcoholica bebidaAlcoholica1 = Creador.CreadorBebida(Creador.VINO_TINTO);
            Console.WriteLine(bebidaAlcoholica1.CuantoMeEmborrachoPorHora());

            Console.ReadKey();

        }
    }
}
