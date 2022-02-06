using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_WForm_Ej02;

namespace Guia_WindowsForm_Ej02
{
    public partial class FrmRegistro : Form
    {
        

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            lstPaises.Items.Add("Argentina");
            lstPaises.Items.Add("Chile");
            lstPaises.Items.Add("Uruguay");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos())
            {
                Ingresante ingresante = new Ingresante(this.txtNombre.Text, this.txtDireccion.Text, RetornarGenero(), this.lstPaises.SelectedItem.ToString(), RetornarCursos(), (int)this.nudEdad.Value);
                MessageBox.Show(ingresante.Mostrar(), "Datos del Ingresante", MessageBoxButtons.OK);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Complete los campos del formulario!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        /// <summary>
        /// Retorna el genero elegido por el usuario
        /// </summary>
        /// <returns>String con el genero elegido</returns>
        private string RetornarGenero()
        {
            foreach (RadioButton item in this.grbGenero.Controls)
            {
                if(item.Checked)
                {
                    return item.Text;
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Retorna el campo Genero al valor inicial
        /// </summary>
        private void LimpiarGenero()
        {
            foreach (RadioButton item in this.grbGenero.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
            
        }

        /// <summary>
        /// Retorna los cursos elegidos por el usuario
        /// </summary>
        /// <returns>Array de cursos elegidos</returns>
        private string[] RetornarCursos()
        {
            string[] cursos = new string[3];
            int indice = 0;

            foreach (CheckBox item in this.grbCursos.Controls)
            {
                if(item.Checked)
                {
                    cursos[indice] = item.Text;
                    indice++;
                }
                
            }
            return cursos;
        }

        /// <summary>
        /// Retorna el campo Cursos al valor inicial
        /// </summary>
        private void LimpiarCursos()
        {
            int indice = 0;

            foreach (CheckBox item in this.grbCursos.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                    indice++;
                }

            }
            
        }

        /// <summary>
        /// Valida los datos completados por el usuario
        /// </summary>
        /// <returns>True si fue validado correctamente, False error</returns>
        private bool ValidarDatos()
        {
            if(string.IsNullOrEmpty(this.txtNombre.Text) || string.IsNullOrEmpty(this.txtDireccion.Text) ||
                RetornarGenero() == string.Empty || this.lstPaises.SelectedItem is null )
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Limpia los campos a completar por el usuario
        /// </summary>
        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDireccion.Text = string.Empty;
            this.nudEdad.Value = 1;
            LimpiarGenero();
            LimpiarCursos();
            this.lstPaises.SelectedItem = null;

        }
    }
}
