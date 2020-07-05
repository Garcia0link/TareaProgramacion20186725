using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronObservador_Csharp
{
    interface IObervador
    {

        void Update(string mensaje);

        void UpdatePull();
    }
}
