using System;

namespace Guia_OOP_EjA02
{
   
    public static class Veterinaria
    {
        static string nombre;
        static Cliente[] clientes; //En el caso de las colecciones uso List< >.

        static Veterinaria()
        {
            nombre = "El felpudo";
            clientes = new Cliente[20];
        }

        /// <summary>
        /// Agrega un cliente al array de clientes de la veterinaria.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>True si lo agrego, False si no habia lugar en el array.</returns>
        public static bool AgregarCliente(Cliente cliente)
        {
            for(int i = 0; i < clientes.Length; i++)
            {
                if(clientes[i] != null)
                {
                    clientes[i] = cliente;
                    return true;
                }
            }

            return false;
        }

    }
}
