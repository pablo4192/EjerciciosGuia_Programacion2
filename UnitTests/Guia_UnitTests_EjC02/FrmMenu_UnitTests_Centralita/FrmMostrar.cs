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
    public partial class FrmMostrar : Form
    {
        public FrmMostrar(Centralita centralita)
        {
            InitializeComponent();
            this.centralita = centralita;
        }

        Llamada.ETipoLlamada tipoLlamada;
        Centralita centralita;

        public Llamada.ETipoLlamada TipoLlamada { set { this.tipoLlamada = value; } }


        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            if (tipoLlamada == Llamada.ETipoLlamada.Local)
            {
                sb.AppendLine("Ganancias por llamadas Locales:");
                sb.AppendLine("$" + this.centralita.GananciaporLocal.ToString("0.##"));
            }
            else if (tipoLlamada == Llamada.ETipoLlamada.Provincial)
            {
                sb.AppendLine("Ganancias por llamadas Provinciales:");
                sb.AppendLine("$" + this.centralita.GananciaPorProvincia.ToString("0.##"));
            }
            else
            {
                sb.AppendLine("Ganancias por llamadas Totales:");
                sb.AppendLine("$" + this.centralita.GananciaPorTotal.ToString("0.##"));
            }

            this.rtbFacturacion.Text = sb.ToString();

        }
    }
}
