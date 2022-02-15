using System;

namespace Guia_UnitTests_LanzarYAtrapar
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
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
            catch (Exception e)
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
