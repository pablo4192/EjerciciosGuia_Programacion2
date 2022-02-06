using System;

namespace Entidades
{
    /*
    Deberá tener los atributos:

    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:

    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.  
    */

    public class Cuenta
    {
        string titular;
        double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Getter del atributo Titular.
        /// </summary>
        /// <returns>Valor del atributo.</returns>
        public string TitularGet() //En encapsulamiento Propiedad
        {
            return this.titular;
        }

        /// <summary>
        /// Getter del atributo cantidad. 
        /// </summary>
        /// <returns>Valor del atributo</returns>
        public double CantidadGet() //En encapsulamiento Propiedad
        {
            return this.cantidad;
        }

        /// <summary>
        /// Arma una cadena con los datos de la cuenta.
        /// </summary>
        /// <returns>Cadena de texto con los datos de la cuenta.</returns>
        public string Mostrar()
        {
            return $"Titular de la cuenta: {this.titular}, Cantidad de dinero disponible: ${cantidad}.";
        }

        /// <summary>
        /// Acredita un monto de dinero a la cuenta.
        /// </summary>
        /// <param name="montoAIngresar"></param>
        /// <returns>True si lo acredita, False si no se pudo acreditar.</returns>
        public bool Ingresar(double montoAIngresar)
        {
            if (montoAIngresar > 0)
            {
                this.cantidad += montoAIngresar;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Debita de la cuenta el importe pasado por parametro.
        /// </summary>
        /// <param name="montoARetirar"></param>
        /// <returns>True si se realizo el debito, False si el monto a retirar es menor a 0.</returns>
        public bool Retirar(double montoARetirar)
        {
            if (montoARetirar < 0)
            {
                return false;
            }

            this.cantidad -= montoARetirar;
            return true;
        }
    }
}

