using System;
using System.Text;

namespace Guia_Sobrecarga_EjC02
{
    public class Producto
    {
        string codigoDeBarra;
        string marca;
        float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"Codigo de barra: {(string)p}, Marca: {p.marca}, Precio: {p.precio}";
            
        }

        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca);
        }

        public static bool operator ==(Producto p, string cadena)
        {
            return p.marca == cadena;
        }

        public static bool operator !=(Producto p, string cadena)
        {
            return !(p.marca == cadena);
        }

    }
}
