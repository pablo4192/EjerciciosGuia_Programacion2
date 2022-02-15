using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Polimorfismo_Ej02
{
    public sealed class Cuadrado: Rectangulo
    {
        float longitudLado;

        public Cuadrado(float longitudLado): base(longitudLado, longitudLado)
        {
            this.longitudLado = longitudLado;
        }

        public override string Dibujar()
        {
            return "Dibujando Cuadrado";
        }
    }
}
