using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Encapsulamiento_Ej01
{
    public class Negocio
    {
        PuestoDeAtencion caja;
        Queue<Cliente> clientes;
        string nombre;

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            caja = new PuestoDeAtencion(PuestoDeAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre): this()
        {
            this.nombre = nombre;
        }

        public Cliente Cliente 
        { 
            get
            {
                
                return clientes.Dequeue();
            }
            set
            {
                _= this + value;
            }
        }

        public int ClientesPendientes { get { return clientes.Count; } }

        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
           
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            if(n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator ~(Negocio n)
        {
            if(n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }

            return false;
        }
    }
}
