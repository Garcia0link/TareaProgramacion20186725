using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Csharp
{
    public class Creador
    {

        public const int VINO_TINTO = 1;
        public const int CERVEZA = 2;

        public static  BebidaAlcoholica CreadorBebida(int Tipo )
        {
            switch (Tipo)
            {
                case VINO_TINTO:
                    return new VinoTinto();
                case CERVEZA:
                    return new cerveza();

                default: return null;
            }
        }


    }
}
