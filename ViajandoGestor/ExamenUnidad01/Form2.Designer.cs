namespace ExamenUnidad01
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Viajando";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gestor de Reservaciones ";
            // 
            // txtQuote
            // 
            this.txtQuote.Location = new System.Drawing.Point(45, 87);
            this.txtQuote.Multiline = true;
            this.txtQuote.Name = "txtQuote";
            this.txtQuote.Size = new System.Drawing.Size(281, 254);
            this.txtQuote.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informacion de reservación";
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(393, 170);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(75, 23);
            this.btnForm.TabIndex = 4;
            this.btnForm.Text = "Crear ";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 369);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnForm;
        public System.Windows.Forms.TextBox txtQuote;
    }
}