using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Polimorfismo_Ej01
{
    public class SobreSobreescrito: Sobreescrito
    {
        public SobreSobreescrito(): base()
        {

        }

        public override string MiPropiedad 
        { 
            get { return base.miAtributo; } 
        }

        public override string MiMetodo()
        {
            return MiPropiedad;
        }
    }
}
