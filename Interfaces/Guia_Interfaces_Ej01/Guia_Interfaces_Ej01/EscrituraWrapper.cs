using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_Interfaces_Ej01
{
    public class EscrituraWrapper
    {
        ConsoleColor color;
        string texto;

        public EscrituraWrapper(string texto, ConsoleColor color)
        {
            this.color = color;
            this.texto = texto;
        }

        public ConsoleColor Color { get { return this.color; } }
        public string Texto { get { return this.texto; } }
    }
}
