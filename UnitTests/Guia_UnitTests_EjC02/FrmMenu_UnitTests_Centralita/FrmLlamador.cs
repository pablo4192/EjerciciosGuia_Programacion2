using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guia_UnitTests_EjC02;

namespace FrmMenu_UnitTests_Centralita
{
    public partial class FrmLlamador : Form
    {
        public FrmLlamador(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        Centralita centralita;
        bool flagNroDestino = true;

        public Centralita Centralita { get { return this.centralita; } }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "1";
            else
                this.txtNroOrigen.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "2";
            else
                this.txtNroOrigen.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "3";
            else
                this.txtNroOrigen.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "4";
            else
                this.txtNroOrigen.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "5";
            else
                this.txtNroOrigen.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "6";
            else
                this.txtNroOrigen.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "7";
            else
                this.txtNroOrigen.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "8";
            else
                this.txtNroOrigen.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "9";
            else
                this.txtNroOrigen.Text += "9";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "*";
            else
                this.txtNroOrigen.Text += "*";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
                this.txtNroDestino.Text += "0";
            else
                this.txtNroOrigen.Text += "0";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            if (flagNroDestino)
            {
                this.txtNroDestino.Text += "#";
                if (this.txtNroDestino.Text[0] == '#')
                {
                    this.cmbFranja.Enabled = true;
                }
            }
            else
                this.txtNroOrigen.Text += "#";

        }

        private void txtNroDestino_Leave(object sender, EventArgs e)
        {
            //Borrar del designer
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = string.Empty;
            this.txtNroOrigen.Text = string.Empty;
            this.cmbFranja.Enabled = false;
            this.lblAviso.Visible = false;

        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.EFranja));
            this.cmbFranja.Enabled = false;

        }

        private void txtNroOrigen_Enter(object sender, EventArgs e)
        {
            flagNroDestino = false;
        }

        private void txtNroDestino_Enter(object sender, EventArgs e)
        {
            flagNroDestino = true;
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracionRand = new Random();

            if (!ValidarNumeros(this.txtNroDestino.Text) || !ValidarNumeros(this.txtNroOrigen.Text))
            {
                MessageBox.Show("Error al llamar, verifique los numeros de destino y origen!", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (this.txtNroDestino.Text[0] == '#')
                    {
                        Llamada nuevaLlamada = new Provincial(this.txtNroOrigen.Text, (Provincial.EFranja)this.cmbFranja.SelectedItem, duracionRand.Next(1, 50), this.txtNroDestino.Text);
                        this.centralita = this.centralita + nuevaLlamada;
                    }
                    else
                    {
                        Llamada nuevaLlamada = new Local(this.txtNroOrigen.Text, duracionRand.Next(1, 50), this.txtNroDestino.Text, RetornarCostoFlotante(0.5, 5.6));
                        this.centralita = this.centralita + nuevaLlamada;
                    }
                    this.lblAviso.Visible = true;
                    this.lblAviso.Text = "Se realizo la llamada con exito";
                }
                catch (CentralitaException ex)
                {
                    MessageBox.Show($"{ex.Message}\nNombre Clase: {ex.NombreClase}\nNombre Metodo: {ex.NombreMetodo}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.lblAviso.Visible = false;
                }


            }


        }

        private float RetornarCostoFlotante(double min, double max)
        {
            Random costoLocalRand = new Random();
            float costo;

            do
            {
                costo = (float)(costoLocalRand.NextDouble() + costoLocalRand.Next(0, 5));

            } while (costo > max || costo < min);

            return costo;
        }

        private bool ValidarNumeros(string numeroAValidar)
        {
            if (string.IsNullOrWhiteSpace(numeroAValidar))
                return false;

            for (int letra = 1; letra < numeroAValidar.Length; letra++)
            {
                if (numeroAValidar[letra] == '#' || numeroAValidar[letra] == '*')
                    return false;
            }

            return true;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
