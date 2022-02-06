using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Sobrecarga_EjC02
{
    public class Estante
    {
        Producto[] productos;
        int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion): this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetPtoductos()
        {
            return productos;

            
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Ubicacion del estante: {e.ubicacionEstante}");
            for(int i = 0; i < e.productos.Length; i++)
            {
                if(!(e.productos[i] is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                }
            }


            return sb.ToString();
        }


        public static bool operator ==(Estante e, Producto p)
        {
            return e.productos.Contains(p);
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e.productos.Contains(p));
        }

        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for(int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for(int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] == p)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }

    }
}
