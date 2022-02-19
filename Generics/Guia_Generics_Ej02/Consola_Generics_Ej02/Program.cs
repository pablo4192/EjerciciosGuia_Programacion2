using System;
using Guia_Generics_Ej02;

namespace Consola_Generics_Ej02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();
            
            //Contabilidad<Recibo, Factura> Esto No Es Posible por las restricciones

            Factura factura1 = new Factura(100);
            Factura factura2 = new Factura(101);
            Recibo recibo1 = new Recibo();
            Recibo recibo2 = new Recibo(1);

            _ = contabilidad + factura1;
            _ = contabilidad + factura2;
            _ = contabilidad + recibo1;
            _ = contabilidad + recibo2;
            
        }
    }
}
