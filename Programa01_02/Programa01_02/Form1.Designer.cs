namespace Programa01_02
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
            this.btnSaludo = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnDespedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludo
            // 
            this.btnSaludo.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaludo.Location = new System.Drawing.Point(236, 14);
            this.btnSaludo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaludo.Name = "btnSaludo";
            this.btnSaludo.Size = new System.Drawing.Size(127, 54);
            this.btnSaludo.TabIndex = 0;
            this.btnSaludo.Text = "Saludo";
            this.btnSaludo.UseVisualStyleBackColor = true;
            this.btnSaludo.Click += new System.EventHandler(this.btnSaludo_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(275, 109);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(48, 17);
            this.lblMsg.TabIndex = 1;
            this.lblMsg.Text = "label 1";
            // 
            // btnDespedida
            // 
            this.btnDespedida.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespedida.Location = new System.Drawing.Point(236, 177);
            this.btnDespedida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDespedida.Name = "btnDespedida";
            this.btnDespedida.Size = new System.Drawing.Size(127, 54);
            this.btnDespedida.TabIndex = 2;
            this.btnDespedida.Text = "Despedida";
            this.btnDespedida.UseVisualStyleBackColor = true;
            this.btnDespedida.Click += new System.EventHandler(this.btnDespedida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 274);
            this.Controls.Add(this.btnDespedida);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnSaludo);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Practica 1-2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludo;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnDespedida;
    }
}

