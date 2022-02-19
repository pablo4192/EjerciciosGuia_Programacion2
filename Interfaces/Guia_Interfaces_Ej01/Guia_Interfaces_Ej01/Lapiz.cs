using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Interfaces_Ej01
{
    public class Lapiz: IAcciones //Implementar de forma explicita
    {
        float tamanioMina;

        public ConsoleColor Color 
        {
            get { return ConsoleColor.Gray; }
            set { throw new NotImplementedException(); }
        }

        public float UnidadesDeEscritura 
        {
            get { return this.tamanioMina; }
            set 
            {
                if (value > 0)
                    this.tamanioMina = value;
            }
        }

        public Lapiz(int unidades)
        {
            this.UnidadesDeEscritura = unidades;
            
        }
        
        public EscrituraWrapper Escribir(string texto)
        {
            this.tamanioMina -= texto.Length * (float)0.1; 

            return new EscrituraWrapper(texto, this.Color); 
        }

        public bool Recargar(int unidades)
        {
            throw new NotImplementedException();
            
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Datos del Lapiz");
            sb.AppendLine($"Color de escritura: {this.Color}");
            sb.AppendLine($"Tamaño de Mina: {this.UnidadesDeEscritura}");

            return sb.ToString();
        }

    }
}
