using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(Math.Abs(vertice1.GetX()), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(Math.Abs(vertice3.GetX()), vertice3.GetY());

            this.area = Math.Abs(vertice1.GetX() - vertice3.GetX()) * Math.Abs(vertice1.GetY() - vertice3.GetY());

            //Con el valor absoluto de la resta entre (x del vertice1 y x del vertice3 (ejemplo -4, 4) + y del vertice1 - y del vertice3 (ejemplo -3, 3)) * 2; Me da el perimetro (que es la suma de los lados)
            this.perimetro = (Math.Abs(vertice1.GetX() - vertice3.GetX()) + Math.Abs(vertice1.GetY() - vertice3.GetY())) * 2;
        }

        public float GetArea()
        {
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

    }
}
