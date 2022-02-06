namespace Guia_WindowsForm_EjC01
{
    partial class FrmConversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConversor));
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblEuroCantidad = new System.Windows.Forms.Label();
            this.lblDolarCantidad = new System.Windows.Forms.Label();
            this.lblPesoCantidad = new System.Windows.Forms.Label();
            this.txtCantidadEuro = new System.Windows.Forms.TextBox();
            this.txtCantidadDolar = new System.Windows.Forms.TextBox();
            this.txtCantidadPeso = new System.Windows.Forms.TextBox();
            this.btnCerrarCotizacion = new System.Windows.Forms.Button();
            this.imgLCandados = new System.Windows.Forms.ImageList(this.components);
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.btnConvertirPeso = new System.Windows.Forms.Button();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCotizacion.Location = new System.Drawing.Point(98, 29);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(93, 23);
            this.lblCotizacion.TabIndex = 0;
            this.lblCotizacion.Text = "Cotización";
            // 
            // lblEuroCantidad
            // 
            this.lblEuroCantidad.AutoSize = true;
            this.lblEuroCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEuroCantidad.Location = new System.Drawing.Point(32, 94);
            this.lblEuroCantidad.Name = "lblEuroCantidad";
            this.lblEuroCantidad.Size = new System.Drawing.Size(41, 20);
            this.lblEuroCantidad.TabIndex = 1;
            this.lblEuroCantidad.Text = "Euro";
            // 
            // lblDolarCantidad
            // 
            this.lblDolarCantidad.AutoSize = true;
            this.lblDolarCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDolarCantidad.Location = new System.Drawing.Point(32, 140);
            this.lblDolarCantidad.Name = "lblDolarCantidad";
            this.lblDolarCantidad.Size = new System.Drawing.Size(47, 20);
            this.lblDolarCantidad.TabIndex = 2;
            this.lblDolarCantidad.Text = "Dolar";
            // 
            // lblPesoCantidad
            // 
            this.lblPesoCantidad.AutoSize = true;
            this.lblPesoCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesoCantidad.Location = new System.Drawing.Point(32, 185);
            this.lblPesoCantidad.Name = "lblPesoCantidad";
            this.lblPesoCantidad.Size = new System.Drawing.Size(42, 20);
            this.lblPesoCantidad.TabIndex = 3;
            this.lblPesoCantidad.Text = "Peso";
            // 
            // txtCantidadEuro
            // 
            this.txtCantidadEuro.Location = new System.Drawing.Point(98, 87);
            this.txtCantidadEuro.Name = "txtCantidadEuro";
            this.txtCantidadEuro.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadEuro.TabIndex = 4;
            // 
            // txtCantidadDolar
            // 
            this.txtCantidadDolar.Location = new System.Drawing.Point(98, 133);
            this.txtCantidadDolar.Name = "txtCantidadDolar";
            this.txtCantidadDolar.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadDolar.TabIndex = 5;
            // 
            // txtCantidadPeso
            // 
            this.txtCantidadPeso.Location = new System.Drawing.Point(98, 178);
            this.txtCantidadPeso.Name = "txtCantidadPeso";
            this.txtCantidadPeso.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadPeso.TabIndex = 6;
            // 
            // btnCerrarCotizacion
            // 
            this.btnCerrarCotizacion.ImageList = this.imgLCandados;
            this.btnCerrarCotizacion.Location = new System.Drawing.Point(238, 27);
            this.btnCerrarCotizacion.Name = "btnCerrarCotizacion";
            this.btnCerrarCotizacion.Size = new System.Drawing.Size(94, 29);
            this.btnCerrarCotizacion.TabIndex = 7;
            this.btnCerrarCotizacion.UseVisualStyleBackColor = true;
            this.btnCerrarCotizacion.Click += new System.EventHandler(this.btnCerrarCotizacion_Click);
            // 
            // imgLCandados
            // 
            this.imgLCandados.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgLCandados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLCandados.ImageStream")));
            this.imgLCandados.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLCandados.Images.SetKeyName(0, "candado-abierto-b5de3132e0af02a85504b651d30bc2f2.png");
            this.imgLCandados.Images.SetKeyName(1, "candado-cerrado-70478025e99c4f192b160a3f43f145ed.png");
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.Location = new System.Drawing.Point(238, 85);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirEuro.TabIndex = 8;
            this.btnConvertirEuro.Text = "->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Location = new System.Drawing.Point(238, 131);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirDolar.TabIndex = 9;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // btnConvertirPeso
            // 
            this.btnConvertirPeso.Location = new System.Drawing.Point(238, 176);
            this.btnConvertirPeso.Name = "btnConvertirPeso";
            this.btnConvertirPeso.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirPeso.TabIndex = 10;
            this.btnConvertirPeso.Text = "->";
            this.btnConvertirPeso.UseVisualStyleBackColor = true;
            this.btnConvertirPeso.Click += new System.EventHandler(this.btnConvertirPeso_Click);
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(348, 29);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(103, 27);
            this.txtEuro.TabIndex = 11;
            this.txtEuro.Leave += new System.EventHandler(this.txtEuro_Leave);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(457, 29);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(103, 27);
            this.txtDolar.TabIndex = 12;
            this.txtDolar.Leave += new System.EventHandler(this.txtDolar_Leave);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(571, 29);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(103, 27);
            this.txtPeso.TabIndex = 13;
            this.txtPeso.Leave += new System.EventHandler(this.txtPeso_Leave);
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEuro.Location = new System.Drawing.Point(375, 64);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(41, 20);
            this.lblEuro.TabIndex = 14;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDolar.Location = new System.Drawing.Point(486, 64);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(47, 20);
            this.lblDolar.TabIndex = 15;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPeso.Location = new System.Drawing.Point(595, 64);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(42, 20);
            this.lblPeso.TabIndex = 16;
            this.lblPeso.Text = "Peso";
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(348, 87);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(103, 27);
            this.txtEuroAEuro.TabIndex = 17;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(457, 87);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(103, 27);
            this.txtEuroADolar.TabIndex = 18;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(571, 87);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.ReadOnly = true;
            this.txtEuroAPeso.Size = new System.Drawing.Size(103, 27);
            this.txtEuroAPeso.TabIndex = 19;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(348, 131);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(103, 27);
            this.txtDolarAEuro.TabIndex = 20;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(457, 131);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(103, 27);
            this.txtDolarADolar.TabIndex = 21;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(571, 133);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.ReadOnly = true;
            this.txtDolarAPeso.Size = new System.Drawing.Size(103, 27);
            this.txtDolarAPeso.TabIndex = 22;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(348, 176);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.ReadOnly = true;
            this.txtPesoAEuro.Size = new System.Drawing.Size(103, 27);
            this.txtPesoAEuro.TabIndex = 23;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(457, 176);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.ReadOnly = true;
            this.txtPesoADolar.Size = new System.Drawing.Size(103, 27);
            this.txtPesoADolar.TabIndex = 24;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(571, 176);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.ReadOnly = true;
            this.txtPesoAPeso.Size = new System.Drawing.Size(103, 27);
            this.txtPesoAPeso.TabIndex = 25;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(348, 6);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(0, 20);
            this.lblAviso.TabIndex = 26;
            // 
            // FrmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 226);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.btnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.btnCerrarCotizacion);
            this.Controls.Add(this.txtCantidadPeso);
            this.Controls.Add(this.txtCantidadDolar);
            this.Controls.Add(this.txtCantidadEuro);
            this.Controls.Add(this.lblPesoCantidad);
            this.Controls.Add(this.lblDolarCantidad);
            this.Controls.Add(this.lblEuroCantidad);
            this.Controls.Add(this.lblCotizacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.FrmConversor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCotizacion;
        private System.Windows.Forms.Label lblEuroCantidad;
        private System.Windows.Forms.Label lblDolarCantidad;
        private System.Windows.Forms.Label lblPesoCantidad;
        private System.Windows.Forms.TextBox txtCantidadEuro;
        private System.Windows.Forms.TextBox txtCantidadDolar;
        private System.Windows.Forms.TextBox txtCantidadPeso;
        private System.Windows.Forms.Button btnCerrarCotizacion;
        private System.Windows.Forms.ImageList imgLCandados;
        private System.Windows.Forms.Button btnConvertirEuro;
        private System.Windows.Forms.Button btnConvertirDolar;
        private System.Windows.Forms.Button btnConvertirPeso;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtEuroAEuro;
        private System.Windows.Forms.TextBox txtEuroADolar;
        private System.Windows.Forms.TextBox txtEuroAPeso;
        private System.Windows.Forms.TextBox txtDolarAEuro;
        private System.Windows.Forms.TextBox txtDolarADolar;
        private System.Windows.Forms.TextBox txtDolarAPeso;
        private System.Windows.Forms.TextBox txtPesoAEuro;
        private System.Windows.Forms.TextBox txtPesoADolar;
        private System.Windows.Forms.TextBox txtPesoAPeso;
        private System.Windows.Forms.Label lblAviso;
    }
}
