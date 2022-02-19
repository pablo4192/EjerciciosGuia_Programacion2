using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface_Ej02
{
    public interface IAfip
    {
        public decimal Impuestos { get; }

        decimal AplicarImpuestos();

    }
}
