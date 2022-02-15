using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Excepciones_Ej01
{
    public class MiClase
    { 
        public MiClase()
        {
            try
            {
                Metodo();
            }
            catch(DivideByZeroException e)
            {
                throw new Exception("(1) Capturo DivideByZeroException, Lanzo Excepcion desde constructor", e);
            }
        }
        public MiClase(string atributo)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(Exception e)
            {
                throw new UnaExcepcion("(2) Capturo Excepcion lanzada desde el constructor, Lanzo UnaException desde ctor(string)", e);
            }

            
        }

        public static void Metodo()
        {
            throw new DivideByZeroException();
        }

    }
}
