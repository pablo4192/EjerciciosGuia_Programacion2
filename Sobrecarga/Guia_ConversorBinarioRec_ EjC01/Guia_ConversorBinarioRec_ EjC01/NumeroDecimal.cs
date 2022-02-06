using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_ConversorBinarioRec__EjC01
{
    public class NumeroDecimal
    {
        double numero;

        public NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double GetNumero()
        {
            return this.numero;
        }

        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return new NumeroDecimal(Conversor.ConvertirBinarioADecimal(numeroBinario.GetNumero()));
        }

        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.GetNumero() + ((NumeroDecimal)nb).GetNumero();
        }

        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.GetNumero() - ((NumeroDecimal)nb).GetNumero();
        }

        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.GetNumero() == ((NumeroDecimal)nb).GetNumero();
        }

        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd.GetNumero() == ((NumeroDecimal)nb).GetNumero());
        }

    }
}
