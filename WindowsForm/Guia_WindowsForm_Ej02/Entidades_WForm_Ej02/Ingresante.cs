using System;
using System.Text;

namespace Entidades_WForm_Ej02
{
    public class Ingresante
    {
        string[] cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.cursos = new string[3];

            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        /// <summary>
        /// Retorna una cadena de texto con los datos del ingresante
        /// </summary>
        /// <returns>String con los datos del ingresante</returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Curso/s:");
            for(int i = 0; i< cursos.Length; i++)
            {
                if(cursos[i] != null)
                {
                    sb.AppendLine(cursos[i]);
                }
                
            }
            return sb.ToString();

        }
        

    }
}
