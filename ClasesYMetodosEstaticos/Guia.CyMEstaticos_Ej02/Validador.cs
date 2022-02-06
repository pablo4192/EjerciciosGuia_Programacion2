using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej02
{
    internal class Validador
    {
        
        /// <summary>
        /// Valida si la respuesta pasada por parametro es S
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns>True si es la letra S, False si no lo es</returns>
        public static bool ValidarRespuesta(string respuesta)
        {
            if(respuesta.ToUpper() == "S")
            {
                return true;
            }

            return false;
        }

    }
}
