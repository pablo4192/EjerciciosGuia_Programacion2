using System;
using Guia_Sobrecarga_EjA01;

namespace Consola_Sobrecarga_EjA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecargas Ej A01";

            Celsius c = new Celsius(3);
            Fahrenheit f = new Fahrenheit(60);
            Kelvin k = new Kelvin(45);

            Fahrenheit celsiusAFaherenheit = c;
            Fahrenheit kelvinAFahrenheit = k;
            Kelvin fahrenheitAKelvin = f;
            Kelvin celsiusAKelvin = c;
            Celsius fahrenheitACelsius = f;
            Celsius kelvinACelsius = k;

            Console.WriteLine($"{c.GetGrados()} Celsius son: {celsiusAFaherenheit.GetGrados()} Fahrenheit");
            Console.WriteLine($"{k.GetGrados()} Kelvin son: {kelvinAFahrenheit.GetGrados()} Fahrenheit");
            Console.WriteLine($"{f.GetGrados()} Fahrenheit son: {fahrenheitAKelvin.GetGrados()} Kelvin");
            Console.WriteLine($"{c.GetGrados()} Celsius son: {celsiusAKelvin.GetGrados()} Kelvin");
            Console.WriteLine($"{f.GetGrados()} Fahrenheit son: {fahrenheitACelsius.GetGrados()} Celsius");
            Console.WriteLine($"{k.GetGrados()} Kelvin son: {kelvinACelsius.GetGrados()} Celsius");
            Console.WriteLine();
            Console.WriteLine($"3 grados celsius + 60 grados fahrenheit son: {c + f} grados Celsius");
            Console.WriteLine($"3 grados celsius + 45 grados kelvin son: {c + k} grados Celsius");
            Console.WriteLine($"60 grados fahrenheit + 3 grados celsius son: {f + c} grados Fahrenheit");
            Console.WriteLine($"45 grados kelvin + 3 grados celsius son: {k + c} grados Kelvin");
            Console.WriteLine($"60 grados fahrenheit - 45 grados kelkvin son: {f - k} grados Fahrenheit");
            Console.WriteLine($"45 grados kelvin - 3 grados celsius son: {k - c} grados Kelvin");
            
            
           
            





        }
    }
}
