using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton
{
    class Singleton
    {

        private static Singleton Instancia;

        private string Modelo { get; set; }

        private int Año { get; set; }

        private string Color { get; set; }

        private string Marca { get; set; }

        private Singleton()
        {
            Modelo = "????";

            Año = 0;

            Color = "????";

            Marca = "????";


        }

        public static Singleton ObtenerInstancia()
        {

            if (Instancia == null)
            {
                Instancia = new Singleton();
            }

            return Instancia;
        }


        public void CogerModelo(string Vmodelo)
        {
            Modelo = Vmodelo;

           
        }

        public void CogerAño(int Vaño)
        {
            Año = Vaño;


        }

        public void CogerColor( string Vcolor)
        {
            Color = Vcolor;


        }

        public void CogerMarca( string Vmarca)
        {

            Marca = Vmarca;


        }


        public override string ToString()
        {
            return string.Format($"el modelo del vehiculo es: {Modelo}, Su año es: {Año}, Su Color es: {Color},  su Marca es: {Marca} ");
        }







    }


 
}
