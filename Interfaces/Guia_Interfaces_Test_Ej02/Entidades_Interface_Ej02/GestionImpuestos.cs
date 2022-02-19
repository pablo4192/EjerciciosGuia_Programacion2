using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interface_Ej02
{
    public class GestionImpuestos
    {
        List<IAduana> impuestosAduana;
        List<IAfip> impuestosAfip;

        public GestionImpuestos()
        {
            impuestosAduana = new List<IAduana>();
            impuestosAfip = new List<IAfip>();
        }

        public decimal CalcularTotalImpuestosAduana()
        {
            decimal total = 0;

            foreach (IAduana aduana in this.impuestosAduana)
            {
                
                total += aduana.Impuestos;
            }


            return total;
        }

        public decimal CalcularTotalImpuestosAfip()
        {
            decimal total = 0;

            foreach (IAfip afip in this.impuestosAfip)
            {
                
                total += afip.Impuestos;
            }

            return total;
        }

        public void RegistrarImpuestos(IEnumerable<Paquete> paquetes)
        {
            foreach (Paquete p in paquetes)
            {
                RegistrarImpuestos(p);
            }
            
        }

        public void RegistrarImpuestos(Paquete paquete)
        {
            if(paquete != null)
            {
                this.impuestosAduana.Add(paquete);

                if(paquete is IAfip) // Tiene que ser PaquetePesado
                {
                    this.impuestosAfip.Add((IAfip)paquete);
                }
            }

            
        }
    }
}
