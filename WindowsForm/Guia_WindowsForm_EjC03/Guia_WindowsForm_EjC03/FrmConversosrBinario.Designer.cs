namespace Guia_WindowsForm_EjC03
{
    partial class FrmConversosrBinario
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
            this.lblBinADec = new System.Windows.Forms.Label();
            this.lblDecABin = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnConvertirADec = new System.Windows.Forms.Button();
            this.btnConvertirABin = new System.Windows.Forms.Button();
            this.txtBinADec = new System.Windows.Forms.TextBox();
            this.txtDecABin = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBinADec
            // 
            this.lblBinADec.AutoSize = true;
            this.lblBinADec.Location = new System.Drawing.Point(12, 37);
            this.lblBinADec.Name = "lblBinADec";
            this.lblBinADec.Size = new System.Drawing.Size(127, 20);
            this.lblBinADec.TabIndex = 0;
            this.lblBinADec.Text = "Binario a Decimal";
            // 
            // lblDecABin
            // 
            this.lblDecABin.AutoSize = true;
            this.lblDecABin.Location = new System.Drawing.Point(12, 78);
            this.lblDecABin.Name = "lblDecABin";
            this.lblDecABin.Size = new System.Drawing.Size(127, 20);
            this.lblDecABin.TabIndex = 1;
            this.lblDecABin.Text = "Decimal a Binario";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(140, 30);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(125, 27);
            this.txtBinario.TabIndex = 2;
            this.txtBinario.Leave += new System.EventHandler(this.txtBinario_Leave);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(140, 71);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(125, 27);
            this.txtDecimal.TabIndex = 3;
            this.txtDecimal.Leave += new System.EventHandler(this.txtDecimal_Leave);
            // 
            // btnConvertirADec
            // 
            this.btnConvertirADec.Location = new System.Drawing.Point(271, 30);
            this.btnConvertirADec.Name = "btnConvertirADec";
            this.btnConvertirADec.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirADec.TabIndex = 4;
            this.btnConvertirADec.Text = "->";
            this.btnConvertirADec.UseVisualStyleBackColor = true;
            this.btnConvertirADec.Click += new System.EventHandler(this.btnConvertirADec_Click);
            // 
            // btnConvertirABin
            // 
            this.btnConvertirABin.Location = new System.Drawing.Point(271, 70);
            this.btnConvertirABin.Name = "btnConvertirABin";
            this.btnConvertirABin.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirABin.TabIndex = 5;
            this.btnConvertirABin.Text = "->";
            this.btnConvertirABin.UseVisualStyleBackColor = true;
            this.btnConvertirABin.Click += new System.EventHandler(this.btnConvertirABin_Click);
            // 
            // txtBinADec
            // 
            this.txtBinADec.Location = new System.Drawing.Point(371, 30);
            this.txtBinADec.Name = "txtBinADec";
            this.txtBinADec.Size = new System.Drawing.Size(125, 27);
            this.txtBinADec.TabIndex = 6;
            // 
            // txtDecABin
            // 
            this.txtDecABin.Location = new System.Drawing.Point(371, 70);
            this.txtDecABin.Name = "txtDecABin";
            this.txtDecABin.Size = new System.Drawing.Size(125, 27);
            this.txtDecABin.TabIndex = 7;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(140, 7);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(294, 20);
            this.lblAviso.TabIndex = 8;
            this.lblAviso.Text = "Valor invalido (ingrese un numero positivo)";
            // 
            // FrmConversosrBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 131);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.txtDecABin);
            this.Controls.Add(this.txtBinADec);
            this.Controls.Add(this.btnConvertirABin);
            this.Controls.Add(this.btnConvertirADec);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblDecABin);
            this.Controls.Add(this.lblBinADec);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConversosrBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Numerico";
            this.Load += new System.EventHandler(this.FrmConversosrBinario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinADec;
        private System.Windows.Forms.Label lblDecABin;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnConvertirADec;
        private System.Windows.Forms.Button btnConvertirABin;
        private System.Windows.Forms.TextBox txtBinADec;
        private System.Windows.Forms.TextBox txtDecABin;
        private System.Windows.Forms.Label lblAviso;
    }
}
