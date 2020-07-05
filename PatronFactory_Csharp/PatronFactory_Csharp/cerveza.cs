using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronFactory_Csharp
{
    class cerveza : BebidaAlcoholica
    {

        public override int CuantoMeEmborrachoPorHora()
        {
            return 5;
        }

    }
}
