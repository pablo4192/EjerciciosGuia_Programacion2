using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.ConfigurarLogoSistemaOperativo();
            this.ConfigurarArquitectura();
            this.ConfigurarEspacioTotalYDisponible();
            this.lblSistemaOperativo.Text = $"Sistema Operativo: [{Environment.OSVersion.Platform}, Version: {Environment.OSVersion.Version}]";
            this.lblNombreMaquina.Text = $"Nombre de la Maquina: [{Environment.MachineName}]";
            this.Text = $"Compu de [{Environment.UserName}]";
            this.lblCantProcesadores.Text = $"Cant. Procesadores: {Environment.ProcessorCount} Procesadores logicos";
            this.lblDirectorioActual.Text = $"Identificación ejecutada en: [{Environment.NewLine}{Environment.CurrentDirectory}]";
        }

        /// <summary>
        /// Asigna el valor a picboxSistemaOperativo.Image segun el sistema operativo don de este ejecutando el programa.
        /// </summary>
        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            else if(OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else if(OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
        }

        /// <summary>
        /// Asigna el valor a lblArquitectura.Text segun la arquitectura de la maquina donde se corra el programa.
        /// </summary>
        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                this.lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                this.lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        /// <summary>
        /// Calcula el espacio total y disponible en Gigabytes de todas las unidades de almacenamiento de la maquina.
        /// </summary>
        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotal = 0;
            long espacioDisponible = 0;

            foreach (DriveInfo item in DriveInfo.GetDrives())
            {
                if(item.IsReady)
                {
                    espacioTotal += item.TotalSize;
                    espacioDisponible += item.AvailableFreeSpace;
                }
                
            }

            this.lblEspacioTotal.Text = $"Espacio Total: {(int)(espacioTotal / 1073741824)} Gigabytes";
            this.lblEspacioDisponible.Text = $"Espacio Disponible { (int)(espacioDisponible / 1073741824)} Gigabytes";
        }
    }
}
