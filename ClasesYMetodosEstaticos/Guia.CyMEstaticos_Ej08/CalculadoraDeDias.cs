using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia.CyMEstaticos_Ej08
{
    internal static class CalculadoraDeDias
    {
        /// <summary>
        /// Cuenta los dias que pasaron desde la fecha pasada por parametro.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Cantidad de dias que han transcurrido</returns>
        public static int ContadorDeDias(DateTime fecha)
        {
            int acumuladorDias = 0;

            for(int anio = fecha.Year; anio <= DateTime.Now.Year; anio++)
            {
                
                if(anio == fecha.Year)
                {
                    if(fecha.Year < DateTime.Now.Year)
                    {
                        for(int mes = fecha.Month; mes <= 12; mes++)
                        {
                            if(mes == fecha.Month)
                            {
                                acumuladorDias += DateTime.DaysInMonth(anio, mes) - fecha.Day;
                            }
                            else
                            {
                                acumuladorDias += DateTime.DaysInMonth(anio, mes);
                            }
                        }
                    }
                    else
                    {
                        for (int mes = fecha.Month; mes <= DateTime.Now.Month; mes++)
                        {
                            if (mes == DateTime.Now.Month)
                            {
                                acumuladorDias += DateTime.Now.Day - fecha.Day;


                            }
                            else
                            {
                                acumuladorDias += DateTime.DaysInMonth(anio, mes);

                            }
                        }
                    }
                }
                else
                {
                    if(anio != DateTime.Now.Year)
                    {
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            acumuladorDias += DateTime.DaysInMonth(anio, mes);
                        }
                    }
                    else
                    {
                        for(int mes = 1; mes <= DateTime.Now.Month; mes++)
                        {
                            if(mes == DateTime.Now.Month)
                            {
                                for(int dia = 1; dia <= DateTime.Now.Day; dia++)
                                {
                                    acumuladorDias++;
                                }
                            }
                            else
                            {
                                acumuladorDias += DateTime.DaysInMonth(anio, mes);
                            }
                                
                        }
                    }

                    
                }
                
            }

            return acumuladorDias;
        }

        /// <summary>
        /// Valida si la respuesta pasada por parametro es SI
        /// </summary>
        /// <param name="respuesta"></param>
        /// <returns>True si es la letra SI, False si no lo es</returns>
        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta.ToUpper() == "SI")
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Valida que el nombre contenga solo letras.
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si solo contiene letras, False si contiene por lo menos un caracter que no sea una letra.</returns>
        public static bool ValidarNombre(string nombre)
        {
            for(int letra = 0; letra < nombre.Length; letra++)
            {
                if(!char.IsLetter(nombre[letra]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
