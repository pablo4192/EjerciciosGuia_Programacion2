using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Polimorfismo_Ej02
{
    public class Rectangulo: Figura
    {
        float largo;
        float alto;

        public Rectangulo(float largo, float alto)
        {
            this.largo = largo;
            this.alto = alto;
        }

        public override double CalcularPerimetro()
        {
            return largo * 2 + alto * 2;
        }

        public override double CalcularSuperficie()
        {
            return largo * alto;
        }

        public override string Dibujar()
        {
            return "Dibujando Rectangulo";
        }
    }
}
