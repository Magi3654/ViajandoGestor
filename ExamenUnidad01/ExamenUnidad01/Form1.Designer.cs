namespace ExamenUnidad01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNameP = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblLastP = new System.Windows.Forms.Label();
            this.lblInfoP = new System.Windows.Forms.Label();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.gbxAnticipo = new System.Windows.Forms.GroupBox();
            this.rbNotA = new System.Windows.Forms.RadioButton();
            this.rbtYesA = new System.Windows.Forms.RadioButton();
            this.gbxTours = new System.Windows.Forms.GroupBox();
            this.chdSea = new System.Windows.Forms.CheckBox();
            this.chdBWine = new System.Windows.Forms.CheckBox();
            this.txtAnticipo = new System.Windows.Forms.TextBox();
            this.lblAnticipo = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxAnticipo.SuspendLayout();
            this.gbxTours.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viajando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Formulario de reservaciones ";
            // 
            // lblNameP
            // 
            this.lblNameP.AutoSize = true;
            this.lblNameP.Location = new System.Drawing.Point(33, 75);
            this.lblNameP.Name = "lblNameP";
            this.lblNameP.Size = new System.Drawing.Size(53, 13);
            this.lblNameP.TabIndex = 2;
            this.lblNameP.Text = "Nombre : ";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(92, 75);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(150, 20);
            this.txtNombreP.TabIndex = 3;
            // 
            // lblLastP
            // 
            this.lblLastP.AutoSize = true;
            this.lblLastP.Location = new System.Drawing.Point(34, 105);
            this.lblLastP.Name = "lblLastP";
            this.lblLastP.Size = new System.Drawing.Size(44, 13);
            this.lblLastP.TabIndex = 4;
            this.lblLastP.Text = "Apellido";
            // 
            // lblInfoP
            // 
            this.lblInfoP.AutoSize = true;
            this.lblInfoP.Location = new System.Drawing.Point(67, 56);
            this.lblInfoP.Name = "lblInfoP";
            this.lblInfoP.Size = new System.Drawing.Size(100, 13);
            this.lblInfoP.TabIndex = 5;
            this.lblInfoP.Text = "Informacion del Pax";
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(92, 101);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(150, 20);
            this.txtApellidoP.TabIndex = 6;
            // 
            // gbxAnticipo
            // 
            this.gbxAnticipo.Controls.Add(this.rbNotA);
            this.gbxAnticipo.Controls.Add(this.rbtYesA);
            this.gbxAnticipo.Location = new System.Drawing.Point(36, 150);
            this.gbxAnticipo.Name = "gbxAnticipo";
            this.gbxAnticipo.Size = new System.Drawing.Size(206, 65);
            this.gbxAnticipo.TabIndex = 7;
            this.gbxAnticipo.TabStop = false;
            this.gbxAnticipo.Text = "Anticipo";
            this.gbxAnticipo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbNotA
            // 
            this.rbNotA.AutoSize = true;
            this.rbNotA.Location = new System.Drawing.Point(7, 43);
            this.rbNotA.Name = "rbNotA";
            this.rbNotA.Size = new System.Drawing.Size(39, 17);
            this.rbNotA.TabIndex = 1;
            this.rbNotA.TabStop = true;
            this.rbNotA.Text = "No";
            this.rbNotA.UseVisualStyleBackColor = true;
            // 
            // rbtYesA
            // 
            this.rbtYesA.AutoSize = true;
            this.rbtYesA.Location = new System.Drawing.Point(6, 19);
            this.rbtYesA.Name = "rbtYesA";
            this.rbtYesA.Size = new System.Drawing.Size(39, 17);
            this.rbtYesA.TabIndex = 0;
            this.rbtYesA.TabStop = true;
            this.rbtYesA.Text = "Sí ";
            this.rbtYesA.UseVisualStyleBackColor = true;
            // 
            // gbxTours
            // 
            this.gbxTours.Controls.Add(this.chdSea);
            this.gbxTours.Controls.Add(this.chdBWine);
            this.gbxTours.Location = new System.Drawing.Point(37, 222);
            this.gbxTours.Name = "gbxTours";
            this.gbxTours.Size = new System.Drawing.Size(221, 100);
            this.gbxTours.TabIndex = 8;
            this.gbxTours.TabStop = false;
            this.gbxTours.Text = "Tours";
            // 
            // chdSea
            // 
            this.chdSea.AutoSize = true;
            this.chdSea.Location = new System.Drawing.Point(6, 44);
            this.chdSea.Name = "chdSea";
            this.chdSea.Size = new System.Drawing.Size(214, 17);
            this.chdSea.TabIndex = 1;
            this.chdSea.Text = "Encuentro en la Bufadora $ 875.00 mxn";
            this.chdSea.UseVisualStyleBackColor = true;
            // 
            // chdBWine
            // 
            this.chdBWine.AutoSize = true;
            this.chdBWine.Location = new System.Drawing.Point(7, 20);
            this.chdBWine.Name = "chdBWine";
            this.chdBWine.Size = new System.Drawing.Size(187, 17);
            this.chdBWine.TabIndex = 0;
            this.chdBWine.Text = "Entre queso y vino $ 1758.00 mxn";
            this.chdBWine.UseVisualStyleBackColor = true;
            // 
            // txtAnticipo
            // 
            this.txtAnticipo.Location = new System.Drawing.Point(259, 169);
            this.txtAnticipo.Name = "txtAnticipo";
            this.txtAnticipo.Size = new System.Drawing.Size(100, 20);
            this.txtAnticipo.TabIndex = 9;
            // 
            // lblAnticipo
            // 
            this.lblAnticipo.AutoSize = true;
            this.lblAnticipo.Location = new System.Drawing.Point(259, 150);
            this.lblAnticipo.Name = "lblAnticipo";
            this.lblAnticipo.Size = new System.Drawing.Size(92, 13);
            this.lblAnticipo.TabIndex = 10;
            this.lblAnticipo.Text = "Monto de anticipo";
            this.lblAnticipo.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(273, 233);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(75, 23);
            this.btnReservar.TabIndex = 11;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.lblAnticipo);
            this.Controls.Add(this.txtAnticipo);
            this.Controls.Add(this.gbxTours);
            this.Controls.Add(this.gbxAnticipo);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.lblInfoP);
            this.Controls.Add(this.lblLastP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.lblNameP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxAnticipo.ResumeLayout(false);
            this.gbxAnticipo.PerformLayout();
            this.gbxTours.ResumeLayout(false);
            this.gbxTours.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNameP;
        private System.Windows.Forms.Label lblLastP;
        private System.Windows.Forms.Label lblInfoP;
        private System.Windows.Forms.GroupBox gbxAnticipo;
        private System.Windows.Forms.RadioButton rbNotA;
        private System.Windows.Forms.RadioButton rbtYesA;
        private System.Windows.Forms.GroupBox gbxTours;
        private System.Windows.Forms.CheckBox chdSea;
        private System.Windows.Forms.CheckBox chdBWine;
        private System.Windows.Forms.TextBox txtAnticipo;
        private System.Windows.Forms.Label lblAnticipo;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtNombreP;
        public System.Windows.Forms.TextBox txtApellidoP;
    }
}

