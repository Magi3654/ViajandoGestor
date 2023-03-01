namespace Programa01_04
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
            this.chbMonitor = new System.Windows.Forms.CheckBox();
            this.chbTeclado = new System.Windows.Forms.CheckBox();
            this.chbMouse = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbMonitor
            // 
            this.chbMonitor.AutoSize = true;
            this.chbMonitor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMonitor.Location = new System.Drawing.Point(64, 54);
            this.chbMonitor.Name = "chbMonitor";
            this.chbMonitor.Size = new System.Drawing.Size(131, 22);
            this.chbMonitor.TabIndex = 0;
            this.chbMonitor.Text = "Monitor $250";
            this.chbMonitor.UseVisualStyleBackColor = true;
            this.chbMonitor.CheckedChanged += new System.EventHandler(this.chbMonitor_CheckedChanged);
            // 
            // chbTeclado
            // 
            this.chbTeclado.AutoSize = true;
            this.chbTeclado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTeclado.Location = new System.Drawing.Point(64, 91);
            this.chbTeclado.Name = "chbTeclado";
            this.chbTeclado.Size = new System.Drawing.Size(125, 22);
            this.chbTeclado.TabIndex = 1;
            this.chbTeclado.Text = "Teclado $15";
            this.chbTeclado.UseVisualStyleBackColor = true;
            this.chbTeclado.CheckedChanged += new System.EventHandler(this.chbTeclado_CheckedChanged);
            // 
            // chbMouse
            // 
            this.chbMouse.AutoSize = true;
            this.chbMouse.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMouse.Location = new System.Drawing.Point(64, 132);
            this.chbMouse.Name = "chbMouse";
            this.chbMouse.Size = new System.Drawing.Size(117, 22);
            this.chbMouse.TabIndex = 2;
            this.chbMouse.Text = "Mouse $ 10";
            this.chbMouse.UseVisualStyleBackColor = true;
            this.chbMouse.CheckedChanged += new System.EventHandler(this.chbMouse_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(292, 54);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 30);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.Location = new System.Drawing.Point(64, 184);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(56, 18);
            this.lblSeleccion.TabIndex = 4;
            this.lblSeleccion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 291);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.chbMouse);
            this.Controls.Add(this.chbTeclado);
            this.Controls.Add(this.chbMonitor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbMonitor;
        private System.Windows.Forms.CheckBox chbTeclado;
        private System.Windows.Forms.CheckBox chbMouse;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSeleccion;
    }
}

