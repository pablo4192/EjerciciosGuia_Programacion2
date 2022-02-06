using System;

namespace Entidades2
{
    public class Persona
    {
        string nombre;
        DateTime fechaDeNacimiento;
        int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        /// <summary>
        /// Getter Nombre de la persona.
        /// </summary>
        /// <returns>Nobre de la persona.</returns>
        public string NombreGet()
        {
            return this.nombre;
        }

        /// <summary>
        /// Setter Nombre de la persona.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True si se pudo setear, False si no.</returns>
        public bool NombreSet(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.nombre = value;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Getter Fecha de nacimiento de la persona.
        /// </summary>
        /// <returns>Fecha de nacimiento de la persona.</returns>
        public DateTime FechaDeNacimientoGet()
        {
            return this.fechaDeNacimiento;
        }

        /// <summary>
        /// Setter fecha de nacimiento de la persona.
        /// </summary>
        /// <param name="value"></param>
        public void FechaDeNacimientoSet(DateTime value)
        {
            this.fechaDeNacimiento = value;
        }

        /// <summary>
        /// Getter Dni de la persona.
        /// </summary>
        /// <returns>Dni de la persona.</returns>
        public int DniGet()
        {
            return this.dni;
        }

        /// <summary>
        /// Setter Dni de la persona.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True si se pudo setear, False si no</returns>
        public bool DniSet(int value)
        {
            if (value < 0)
            {
                return false;
            }

            this.dni = value;
            return true;

        }

        /// <summary>
        /// Calcula la edad de la persona por su fecha de nacimiento.
        /// </summary>
        /// <returns>Edad de la persona.</returns>
        private int CalcularEdad()
        {
            int dias;

            dias = ContadorDeDias(this.fechaDeNacimiento);

            return (int)dias / 365;
        }

        /// <summary>
        /// Cuenta los dias que pasaron desde la fecha pasada por parametro.
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns>Cantidad de dias que han transcurrido</returns>
        private static int ContadorDeDias(DateTime fecha)
        {
            int acumuladorDias = 0;

            for (int anio = fecha.Year; anio <= DateTime.Now.Year; anio++)
            {

                if (anio == fecha.Year)
                {
                    if (fecha.Year < DateTime.Now.Year)
                    {
                        for (int mes = fecha.Month; mes <= 12; mes++)
                        {
                            if (mes == fecha.Month)
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
                    if (anio != DateTime.Now.Year)
                    {
                        for (int mes = 1; mes <= 12; mes++)
                        {
                            acumuladorDias += DateTime.DaysInMonth(anio, mes);
                        }
                    }
                    else
                    {
                        for (int mes = 1; mes <= DateTime.Now.Month; mes++)
                        {
                            if (mes == DateTime.Now.Month)
                            {
                                for (int dia = 1; dia <= DateTime.Now.Day; dia++)
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
        /// Arma una cadena con los datos de la persona.
        /// </summary>
        /// <returns>String con los datos de la persona.</returns>
        public string Mostrar()
        {
            return $"Nombre: {this.nombre}, Fecha de nacimiento: {this.fechaDeNacimiento}, Dni: {this.dni}, Edad : {CalcularEdad()}";
        }

        /// <summary>
        /// Verifica si la persona es mayor de edad.
        /// </summary>
        /// <returns>Es mayor de edad si +18, Es menor de edad si -18</returns>
        public string EsMayorDeEdad()
        {
            if(CalcularEdad() >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
        }
    }
}
