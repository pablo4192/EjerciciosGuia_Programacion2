using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        double cantidad;
        static double cotizRespectoAlDolar;

        static Peso()
        {
            cotizRespectoAlDolar = 102.65; // 102.65 pesos == 1 dolar
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoAlDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso peso)
        {
            Dolar dolarAux = (Dolar)peso;

            return new Euro(dolarAux.GetCantidad() * Euro.GetCotizacion()); // u$0.009 * eu$0.85 = eu$0.0082 == $1
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            return peso == (Peso)euro;
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(peso == (Peso)euro);
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return peso == (Peso)dolar;
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(peso == (Peso)dolar);
        }
        public static bool operator ==(Peso peso, Peso peso2)
        {
            return peso.cantidad == peso2.cantidad;
        }

        public static bool operator !=(Peso peso, Peso peso2)
        {
            return !(peso == peso2);
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static Peso operator +(Peso peso, Dolar dolar)
        {
            Peso pesoAux = (Peso)dolar;

            return new Peso(peso.cantidad + pesoAux.cantidad);
        }

        public static Peso operator +(Peso peso, Euro euro)
        {
            Peso pesoAux = (Peso)euro;

            return new Peso(peso.cantidad + pesoAux.cantidad);
        }

        public static Peso operator -(Peso peso, Dolar dolar)
        {
            Peso pesoAux = (Peso)dolar;

            return new Peso(peso.cantidad - pesoAux.cantidad);
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            Peso pesoAux = (Peso)euro;

            return new Peso(peso.cantidad - pesoAux.cantidad);
        }
    }
}
