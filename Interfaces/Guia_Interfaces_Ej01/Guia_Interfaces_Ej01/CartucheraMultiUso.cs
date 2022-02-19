using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Interfaces_Ej01
{
    public class CartucheraMultiUso
    {
        List<IAcciones> lista;

        public CartucheraMultiUso()
        {
            this.lista = new List<IAcciones>();
        }

        public List<IAcciones> Lista 
        {
            get { return this.lista; } 
        }

        public bool RecorrerElementos()
        {
            int unidadesGastadas = 0;

            foreach (IAcciones util in this.lista)
            {
                if (util.UnidadesDeEscritura > 0)
                {
                    util.Escribir("1");
                    unidadesGastadas++;
                }
                else
                {
                    util.Recargar(20);
                    break;
                }    
            }
            if (unidadesGastadas == this.lista.Count)
                return true;
            else
                return false;

        }
    }
}
