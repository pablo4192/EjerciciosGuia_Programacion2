using System;

namespace Guia_Herencia_Ej01
{
    public class Automovil : VehiculoTerrestre
    {
       
        int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros): base(cantidadRuedas, cantidadPuertas, color, cantidadMarchas)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public int CantidadPasajeros { get { return this.cantidadPasajeros; } }
    }
}
