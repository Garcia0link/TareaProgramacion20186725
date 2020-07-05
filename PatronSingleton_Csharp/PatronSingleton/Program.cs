using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    class Program
    {
        static void Main(string[] args)
        {

            Singleton Vehiculo = Singleton.ObtenerInstancia();
            Console.WriteLine("esto es un ejemplo del patron singleton ");
            Console.WriteLine("Digite el modelo del auto: ");

            string VModelo = Console.ReadLine();

            
            Console.WriteLine("Digite la marca: ");

            string VMarca = Console.ReadLine();

            Console.WriteLine("Digite el color: ");

            string VColor = Console.ReadLine();

            Console.WriteLine("Digite el año: ");

            int VAño = int.Parse(Console.ReadLine());






            Vehiculo.CogerModelo(VModelo);
            Vehiculo.CogerAño(VAño);
            Vehiculo.CogerColor(VColor);
            Vehiculo.CogerMarca(VMarca);

             Console.WriteLine(Vehiculo);
            Console.Clear();


            Singleton Vehiculo2 = Singleton.ObtenerInstancia();
            Console.WriteLine("ahora veremos el patron singleton en funcionamiento creando otra instancia de otro vehiculo y viendo como permanecen los antiguos valores ");
            Console.WriteLine("Digite el modelo del auto: ");

            string VModelo2 = Console.ReadLine();


            Console.WriteLine("Digite la marca: ");

            string VMarca2 = Console.ReadLine();

            Console.WriteLine("Digite el color: ");

            string VColor2 = Console.ReadLine();

            Console.WriteLine("Digite el año: ");

            int VAño2 = int.Parse(Console.ReadLine());






            Vehiculo2.CogerModelo(VModelo);
            Vehiculo2.CogerAño(VAño);
            Vehiculo2.CogerColor(VColor);
            Vehiculo2.CogerMarca(VMarca);

            Console.WriteLine(Vehiculo2);

            Console.WriteLine("Tommy Garcia 2018-6725 ");

            Console.ReadKey();
        }
    }
}
