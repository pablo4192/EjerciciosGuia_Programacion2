using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Centralita2;

namespace FrmMenu
{
    public partial class FrmCentralTelefonica : Form
    {
        Centralita centralita = new Centralita("La Centralituti");

        public FrmCentralTelefonica()
        {
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.centralita);
            llamador.ShowDialog();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita);
            frmMostrar.TipoLlamada = Llamada.ETipoLlamada.Todas;
            frmMostrar.ShowDialog();
            
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita);
            frmMostrar.TipoLlamada = Llamada.ETipoLlamada.Local;
            frmMostrar.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(this.centralita);
            frmMostrar.TipoLlamada = Llamada.ETipoLlamada.Provincial;
            frmMostrar.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
