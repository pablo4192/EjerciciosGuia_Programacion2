using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Guia_Encapsulamiento_Ej01
{
    public class PuestoDeAtencion
    {
        static int numeroActual;
        Puesto puesto;

        public static int NUmeroActual 
        {
            get 
            {
                numeroActual++;
                return numeroActual; 
            } 
            
        }

        static PuestoDeAtencion()
        {
            numeroActual = 0;
        }

        public PuestoDeAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cliente)
        {
             Thread.Sleep(3000);
             return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }

    }
}
