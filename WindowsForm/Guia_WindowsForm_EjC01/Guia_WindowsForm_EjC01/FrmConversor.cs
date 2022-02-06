using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Cotizador;

namespace Guia_WindowsForm_EjC01
{
    public partial class FrmConversor : Form
    {
        bool flagCerrado = true;

        public FrmConversor()
        {
            InitializeComponent();
        }

        private void FrmConversor_Load(object sender, EventArgs e)
        {
            this.btnCerrarCotizacion.Image = imgLCandados.Images[1];
            this.txtDolar.Text = "1";

            this.txtDolar.Enabled = false;
            this.txtEuro.Enabled = false;
            this.txtPeso.Enabled = false;

            this.lblAviso.Visible = false;
            
        }

        private void btnCerrarCotizacion_Click(object sender, EventArgs e)
        {
            if(flagCerrado)
            {
                this.txtDolar.Enabled = true;
                this.txtEuro.Enabled = true;
                this.txtPeso.Enabled = true;

                this.btnCerrarCotizacion.Image = imgLCandados.Images[0];
                flagCerrado = false;
            }
            else
            {
                this.txtDolar.Enabled = false;
                this.txtEuro.Enabled = false;
                this.txtPeso.Enabled = false;

                this.btnCerrarCotizacion.Image = imgLCandados.Images[1];
                flagCerrado = true;
            }
               
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            if(this.txtDolar.Text != "1")
            this.txtDolar.Text = "1";
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {
            if(!Euro.SetCotizacion(this.txtEuro.Text))
            {
                this.lblAviso.Text = "Cotización incorrecta, ingrese un numero positivo";
                this.lblAviso.Visible = true;

                this.txtEuro.Text = string.Empty;
                this.txtEuro.Focus();
            }
            else
            {
                this.lblAviso.Visible = false;
            }

            
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            if (!Peso.SetCotizacion(this.txtPeso.Text))
            {
                this.lblAviso.Text = "Cotización incorrecta, ingrese un numero positivo";
                this.lblAviso.Visible = true;

                this.txtPeso.Text = string.Empty;
                this.txtPeso.Focus();
            }
            else
            {
                this.lblAviso.Visible = false;
            }
        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            double cantidad;

            if(double.TryParse(this.txtCantidadEuro.Text, out cantidad) && cantidad > 0)
            {
                Euro euro = new Euro(cantidad);
                this.txtEuroAEuro.Text = cantidad.ToString();
                this.txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
                this.txtEuroAPeso.Text = ((Peso)euro).GetCantidad().ToString();
                lblAviso.Visible = false;
            }
            else
            {
                this.lblAviso.Text = "La cantidad ingresada no es valida";
                this.lblAviso.Visible = true;
            }

            
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            double cantidad;

            if (double.TryParse(this.txtCantidadDolar.Text, out cantidad) && cantidad > 0)
            {
                Dolar dolar = new Dolar(cantidad);
                this.txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
                this.txtDolarADolar.Text = cantidad.ToString();
                this.txtDolarAPeso.Text = ((Peso)dolar).GetCantidad().ToString();
                lblAviso.Visible = false;
            }
            else
            {
                this.lblAviso.Text = "La cantidad ingresada no es valida";
                this.lblAviso.Visible = true;
            }
        }

        private void btnConvertirPeso_Click(object sender, EventArgs e)
        {
            double cantidad;

            if (double.TryParse(this.txtCantidadPeso.Text, out cantidad) && cantidad > 0)
            {
                Peso peso = new Peso(cantidad);
                this.txtPesoAEuro.Text = ((Euro)peso).GetCantidad().ToString();
                this.txtPesoAPeso.Text = cantidad.ToString();
                this.txtPesoADolar.Text = ((Dolar)peso).GetCantidad().ToString();
                lblAviso.Visible = false;
            }
            else
            {
                this.lblAviso.Text = "La cantidad ingresada no es valida";
                this.lblAviso.Visible = true;
            }
        }
    }
}
