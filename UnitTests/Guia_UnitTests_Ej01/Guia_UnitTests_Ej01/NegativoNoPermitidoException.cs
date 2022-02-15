using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_UnitTests_Ej01
{
    public class NegativoNoPermitidoException: Exception
    {
        public NegativoNoPermitidoException(string mensaje): base(mensaje)
        {

        }
    }
}
