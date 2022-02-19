using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Generics_Ej02
{
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        List<T> egresos;
        List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
        
        /// <summary>
        /// Agrega un egreso a la lista de egresos
        /// </summary>
        /// <param name="c"></param>
        /// <param name="egreso"></param>
        /// <returns>Lista de egresos actualizada</returns>
        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }

        /// <summary>
        /// Agrega un egreso a la lista de egresos
        /// </summary>
        /// <param name="c"></param>
        /// <param name="egreso"></param>
        /// <returns>Lista de egresos actualizada</returns>
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;

        }
    }
}
