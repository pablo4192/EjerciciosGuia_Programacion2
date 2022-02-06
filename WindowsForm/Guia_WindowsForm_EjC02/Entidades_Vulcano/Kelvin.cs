using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_WindowsForm_EjC02
{
    public class Kelvin
    {
        private double grados;

        public Kelvin(double grados)
        {
            this.grados = grados;
        }

        public double GetGrados()
        {
            return grados;
        }

        //Conversion implicita
        public static implicit operator Fahrenheit(Kelvin kelvin)
        {
            return Fahrenheit.Convertir(kelvin);
        }

        public static implicit operator Celsius(Kelvin kelvin)
        {
            return Celsius.Convertir(kelvin);
        }

        //Metodos para convertir en kelvin
        public static Kelvin Convertir(Celsius celsius)
        {
            return new Kelvin(Convertir(Fahrenheit.Convertir(celsius)).GetGrados()); //Convierto celsius en fahrenheit y luego a kelvin.
        }

        public static Kelvin Convertir(Fahrenheit fahrenheit)
        {
            return new Kelvin((fahrenheit.GetGrados() + 459.67) * ((float)5 / 9));
        }

        //Sobrecarga operadores +, -
        public static double operator +(Kelvin k, Kelvin k2)
        {
            return k.GetGrados() + k2.GetGrados();
        }

        public static double operator -(Kelvin k, Kelvin k2)
        {
            return k.GetGrados() - k2.GetGrados();
        }

        public static double operator +(Kelvin k, Celsius c)
        {
            return k + (Kelvin)c;
        }

        public static double operator -(Kelvin k, Celsius c)
        {
            return k - (Kelvin)c;
        }

        public static double operator +(Kelvin k, Fahrenheit f)
        {
            return k + (Kelvin)f;
        }

        public static double operator -(Kelvin k, Fahrenheit f)
        {
            return k - (Kelvin)f;
        }
    }
}
