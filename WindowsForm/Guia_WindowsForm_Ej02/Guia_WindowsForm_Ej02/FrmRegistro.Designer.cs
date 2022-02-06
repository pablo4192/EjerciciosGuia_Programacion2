namespace Guia_WindowsForm_Ej02
{
    partial class FrmRegistro
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
            this.grbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.grbCursos = new System.Windows.Forms.GroupBox();
            this.chkJavaScript = new System.Windows.Forms.CheckBox();
            this.chkCMasMas = new System.Windows.Forms.CheckBox();
            this.chkCSharp = new System.Windows.Forms.CheckBox();
            this.lstPaises = new System.Windows.Forms.ListBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.grbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.grbGenero.SuspendLayout();
            this.grbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDetallesUsuario
            // 
            this.grbDetallesUsuario.Controls.Add(this.lblEdad);
            this.grbDetallesUsuario.Controls.Add(this.lblDireccion);
            this.grbDetallesUsuario.Controls.Add(this.lblNombre);
            this.grbDetallesUsuario.Controls.Add(this.nudEdad);
            this.grbDetallesUsuario.Controls.Add(this.txtDireccion);
            this.grbDetallesUsuario.Controls.Add(this.txtNombre);
            this.grbDetallesUsuario.Location = new System.Drawing.Point(12, 12);
            this.grbDetallesUsuario.Name = "grbDetallesUsuario";
            this.grbDetallesUsuario.Size = new System.Drawing.Size(250, 172);
            this.grbDetallesUsuario.TabIndex = 0;
            this.grbDetallesUsuario.TabStop = false;
            this.grbDetallesUsuario.Text = "Detalles del Usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(6, 146);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(0, 88);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 20);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(0, 33);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(102, 139);
            this.nudEdad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(125, 27);
            this.nudEdad.TabIndex = 2;
            this.nudEdad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(102, 85);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(125, 27);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 0;
            // 
            // grbGenero
            // 
            this.grbGenero.Controls.Add(this.rdbNoBinario);
            this.grbGenero.Controls.Add(this.rdbFemenino);
            this.grbGenero.Controls.Add(this.rdbMasculino);
            this.grbGenero.Location = new System.Drawing.Point(294, 26);
            this.grbGenero.Name = "grbGenero";
            this.grbGenero.Size = new System.Drawing.Size(250, 158);
            this.grbGenero.TabIndex = 1;
            this.grbGenero.TabStop = false;
            this.grbGenero.Text = "Genero";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(18, 125);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(101, 24);
            this.rdbNoBinario.TabIndex = 2;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(18, 84);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(95, 24);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(18, 37);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(97, 24);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grbCursos
            // 
            this.grbCursos.Controls.Add(this.chkJavaScript);
            this.grbCursos.Controls.Add(this.chkCMasMas);
            this.grbCursos.Controls.Add(this.chkCSharp);
            this.grbCursos.Location = new System.Drawing.Point(294, 226);
            this.grbCursos.Name = "grbCursos";
            this.grbCursos.Size = new System.Drawing.Size(250, 153);
            this.grbCursos.TabIndex = 2;
            this.grbCursos.TabStop = false;
            this.grbCursos.Text = "Cursos";
            // 
            // chkJavaScript
            // 
            this.chkJavaScript.AutoSize = true;
            this.chkJavaScript.Location = new System.Drawing.Point(6, 123);
            this.chkJavaScript.Name = "chkJavaScript";
            this.chkJavaScript.Size = new System.Drawing.Size(97, 24);
            this.chkJavaScript.TabIndex = 2;
            this.chkJavaScript.Text = "JavaScript";
            this.chkJavaScript.UseVisualStyleBackColor = true;
            // 
            // chkCMasMas
            // 
            this.chkCMasMas.AutoSize = true;
            this.chkCMasMas.Location = new System.Drawing.Point(6, 77);
            this.chkCMasMas.Name = "chkCMasMas";
            this.chkCMasMas.Size = new System.Drawing.Size(60, 24);
            this.chkCMasMas.TabIndex = 1;
            this.chkCMasMas.Text = "C++";
            this.chkCMasMas.UseVisualStyleBackColor = true;
            // 
            // chkCSharp
            // 
            this.chkCSharp.AutoSize = true;
            this.chkCSharp.Location = new System.Drawing.Point(6, 37);
            this.chkCSharp.Name = "chkCSharp";
            this.chkCSharp.Size = new System.Drawing.Size(49, 24);
            this.chkCSharp.TabIndex = 0;
            this.chkCSharp.Text = "C#";
            this.chkCSharp.UseVisualStyleBackColor = true;
            // 
            // lstPaises
            // 
            this.lstPaises.FormattingEnabled = true;
            this.lstPaises.ItemHeight = 20;
            this.lstPaises.Location = new System.Drawing.Point(18, 263);
            this.lstPaises.Name = "lstPaises";
            this.lstPaises.Size = new System.Drawing.Size(150, 104);
            this.lstPaises.TabIndex = 3;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(18, 226);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(34, 20);
            this.lblPais.TabIndex = 4;
            this.lblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(450, 409);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 29);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lstPaises);
            this.Controls.Add(this.grbCursos);
            this.Controls.Add(this.grbGenero);
            this.Controls.Add(this.grbDetallesUsuario);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            this.grbDetallesUsuario.ResumeLayout(false);
            this.grbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.grbGenero.ResumeLayout(false);
            this.grbGenero.PerformLayout();
            this.grbCursos.ResumeLayout(false);
            this.grbCursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDetallesUsuario;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbGenero;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grbCursos;
        private System.Windows.Forms.CheckBox chkJavaScript;
        private System.Windows.Forms.CheckBox chkCMasMas;
        private System.Windows.Forms.CheckBox chkCSharp;
        private System.Windows.Forms.ListBox lstPaises;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnIngresar;
    }
}
