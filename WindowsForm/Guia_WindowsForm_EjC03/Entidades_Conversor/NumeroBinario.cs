using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Conversor
{
    public class NumeroBinario
    {
        string numero;

        public NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string GetNumero()
        {
            return this.numero;
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return new NumeroBinario(Conversor.ConvertirDecimalABinario(numeroDecimal.GetNumero()));
        }

        public static string operator +(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return Conversor.ConvertirDecimalABinario(((NumeroDecimal)numeroBinario).GetNumero() + numeroDecimal.GetNumero());
        }

        public static string operator -(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return Conversor.ConvertirDecimalABinario(((NumeroDecimal)numeroBinario).GetNumero() - numeroDecimal.GetNumero());
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return ((NumeroDecimal)numeroBinario).GetNumero() == numeroDecimal.GetNumero(); //True si son iguales los numeros en decimal
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(((NumeroDecimal)numeroBinario).GetNumero() == numeroDecimal.GetNumero()); //True si son distintos
        }
    }
}
