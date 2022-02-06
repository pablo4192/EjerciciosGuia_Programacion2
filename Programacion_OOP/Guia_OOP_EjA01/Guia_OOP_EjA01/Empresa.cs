using System;


namespace Guia_OOP_EjA01
{
    #region Consigna
    /*
    Requerimiento#
    De una empresa de transporte de cargas se quiere guardar el nombre de los conductores y los kilómetros que conducen cada día de la semana.

    Para guardar esta información, la empresa de transporte tendrá un array de conductores.

    De cada conductor se tendrá la siguiente información:

    Nombre del conductor.
    Kilometros recorridos por cada día de la semana. Por ejemplo:
    Día 1: 200
    Día 2: 599
    Día 3: 899
    Día 4: 0 (tiene franco)
    Día 5: 256
    Día 6: 0
    Día 7: 0
    Consigna#
    Desarrollar las clases y métodos necesarios. Toda la lógica de negocio deberá estar encapsulada en clases y dentro de un proyecto de tipo 
    biblioteca de clases.

    Crear un proyecto de consola y en el método Main cargar 3 conductores a la empresa de transportes.

    Luego mostrar:

    El conductor que hizo más km en esa semana.
    El conductor que hizo más km el día 3.
    El conductor que hizo más km el día 5. 
    */
    #endregion

    public static class Empresa
    {
        static string nombre;
        static Chofer[] arrayDeChoferes;

        static Empresa()
        {
            nombre = "La Vivona";
            arrayDeChoferes = new Chofer[10];
        }

        /// <summary>
        /// Setter del atributo arrayChoferes
        /// </summary>
        /// <param name="chofer"></param>
        /// <returns>True si seteo el valor, False si no hay lugar en el array.</returns>
        public static bool SetArrayChoferes(Chofer chofer)
        {
            for(int i = 0; i < arrayDeChoferes.Length; i++)
            {
                if(arrayDeChoferes[i] == null)
                {
                    arrayDeChoferes[i] = chofer;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Calcula el chofer que hizo mas km en la semana.
        /// </summary>
        /// <returns>Chofer que realizo mas km</returns>
        public static Chofer ChoferConMasKmRecorridos() 
        {
            int mayor = 0;
            int kmChofer;
            bool flag = false;
            Chofer choferAux = null;

            for(int chofer = 0; chofer < arrayDeChoferes.Length; chofer++)
            {
                kmChofer = 0;

                if(arrayDeChoferes[chofer] != null)
                {
                    for(int dia = 0; dia < arrayDeChoferes[chofer].GetArrayKm().Length; dia++)
                    {
                       kmChofer += arrayDeChoferes[chofer].GetArrayKm()[dia];
                    }

                    if(!flag || kmChofer > mayor)
                    {
                        mayor = kmChofer;
                        choferAux = arrayDeChoferes[chofer];
                        flag = true;
                    }
                }
            }
            return choferAux;
        }

        /// <summary>
        /// Calcula el chofer que hizo mas km el dia 3.
        /// </summary>
        /// <returns>Chofer que realizo mas km</returns>
        public static Chofer ChoferConMasKmRecorridos_Dia3()
        {
            int mayor = 0;
            Chofer choferAux = null;

            for (int chofer = 0; chofer < arrayDeChoferes.Length; chofer++)
            {
                if (arrayDeChoferes[chofer] != null)
                {
                    if(arrayDeChoferes[chofer].GetArrayKm()[2] > mayor)
                    {
                        mayor = arrayDeChoferes[chofer].GetArrayKm()[2];
                        choferAux = arrayDeChoferes[chofer];
                    }
                }
            }
            return choferAux;
        }

        /// <summary>
        /// Calcula el chofer que hizo mas km el dia 5.
        /// </summary>
        /// <returns>Chofer que realizo mas km</returns>
        public static Chofer ChoferConMasKmRecorridos_Dia5()
        {
            int mayor = 0;
            Chofer choferAux = null;

            for (int chofer = 0; chofer < arrayDeChoferes.Length; chofer++)
            {
                if (arrayDeChoferes[chofer] != null)
                {
                    if (arrayDeChoferes[chofer].GetArrayKm()[4] > mayor)
                    {
                        mayor = arrayDeChoferes[chofer].GetArrayKm()[4];
                        choferAux = arrayDeChoferes[chofer];
                    }
                }
            }
            return choferAux;
        }
    }
}
