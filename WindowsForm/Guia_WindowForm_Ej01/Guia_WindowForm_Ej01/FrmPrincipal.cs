using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_WindowForm_Ej01
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtNombre.Text) && string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre \nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrWhiteSpace(this.txtNombre.Text) )
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrWhiteSpace(this.txtApellido.Text))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                FrmSaludo frmSaludo = new FrmSaludo(this.Text, $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {this.cmbMaterias.Text}");
                frmSaludo.ShowDialog();

                this.txtNombre.Text = string.Empty;
                this.txtApellido.Text = string.Empty;
            }
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.Items.Add("Progamacion1");
            this.cmbMaterias.Items.Add("Progamacion2");
            this.cmbMaterias.Items.Add("Matematica");
            this.cmbMaterias.Items.Add("Spd");
            this.cmbMaterias.Items.Add("Ingles");
            this.cmbMaterias.Items.Add("Metodologia");
            this.cmbMaterias.SelectedIndex = 0;
            
        }
    }
}
