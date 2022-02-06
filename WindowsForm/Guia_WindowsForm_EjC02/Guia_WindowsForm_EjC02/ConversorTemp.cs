using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Guia_WindowsForm_EjC02
{
    public partial class FrmConversorTemp : Form
    {
        public FrmConversorTemp()
        {
            InitializeComponent();
        }

        private void txtFahrenheitCantidad_Leave(object sender, EventArgs e)
        {
            double grados;

            if(!double.TryParse(this.txtFahrenheitCantidad.Text, out grados))
            {
                
                this.lblAviso.Visible = true;
                this.txtFahrenheitCantidad.Focus();
                
            }
            else
            {
                
                this.lblAviso.Visible = false;
            }
        }

        private void txtCelsiusCantidad_Leave(object sender, EventArgs e)
        {
            double grados;

            if (!double.TryParse(this.txtCelsiusCantidad.Text, out grados))
            {
               
                this.lblAviso.Visible = true;
                this.txtCelsiusCantidad.Focus();

            }
            else
            {
                
                this.lblAviso.Visible = false;
            }
        }

        private void txtKelvinCantidad_Leave(object sender, EventArgs e)
        {
            double grados;

            if (!double.TryParse(this.txtKelvinCantidad.Text, out grados))
            {
                
                this.lblAviso.Visible = true;
                this.txtKelvinCantidad.Focus();

            }
            else
            {
               
                this.lblAviso.Visible = false;
            }
        }

        private void btnConvertirFahrenheit_Click(object sender, EventArgs e)
        {
            double grados;

            if(double.TryParse(this.txtFahrenheitCantidad.Text, out grados))
            {
                Fahrenheit fahrenheit = new Fahrenheit(grados);

                this.txtFahrAFahr.Text = fahrenheit.GetGrados().ToString();
                this.txtFahrACelsius.Text = ((Celsius)fahrenheit).GetGrados().ToString();
                this.txtFahrAKelvin.Text = ((Kelvin)fahrenheit).GetGrados().ToString();
                lblAviso.Visible = false;
            }
            else
            {
                lblAviso.Visible = true;
            }

            
        }

        private void btnConvertirCelsius_Click(object sender, EventArgs e)
        {
            double grados;

            if(double.TryParse(this.txtCelsiusCantidad.Text, out grados))
            {
                Celsius celsius = new Celsius(grados);

                this.txtCelsiusACelsius.Text = celsius.GetGrados().ToString();
                this.txtCelsiusAFahr.Text = ((Fahrenheit)celsius).GetGrados().ToString();
                this.txtCelsiusAKelvin.Text = ((Kelvin)celsius).GetGrados().ToString();
                this.lblAviso.Visible = false;
            }
            else
            {
                lblAviso.Visible = true;
            }


        }

        private void btnConvertirKelvin_Click(object sender, EventArgs e)
        {
            double grados;

            if(double.TryParse(this.txtKelvinCantidad.Text, out grados))
            {
                Kelvin kelvin = new Kelvin(grados);

                this.txtKelvinAKelvin.Text = kelvin.GetGrados().ToString();
                this.txtKelvinACelsius.Text = ((Celsius)kelvin).GetGrados().ToString();
                this.txtKelvinAFahr.Text = ((Fahrenheit)kelvin).GetGrados().ToString();
                this.lblAviso.Visible = false;
            }
            else
            {
                this.lblAviso.Visible = true;
            }

           
        }

        private void FrmConversorTemp_Load(object sender, EventArgs e)
        {
            this.txtFahrAFahr.ReadOnly = true;
            this.txtFahrACelsius.ReadOnly = true;
            this.txtFahrAKelvin.ReadOnly = true;
            this.txtCelsiusACelsius.ReadOnly = true;
            this.txtCelsiusAFahr.ReadOnly = true;
            this.txtCelsiusAKelvin.ReadOnly = true;
            this.txtKelvinAKelvin.ReadOnly = true;
            this.txtKelvinAFahr.ReadOnly = true;
            this.txtKelvinACelsius.ReadOnly = true;
        }
    }
}
