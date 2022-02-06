using System;

namespace Entidades
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = Console.ForegroundColor = color;
        }

        /// <summary>
        /// Getter de atributo color.
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// Getter de atributo tinta.
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// Setter de atributo tinta
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            if(tinta < 0 && this.tinta - tinta > -1)
            {
                this.tinta += tinta;
            }
            else if(tinta >= 0 && this.tinta + tinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
            else if(tinta == cantidadTintaMaxima)
            {
                this.tinta = cantidadTintaMaxima;
            }
        }

        /// <summary>
        /// Recargar el atributo tinta con la cantidad maxima de tinta permitida.
        /// </summary>
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        /// <summary>
        /// Arma una cadena de "*" segun el argumento gasto.
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns>True si hay tinta para pintar, False si no alcanza la tinta. </returns>
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = "";

            if (this.tinta <= 0)
            {
                return false;
            }

            for(int unidadTinta = 0; unidadTinta < gasto; unidadTinta++)
            {
                if(this.tinta > 0)
                {
                    SetTinta(-1);
                    dibujo += "*";
                }
            }
            return true;
        }
    }
}
