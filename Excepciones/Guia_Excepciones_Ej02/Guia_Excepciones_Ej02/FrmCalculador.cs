using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Excepciones_Ej02;

namespace Guia_Excepciones_Ej02
{
    public partial class FrmCalculador : Form
    {
        public FrmCalculador()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarParametros();
                this.rtbResultado.Text = Calculador.Calcular(int.Parse(this.txtKilometros.Text), int.Parse(this.txtLitros.Text)).ToString("0.##");
            }
            catch(ParametrosVaciosException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException)
            {
                MessageBox.Show("No es posible realizar el calculo, Por favor verifique el formato de los datos ingresados");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ValidarParametros()
        {
            if (string.IsNullOrWhiteSpace(this.txtKilometros.Text) || string.IsNullOrWhiteSpace(this.txtLitros.Text))
                throw new ParametrosVaciosException("Verifique Los Parametros Kilometros y Litros, no pueden estar vacios");

        }

        
    }
}
