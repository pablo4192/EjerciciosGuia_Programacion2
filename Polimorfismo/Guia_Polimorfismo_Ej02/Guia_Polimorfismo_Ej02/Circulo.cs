using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Polimorfismo_Ej02
{
    public sealed class Circulo: Figura
    {
        float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * this.radio;
        }

        public override double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }

        public override string Dibujar()
        {
            return "Dibujando Circulo";
        }
    }
}
