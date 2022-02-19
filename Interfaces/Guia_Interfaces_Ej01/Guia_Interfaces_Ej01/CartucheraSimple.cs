using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Interfaces_Ej01
{
    public class CartucheraSimple
    {
        List<Boligrafo> listaBoligrafos;
        List<Lapiz> listaLapices;

        public CartucheraSimple()
        {
            this.listaBoligrafos = new List<Boligrafo>();
            this.listaLapices = new List<Lapiz>();
        }

        public List<Boligrafo> Boligrafos 
        {
            get { return this.listaBoligrafos; }
             
        }

        public List<Lapiz> Lapices
        {
            get { return this.listaLapices; }

        }

        public bool RecorrerElementos()
        {
            int unidadesGastadas = 0;

            foreach (Boligrafo util in this.listaBoligrafos)
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

            foreach (Lapiz util in this.listaLapices)
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


            if (unidadesGastadas == this.listaBoligrafos.Count + this.listaLapices.Count)
                return true;
            else
                return false;

        }
    }
}
