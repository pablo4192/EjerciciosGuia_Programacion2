using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_Conversor;

namespace Guia_WindowsForm_EjC03
{
    public partial class FrmConversosrBinario : Form
    {
        bool flagNumeroValido = false;
        double numero;

        public FrmConversosrBinario()
        {
            InitializeComponent();
        }

        private void FrmConversosrBinario_Load(object sender, EventArgs e)
        {
            lblAviso.Visible = false;
            this.txtBinADec.ReadOnly = true;
            this.txtDecABin.ReadOnly = true;
        }

        private void txtBinario_Leave(object sender, EventArgs e)
        {
            if(Conversor.ConvertirBinarioADecimal(this.txtBinario.Text) == -1 && !string.IsNullOrWhiteSpace(this.txtBinario.Text))
            {
                lblAviso.Visible = true;
                this.txtBinario.Focus();
            }
            else
            {
                lblAviso.Visible = false;
            }
        }

        private void btnConvertirADec_Click(object sender, EventArgs e)
        {
            this.txtBinADec.Text = Conversor.ConvertirBinarioADecimal(this.txtBinario.Text).ToString();
        }

        private void txtDecimal_Leave(object sender, EventArgs e)
        {
            if( (!double.TryParse(this.txtDecimal.Text, out this.numero) || this.numero < 0) && !string.IsNullOrWhiteSpace(this.txtDecimal.Text))
            {
               
                    lblAviso.Visible = true;
                    txtDecimal.Focus();
                
            }
            else
            {
                lblAviso.Visible = false;
                this.flagNumeroValido = true;
            }
        }

        private void btnConvertirABin_Click(object sender, EventArgs e)
        {
            if(flagNumeroValido)
            {
                this.txtDecABin.Text = Conversor.ConvertirDecimalABinario(this.numero);
            }
        }
    }
}
