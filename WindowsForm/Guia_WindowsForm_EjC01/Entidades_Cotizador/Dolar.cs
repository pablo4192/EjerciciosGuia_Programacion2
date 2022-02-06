using System;

namespace Entidades_Cotizador
{
    public class Dolar
    {
        double cantidad;
        static double cotizRespectoAlDolar;

        static Dolar()
        {
            cotizRespectoAlDolar = 1; //1 dolar == 1 dolar
        }

        public Dolar(double cantidad)
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

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad * Euro.GetCotizacion()); // u$1 * eu$0.85 = eu$0.85
        }

        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.cantidad * Peso.GetCotizacion()); // u$1 * $102.65 = $102.65
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return dolar == (Dolar)euro;
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == (Dolar)euro);
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return dolar == (Dolar)peso;
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return !(dolar == (Dolar)peso);
        }
        public static bool operator ==(Dolar dolar, Dolar dolar2)
        {
            return dolar.cantidad == dolar2.cantidad;
        }

        public static bool operator !=(Dolar dolar, Dolar dolar2)
        {
            return !(dolar == dolar2);
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            Dolar dolarAux = (Dolar)peso;

            return new Dolar(dolar.cantidad + dolarAux.cantidad);
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            Dolar dolarAux = (Dolar)euro;

            return new Dolar(dolar.cantidad + dolarAux.cantidad);
        }

        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            Dolar dolarAux = (Dolar)peso;

            return new Dolar(dolar.cantidad - dolarAux.cantidad);
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar dolarAux = (Dolar)euro;

            return new Dolar(dolar.cantidad - dolarAux.cantidad);
        }

    }
}
