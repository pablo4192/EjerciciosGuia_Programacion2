using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_Archivos_Ej03
{
    public partial class FrmNotePad : Form
    {
        OpenFileDialog open;
        SaveFileDialog save;
        string ultimoArchivoAbierto = string.Empty;


        public FrmNotePad()
        {
            InitializeComponent();
            open = new OpenFileDialog();
            save = new SaveFileDialog();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabelCaracteres.Text = this.rtbTexto.Text.Length.ToString();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabelCaracteres.Text = "0";
            this.save.Filter = "Archivo de texto|*.txt";
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivoAbierto = this.open.FileName;

                    using (StreamReader lector = new StreamReader(ultimoArchivoAbierto))
                    {
                        this.rtbTexto.Text = lector.ReadToEnd();
                        
                        
                    }
                }
                catch(Exception ex)
                {
                    this.MostrarVentanaDeError(ex);

                }
            }
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Guardar();

        }
                
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!File.Exists(ultimoArchivoAbierto))
            {
                this.Guardar();
            }
            else
            {
                using (StreamWriter escritor = new StreamWriter(ultimoArchivoAbierto))
                {
                    escritor.Write(this.rtbTexto.Text);
                }
                
            }
        }

        /// <summary>
        /// Guarda el archiva en la ruta elegida.
        /// </summary>
        /// <returns>True si guardo correctamente, False si fallo</returns>
        private bool Guardar()
        {
            if (this.save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ultimoArchivoAbierto = this.save.FileName;

                    if (!string.IsNullOrEmpty(ultimoArchivoAbierto))
                    {
                        using (StreamWriter escritor = new StreamWriter(ultimoArchivoAbierto))
                        {
                            escritor.Write(this.rtbTexto.Text);
                        }
                        return true;
                    }

                }
                catch (Exception ex)
                {
                    this.MostrarVentanaDeError(ex);
                }

            }
            return false;
        }

        /// <summary>
        /// Muestra los datos de la excepcion lanzada en caso de error.
        /// </summary>
        /// <param name="excepcion"></param>
        private void MostrarVentanaDeError(Exception excepcion)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Mensaje: {excepcion.Message}");
            sb.AppendLine($"Stack Trace de la excepcion: {excepcion.StackTrace}");

            MessageBox.Show(sb.ToString(), "Ventana de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
