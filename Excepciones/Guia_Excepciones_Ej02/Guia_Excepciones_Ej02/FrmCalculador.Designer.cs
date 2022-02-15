namespace Guia_Excepciones_Ej02
{
    partial class FrmCalculador
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
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(28, 24);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(81, 20);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(28, 107);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(45, 20);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(28, 62);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(125, 27);
            this.txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(28, 140);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(125, 27);
            this.txtLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(28, 185);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(125, 35);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(210, 21);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.Size = new System.Drawing.Size(300, 199);
            this.rtbResultado.TabIndex = 5;
            this.rtbResultado.Text = "";
            // 
            // FrmCalculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 243);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKilometros);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKilometros;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.TextBox txtLitros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RichTextBox rtbResultado;
    }
}
