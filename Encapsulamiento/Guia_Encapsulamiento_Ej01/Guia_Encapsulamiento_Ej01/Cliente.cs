using System;

namespace Guia_Encapsulamiento_Ej01
{
    public class Cliente
    {
        string nombre;
        int numero;

        public string Nombre 
        {
            get { return this.nombre; } 
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
            } 
        }

        public int Numero 
        {
            get { return this.Numero; } 
            set
            {
                if(value > 0)
                {
                    this.Numero = value;
                }
            }
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre): this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
