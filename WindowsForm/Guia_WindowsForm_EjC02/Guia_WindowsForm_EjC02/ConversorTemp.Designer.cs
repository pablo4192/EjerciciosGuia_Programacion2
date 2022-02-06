namespace Guia_WindowsForm_EjC02
{
    partial class FrmConversorTemp
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
            this.lblFahrenheitCantidad = new System.Windows.Forms.Label();
            this.lblCelsiusCantidad = new System.Windows.Forms.Label();
            this.lblKelvinCantidad = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.btnConvertirFahrenheit = new System.Windows.Forms.Button();
            this.btnConvertirCelsius = new System.Windows.Forms.Button();
            this.btnConvertirKelvin = new System.Windows.Forms.Button();
            this.txtFahrenheitCantidad = new System.Windows.Forms.TextBox();
            this.txtCelsiusCantidad = new System.Windows.Forms.TextBox();
            this.txtKelvinCantidad = new System.Windows.Forms.TextBox();
            this.txtFahrAFahr = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahr = new System.Windows.Forms.TextBox();
            this.txtKelvinAFahr = new System.Windows.Forms.TextBox();
            this.txtFahrACelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFahrenheitCantidad
            // 
            this.lblFahrenheitCantidad.AutoSize = true;
            this.lblFahrenheitCantidad.Location = new System.Drawing.Point(12, 67);
            this.lblFahrenheitCantidad.Name = "lblFahrenheitCantidad";
            this.lblFahrenheitCantidad.Size = new System.Drawing.Size(77, 20);
            this.lblFahrenheitCantidad.TabIndex = 0;
            this.lblFahrenheitCantidad.Text = "Fahrenheit";
            // 
            // lblCelsiusCantidad
            // 
            this.lblCelsiusCantidad.AutoSize = true;
            this.lblCelsiusCantidad.Location = new System.Drawing.Point(12, 129);
            this.lblCelsiusCantidad.Name = "lblCelsiusCantidad";
            this.lblCelsiusCantidad.Size = new System.Drawing.Size(54, 20);
            this.lblCelsiusCantidad.TabIndex = 1;
            this.lblCelsiusCantidad.Text = "Celsius";
            // 
            // lblKelvinCantidad
            // 
            this.lblKelvinCantidad.AutoSize = true;
            this.lblKelvinCantidad.Location = new System.Drawing.Point(12, 183);
            this.lblKelvinCantidad.Name = "lblKelvinCantidad";
            this.lblKelvinCantidad.Size = new System.Drawing.Size(49, 20);
            this.lblKelvinCantidad.TabIndex = 2;
            this.lblKelvinCantidad.Text = "Kelvin";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(317, 23);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(77, 20);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Location = new System.Drawing.Point(469, 23);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(54, 20);
            this.lblCelsius.TabIndex = 4;
            this.lblCelsius.Text = "Celsius";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(633, 23);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(49, 20);
            this.lblKelvin.TabIndex = 5;
            this.lblKelvin.Text = "Kelvin";
            // 
            // btnConvertirFahrenheit
            // 
            this.btnConvertirFahrenheit.Location = new System.Drawing.Point(211, 62);
            this.btnConvertirFahrenheit.Name = "btnConvertirFahrenheit";
            this.btnConvertirFahrenheit.Size = new System.Drawing.Size(77, 29);
            this.btnConvertirFahrenheit.TabIndex = 6;
            this.btnConvertirFahrenheit.Text = "->";
            this.btnConvertirFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertirFahrenheit.Click += new System.EventHandler(this.btnConvertirFahrenheit_Click);
            // 
            // btnConvertirCelsius
            // 
            this.btnConvertirCelsius.Location = new System.Drawing.Point(211, 118);
            this.btnConvertirCelsius.Name = "btnConvertirCelsius";
            this.btnConvertirCelsius.Size = new System.Drawing.Size(77, 29);
            this.btnConvertirCelsius.TabIndex = 7;
            this.btnConvertirCelsius.Text = "->";
            this.btnConvertirCelsius.UseVisualStyleBackColor = true;
            this.btnConvertirCelsius.Click += new System.EventHandler(this.btnConvertirCelsius_Click);
            // 
            // btnConvertirKelvin
            // 
            this.btnConvertirKelvin.Location = new System.Drawing.Point(211, 176);
            this.btnConvertirKelvin.Name = "btnConvertirKelvin";
            this.btnConvertirKelvin.Size = new System.Drawing.Size(77, 29);
            this.btnConvertirKelvin.TabIndex = 8;
            this.btnConvertirKelvin.Text = "->";
            this.btnConvertirKelvin.UseVisualStyleBackColor = true;
            this.btnConvertirKelvin.Click += new System.EventHandler(this.btnConvertirKelvin_Click);
            // 
            // txtFahrenheitCantidad
            // 
            this.txtFahrenheitCantidad.Location = new System.Drawing.Point(95, 60);
            this.txtFahrenheitCantidad.Name = "txtFahrenheitCantidad";
            this.txtFahrenheitCantidad.Size = new System.Drawing.Size(95, 27);
            this.txtFahrenheitCantidad.TabIndex = 9;
            this.txtFahrenheitCantidad.Leave += new System.EventHandler(this.txtFahrenheitCantidad_Leave);
            // 
            // txtCelsiusCantidad
            // 
            this.txtCelsiusCantidad.Location = new System.Drawing.Point(95, 120);
            this.txtCelsiusCantidad.Name = "txtCelsiusCantidad";
            this.txtCelsiusCantidad.Size = new System.Drawing.Size(95, 27);
            this.txtCelsiusCantidad.TabIndex = 10;
            this.txtCelsiusCantidad.Leave += new System.EventHandler(this.txtCelsiusCantidad_Leave);
            // 
            // txtKelvinCantidad
            // 
            this.txtKelvinCantidad.Location = new System.Drawing.Point(95, 177);
            this.txtKelvinCantidad.Name = "txtKelvinCantidad";
            this.txtKelvinCantidad.Size = new System.Drawing.Size(95, 27);
            this.txtKelvinCantidad.TabIndex = 11;
            this.txtKelvinCantidad.Leave += new System.EventHandler(this.txtKelvinCantidad_Leave);
            // 
            // txtFahrAFahr
            // 
            this.txtFahrAFahr.Location = new System.Drawing.Point(317, 64);
            this.txtFahrAFahr.Name = "txtFahrAFahr";
            this.txtFahrAFahr.Size = new System.Drawing.Size(125, 27);
            this.txtFahrAFahr.TabIndex = 12;
            // 
            // txtCelsiusAFahr
            // 
            this.txtCelsiusAFahr.Location = new System.Drawing.Point(317, 120);
            this.txtCelsiusAFahr.Name = "txtCelsiusAFahr";
            this.txtCelsiusAFahr.Size = new System.Drawing.Size(125, 27);
            this.txtCelsiusAFahr.TabIndex = 13;
            // 
            // txtKelvinAFahr
            // 
            this.txtKelvinAFahr.Location = new System.Drawing.Point(317, 176);
            this.txtKelvinAFahr.Name = "txtKelvinAFahr";
            this.txtKelvinAFahr.Size = new System.Drawing.Size(125, 27);
            this.txtKelvinAFahr.TabIndex = 14;
            // 
            // txtFahrACelsius
            // 
            this.txtFahrACelsius.Location = new System.Drawing.Point(469, 64);
            this.txtFahrACelsius.Name = "txtFahrACelsius";
            this.txtFahrACelsius.Size = new System.Drawing.Size(125, 27);
            this.txtFahrACelsius.TabIndex = 15;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(469, 120);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(125, 27);
            this.txtCelsiusACelsius.TabIndex = 16;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Location = new System.Drawing.Point(469, 176);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.Size = new System.Drawing.Size(125, 27);
            this.txtKelvinACelsius.TabIndex = 17;
            // 
            // txtFahrAKelvin
            // 
            this.txtFahrAKelvin.Location = new System.Drawing.Point(626, 63);
            this.txtFahrAKelvin.Name = "txtFahrAKelvin";
            this.txtFahrAKelvin.Size = new System.Drawing.Size(125, 27);
            this.txtFahrAKelvin.TabIndex = 18;
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(626, 120);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(125, 27);
            this.txtCelsiusAKelvin.TabIndex = 19;
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(626, 176);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(125, 27);
            this.txtKelvinAKelvin.TabIndex = 20;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(12, 33);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(100, 20);
            this.lblAviso.TabIndex = 21;
            this.lblAviso.Text = "Valor invalido";
            this.lblAviso.Visible = false;
            // 
            // FrmConversorTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 226);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtFahrAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtFahrACelsius);
            this.Controls.Add(this.txtKelvinAFahr);
            this.Controls.Add(this.txtCelsiusAFahr);
            this.Controls.Add(this.txtFahrAFahr);
            this.Controls.Add(this.txtKelvinCantidad);
            this.Controls.Add(this.txtCelsiusCantidad);
            this.Controls.Add(this.txtFahrenheitCantidad);
            this.Controls.Add(this.btnConvertirKelvin);
            this.Controls.Add(this.btnConvertirCelsius);
            this.Controls.Add(this.btnConvertirFahrenheit);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblCelsius);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.lblKelvinCantidad);
            this.Controls.Add(this.lblCelsiusCantidad);
            this.Controls.Add(this.lblFahrenheitCantidad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConversorTemp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Temperatura";
            this.Load += new System.EventHandler(this.FrmConversorTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheitCantidad;
        private System.Windows.Forms.Label lblCelsiusCantidad;
        private System.Windows.Forms.Label lblKelvinCantidad;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Button btnConvertirFahrenheit;
        private System.Windows.Forms.Button btnConvertirCelsius;
        private System.Windows.Forms.Button btnConvertirKelvin;
        private System.Windows.Forms.TextBox txtFahrenheitCantidad;
        private System.Windows.Forms.TextBox txtCelsiusCantidad;
        private System.Windows.Forms.TextBox txtKelvinCantidad;
        private System.Windows.Forms.TextBox txtFahrAFahr;
        private System.Windows.Forms.TextBox txtCelsiusAFahr;
        private System.Windows.Forms.TextBox txtKelvinAFahr;
        private System.Windows.Forms.TextBox txtFahrACelsius;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtFahrAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.Label lblAviso;
    }
}
