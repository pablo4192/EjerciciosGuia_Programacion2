using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Cotizador
{
    public class Euro
    {
        double cantidad;
        static double cotizRespectoAlDolar;

        static Euro()
        {
            cotizRespectoAlDolar = 1 / 1.17; //0.85 eu == 1 dolar
        }

        public Euro(double cantidad)
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

        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad / Euro.GetCotizacion()); // 1 / 0.85 = 1.17 dolar
        }

        public static explicit operator Peso(Euro euro)
        {
            Dolar dolarAux = (Dolar)euro;

            return new Peso(dolarAux.GetCantidad() * Peso.GetCotizacion()); // u$1.17 * $102.65 = $120.10 == eu$1
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return euro == (Euro)dolar;
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == (Euro)dolar);
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            return euro == (Euro)peso;
        }

        public static bool operator !=(Euro euro, Peso peso)
        {
            return !(euro == (Euro)peso);
        }
        public static bool operator ==(Euro euro, Euro euro2)
        {
            return euro.cantidad == euro2.cantidad;
        }

        public static bool operator !=(Euro euro, Euro euro2)
        {
            return !(euro == euro2);
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static Euro operator +(Euro euro, Peso peso)
        {
            Euro euroAux = (Euro)peso;

            return new Euro(euro.cantidad + euroAux.cantidad);
        }

        public static Euro operator +(Euro euro, Dolar dolar)
        {
            Euro euroAux = (Euro)dolar;

            return new Euro(euro.cantidad + euroAux.cantidad);
        }

        public static Euro operator -(Euro euro, Peso peso)
        {
            Euro euroAux = (Euro)peso;

            return new Euro(euro.cantidad - euroAux.cantidad);
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro euroAux = (Euro)dolar;

            return new Euro(euro.cantidad - euroAux.cantidad);
        }

        /// <summary>
        /// Setea la cotización de la moneda respecto al dolar
        /// </summary>
        /// <param name="valorCotizacion"></param>
        /// <returns>True si valor cotizacion es valido, False si es un numero negativo</returns>
        public static bool SetCotizacion(string valorCotizacion)
        {
            double valorDouble;

            if(double.TryParse(valorCotizacion, out valorDouble) && valorDouble > 0)
            {
                cotizRespectoAlDolar = valorDouble;
                return true;
            }
            return false;
        }
    }
}
