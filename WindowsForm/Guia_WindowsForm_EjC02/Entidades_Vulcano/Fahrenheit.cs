using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_WindowsForm_EjC02
{
    public class Fahrenheit
    {
        private double grados;

        public Fahrenheit(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return grados;
        }

        //Conversion implicita
        public static implicit operator Celsius(Fahrenheit fahrenheit)
        {
            return Celsius.Convertir(fahrenheit);
        }

        public static implicit operator Kelvin(Fahrenheit fahrenheit)
        {
            return Kelvin.Convertir(fahrenheit);
        }

        //Metodos para convertir a farenheit
        public static Fahrenheit Convertir(Celsius celsius)
        {
            return new Fahrenheit(celsius.GetGrados() * ((float)9 / 5) + 32);

        }

        public static Fahrenheit Convertir(Kelvin kelvin)
        {
            return new Fahrenheit(kelvin.GetGrados() * ((float)9 / 5) - 459.67);
        }

        //Sobrecarga operadores +, -
        public static double operator +(Fahrenheit f, Fahrenheit f2)
        {
            return f.GetGrados() + f2.GetGrados();
        }

        public static double operator -(Fahrenheit f, Fahrenheit f2)
        {
            return f.GetGrados() - f2.GetGrados();
        }

        public static double operator +(Fahrenheit f, Celsius c)
        {
            return f + (Fahrenheit)c;
        }

        public static double operator -(Fahrenheit f, Celsius c)
        {
            return f - (Fahrenheit)c;
        }

        public static double operator +(Fahrenheit f, Kelvin k)
        {
            return f + (Fahrenheit)k;
        }

        public static double operator -(Fahrenheit f, Kelvin k)
        {
            return f - (Fahrenheit)k;
        }
    }
}
