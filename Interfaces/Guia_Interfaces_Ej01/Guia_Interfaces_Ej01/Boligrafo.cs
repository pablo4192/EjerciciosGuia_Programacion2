using System;
using System.Text;

namespace Guia_Interfaces_Ej01
{
    public class Boligrafo: IAcciones //Implementar de forma implicita
    {
        ConsoleColor colorTinta;
        float tinta;

        public ConsoleColor Color 
        {
            get { return this.colorTinta; }
            set { this.colorTinta = value; }
        }

        public float UnidadesDeEscritura 
        {
            get { return this.tinta; }
            set 
            { 
                if(value > 0)
                this.tinta = value; 
            } 
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this.UnidadesDeEscritura = unidades;
            this.Color = color;

        }

        public EscrituraWrapper Escribir(string texto)
        {
            this.tinta -= texto.Length * (float)0.3;

            return new EscrituraWrapper(texto, this.Color);
        }

        public bool Recargar(int unidades)
        {
            if(unidades > 0)
            {
                this.tinta += unidades;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Boligrafo");
            sb.AppendLine($"Color de escritura: {this.Color}");
            sb.AppendLine($"Nivel de tinta: {this.UnidadesDeEscritura}");

            return sb.ToString();
        }
    }
}
