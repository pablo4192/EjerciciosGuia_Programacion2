using System;

namespace Guia_Sobrecarga_EjA01
{
    public class Celsius
    {
        private double grados;
        public Celsius(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return grados;
        }

        //Conversion implicita
        public static implicit operator Fahrenheit(Celsius celsius)
        {
            return Fahrenheit.Convertir(celsius);
        }

        public static implicit operator Kelvin(Celsius celsius)
        {
            return Kelvin.Convertir(celsius);
        }

        //Metodos para convertir en Celsius
        public static Celsius Convertir(Fahrenheit fahrenheit)
        {
            return new Celsius((fahrenheit.GetGrados() - 32) * ((float)5/9));
        }

        public static Celsius Convertir(Kelvin kelvin)
        {
            return new Celsius( Convertir(Fahrenheit.Convertir(kelvin)).GetGrados() );
        }

        //Sobrecarga operadores +, -
        public static double operator +(Celsius c, Celsius c2)
        {
            return c.GetGrados() + c2.GetGrados();
        }

        public static double operator -(Celsius c, Celsius c2)
        {
            return c.GetGrados() - c2.GetGrados();
        }

        public static double operator +(Celsius c, Fahrenheit f)
        {
            return c + (Celsius)f;
        }

        public static double operator -(Celsius c, Fahrenheit f)
        {
            return c - (Celsius)f;
        }

        public static double operator +(Celsius c, Kelvin k)
        {
            return c + (Celsius)k;
        }

        public static double operator -(Celsius c, Kelvin k)
        {
            return c - (Celsius)k;
        }

    }
}
