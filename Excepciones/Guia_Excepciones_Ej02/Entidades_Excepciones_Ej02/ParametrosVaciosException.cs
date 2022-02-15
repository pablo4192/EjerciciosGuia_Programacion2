using System;

namespace Entidades_Excepciones_Ej02
{
    public class ParametrosVaciosException: Exception
    {
        public ParametrosVaciosException(string mensaje, Exception innerException): base(mensaje, innerException)
        {

        }

        public ParametrosVaciosException(string mensaje): base(mensaje)
        {

        }
    }
}
