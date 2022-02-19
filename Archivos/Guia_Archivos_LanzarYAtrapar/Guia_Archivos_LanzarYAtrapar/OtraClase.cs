using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Archivos_LanzarYAtrapar
{
    public class OtraClase
    {
        public OtraClase()
        {
            Metodo();
        }

        public void Metodo()
        {
            try
            {
                MiClase miClase = new MiClase("Excepcion");
            }
            catch (UnaExcepcion e)
            {
                throw new MiExcepcion("(3) Capturo UnaExcepcion lanzada desde ctor MiClase(string), Lanzo MiExcepcion desde OtraClase", e);
            }

        }
    }
}

