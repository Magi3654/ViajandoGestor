namespace Practica_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grbTipoSeg = new System.Windows.Forms.GroupBox();
            this.rdbTotal = new System.Windows.Forms.RadioButton();
            this.rdbTerceros = new System.Windows.Forms.RadioButton();
            this.rdBasico = new System.Windows.Forms.RadioButton();
            this.grbEqAuto = new System.Windows.Forms.GroupBox();
            this.chdBEqSonido = new System.Windows.Forms.CheckBox();
            this.chdBAire = new System.Windows.Forms.CheckBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.txtBCosto = new System.Windows.Forms.TextBox();
            this.txtBRespuesta = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.grbTipoSeg.SuspendLayout();
            this.grbEqAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(114, 31);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(215, 20);
            this.txtName1.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // grbTipoSeg
            // 
            this.grbTipoSeg.Controls.Add(this.rdbTotal);
            this.grbTipoSeg.Controls.Add(this.rdbTerceros);
            this.grbTipoSeg.Controls.Add(this.rdBasico);
            this.grbTipoSeg.Location = new System.Drawing.Point(44, 92);
            this.grbTipoSeg.Name = "grbTipoSeg";
            this.grbTipoSeg.Size = new System.Drawing.Size(200, 100);
            this.grbTipoSeg.TabIndex = 2;
            this.grbTipoSeg.TabStop = false;
            this.grbTipoSeg.Text = "Tipo de Seguro";
            // 
            // rdbTotal
            // 
            this.rdbTotal.AutoSize = true;
            this.rdbTotal.Location = new System.Drawing.Point(15, 65);
            this.rdbTotal.Name = "rdbTotal";
            this.rdbTotal.Size = new System.Drawing.Size(103, 17);
            this.rdbTotal.TabIndex = 2;
            this.rdbTotal.TabStop = true;
            this.rdbTotal.Text = "Total $ 1,000.00";
            this.rdbTotal.UseVisualStyleBackColor = true;
            // 
            // rdbTerceros
            // 
            this.rdbTerceros.AutoSize = true;
            this.rdbTerceros.Location = new System.Drawing.Point(15, 42);
            this.rdbTerceros.Name = "rdbTerceros";
            this.rdbTerceros.Size = new System.Drawing.Size(109, 17);
            this.rdbTerceros.TabIndex = 1;
            this.rdbTerceros.TabStop = true;
            this.rdbTerceros.Text = "Terceros $700.00";
            this.rdbTerceros.UseVisualStyleBackColor = true;
            // 
            // rdBasico
            // 
            this.rdBasico.AutoSize = true;
            this.rdBasico.Location = new System.Drawing.Point(15, 19);
            this.rdBasico.Name = "rdBasico";
            this.rdBasico.Size = new System.Drawing.Size(99, 17);
            this.rdBasico.TabIndex = 0;
            this.rdBasico.TabStop = true;
            this.rdBasico.Text = "Básico $500.00";
            this.rdBasico.UseVisualStyleBackColor = true;
            // 
            // grbEqAuto
            // 
            this.grbEqAuto.Controls.Add(this.chdBEqSonido);
            this.grbEqAuto.Controls.Add(this.chdBAire);
            this.grbEqAuto.Location = new System.Drawing.Point(267, 92);
            this.grbEqAuto.Name = "grbEqAuto";
            this.grbEqAuto.Size = new System.Drawing.Size(200, 100);
            this.grbEqAuto.TabIndex = 3;
            this.grbEqAuto.TabStop = false;
            this.grbEqAuto.Text = "Equipamento de auto ";
            this.grbEqAuto.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chdBEqSonido
            // 
            this.chdBEqSonido.AutoSize = true;
            this.chdBEqSonido.Location = new System.Drawing.Point(7, 44);
            this.chdBEqSonido.Name = "chdBEqSonido";
            this.chdBEqSonido.Size = new System.Drawing.Size(152, 17);
            this.chdBEqSonido.TabIndex = 1;
            this.chdBEqSonido.Text = "Equipo de Sonido $700.00";
            this.chdBEqSonido.UseVisualStyleBackColor = true;
            // 
            // chdBAire
            // 
            this.chdBAire.AutoSize = true;
            this.chdBAire.Location = new System.Drawing.Point(7, 20);
            this.chdBAire.Name = "chdBAire";
            this.chdBAire.Size = new System.Drawing.Size(90, 17);
            this.chdBAire.TabIndex = 0;
            this.chdBAire.Text = "A/C $ 500.00";
            this.chdBAire.UseVisualStyleBackColor = true;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(44, 210);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(112, 13);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo del Automovil: $";
            // 
            // txtBCosto
            // 
            this.txtBCosto.Location = new System.Drawing.Point(163, 210);
            this.txtBCosto.Name = "txtBCosto";
            this.txtBCosto.Size = new System.Drawing.Size(166, 20);
            this.txtBCosto.TabIndex = 5;
            // 
            // txtBRespuesta
            // 
            this.txtBRespuesta.Location = new System.Drawing.Point(44, 251);
            this.txtBRespuesta.Multiline = true;
            this.txtBRespuesta.Name = "txtBRespuesta";
            this.txtBRespuesta.Size = new System.Drawing.Size(423, 154);
            this.txtBRespuesta.TabIndex = 6;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(361, 210);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(75, 23);
            this.btnCotizar.TabIndex = 7;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 428);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.txtBRespuesta);
            this.Controls.Add(this.txtBCosto);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.grbEqAuto);
            this.Controls.Add(this.grbTipoSeg);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtName1);
            this.Name = "Form1";
            this.Text = "Cotizador de seguros";
            this.grbTipoSeg.ResumeLayout(false);
            this.grbTipoSeg.PerformLayout();
            this.grbEqAuto.ResumeLayout(false);
            this.grbEqAuto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox grbTipoSeg;
        private System.Windows.Forms.RadioButton rdbTotal;
        private System.Windows.Forms.RadioButton rdbTerceros;
        private System.Windows.Forms.RadioButton rdBasico;
        private System.Windows.Forms.GroupBox grbEqAuto;
        private System.Windows.Forms.CheckBox chdBEqSonido;
        private System.Windows.Forms.CheckBox chdBAire;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtBCosto;
        private System.Windows.Forms.TextBox txtBRespuesta;
        private System.Windows.Forms.Button btnCotizar;
    }
}

