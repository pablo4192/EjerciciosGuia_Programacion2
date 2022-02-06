using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_Colecciones_Ej03
{
    public partial class FrmContadorPalabras : Form
    {

        Dictionary<string, int> diccionarioPalabras; 
        

        public FrmContadorPalabras()
        {
            InitializeComponent();
            diccionarioPalabras = new Dictionary<string, int>();
        }

        /// <summary>
        /// Cuenta la cantidad de veces que aparecen las palabras en el richTextBox
        /// </summary>
        private void ContarPalabras()
        {
            string palabra = string.Empty;

            for (int caracter = 0; caracter < this.rtbPalabras.TextLength; caracter++) //Esto haria el metodo Split de string
            {
                if(this.rtbPalabras.Text[caracter] != ' ') //Pensando solamente en el espacio como caracter de separacion de las palabras, se podrian agregar mas caracteres.
                {
                    palabra += this.rtbPalabras.Text[caracter];

                    if(caracter == this.rtbPalabras.TextLength - 1)
                    {
                        if (!diccionarioPalabras.ContainsKey(palabra))
                        {
                            diccionarioPalabras.Add(palabra, 1);
                        }
                        else
                        {
                            diccionarioPalabras[palabra]++;
                        }
                    }
                }
                else if(!string.IsNullOrEmpty(palabra))
                {
                    if (!diccionarioPalabras.ContainsKey(palabra))
                    {
                        diccionarioPalabras.Add(palabra, 1);
                    }
                    else
                    {
                        diccionarioPalabras[palabra]++;
                    }
                    palabra = string.Empty;
                }

            }
            
        }

        /// <summary>
        /// Ordena de manera Descendente por cantidad de apariciones de la palabra guiandose por el Value.
        /// </summary>
        /// <param name="elemento1"></param>
        /// <param name="elemento2"></param>
        /// <returns></returns>
        private int OrdenarDescendente(KeyValuePair<string, int> elemento1, KeyValuePair<string, int> elemento2)
        {
            return elemento2.Value - elemento1.Value; //Retorna un entero negativo si el elemento2.Value es < al elemento1.Value / viceversa entero positivo
        }

        /// <summary>
        /// Muestra un MessageBox con las tres palabra con mas apariciones 
        /// </summary>
        /// <param name="listaKeyValuePair"></param>
        private void Mostrar(List<KeyValuePair<string, int>> listaKeyValuePair)
        {
            StringBuilder sb= new StringBuilder();
            int puesto = 1;

            if(listaKeyValuePair.Count == 0)
            {
                sb.AppendLine("No se ingresaron palabras");
            }
            else
            {
                foreach (KeyValuePair<string, int> palabra in listaKeyValuePair)
                {
                    sb.AppendLine($"palabra: {palabra.Key}, cantidad de apariciones: {palabra.Value}");

                    if (puesto == 3)
                    {
                        break;
                    }
                    puesto++;
                }
            }
            MessageBox.Show(sb.ToString(), "Top 3 palabras con mas apariciones");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ContarPalabras();
            List<KeyValuePair<string, int>> listaPalabras = this.diccionarioPalabras.ToList();
            listaPalabras.Sort(OrdenarDescendente);

            Mostrar(listaPalabras);
            this.diccionarioPalabras.Clear();
            listaPalabras.Clear();
        }
    }
}
